using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CapaNegocios;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.Enums;
using System.Linq;




namespace CapaNegocios
{
    public class Telegram : Mensaje
    {
        private static string? _botToken;
        private static TelegramBotClient? _botClient;
        public List<string> RutasImagenes { get; set; } = new(); //Lista para almacenar múltiples rutas de imágenes
        public int? TelegramMessageId { get; set; } //ID del mensaje enviado por Telegram


        public static TelegramBotClient BotClientInstance
        {
            get
            {
                if (_botClient == null)
                {
                    if (string.IsNullOrEmpty(_botToken))
                        throw new InvalidOperationException("El token del bot de Telegram no se ha configurado");

                    _botClient = new TelegramBotClient(_botToken);
                }
                return _botClient;
            }
        }

        public static void SetBotToken(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(nameof(token), "El Token de Bot de Telegram no puede ser nulo o vacío.");

            _botToken = token;
            _botClient = null; //TODO Reinicia el cliente para usar el nuevo token
        }

        public override async Task Enviar()
        {
            if (!long.TryParse(Destinatario, out long chatId))
                throw new ArgumentException("El destinatario debe ser un ID de chat numérico válido.");

            //TODO : Verifica que el token del bot esté configurado
            var me = await BotClientInstance.GetMeAsync();
            Console.WriteLine($"Bot conectado como @{me.Username}");

            var tieneImagenes = RutasImagenes.Any(ruta => System.IO.File.Exists(ruta)); // => es un lam
            var tieneTexto = !string.IsNullOrWhiteSpace(Contenido);

            //TODO Por diferentes Complicaciones Pondre que solo se pueden enviar imagen si hay texto
            if (!tieneTexto)
                throw new InvalidOperationException("Debes ingresar un mensaje de texto para enviar.");

            //TODO : Filtra las rutas de imágenes válidas
            var rutasValidas = RutasImagenes
            .Where(ruta => System.IO.File.Exists(ruta))
            .ToList();


            //TODO : Cuando es solo un texto sin imagen
            if (rutasValidas.Count == 0)
            {
                //Solo texto
                var sentMessage = await BotClientInstance.SendTextMessageAsync(
                    chatId: chatId,
                    text: Contenido,
                    parseMode: ParseMode.Html
                );

                TelegramMessageId = sentMessage.MessageId;
                Console.WriteLine($"Mensaje de texto enviado a {chatId}");
                return;
            }

            //TODO : Cuando es una imagen con texto
            if (rutasValidas.Count == 1)
            {
                //Solo una imagen y texto
                using var stream = System.IO.File.OpenRead(rutasValidas[0]);
                var file = InputFile.FromStream(stream, Path.GetFileName(rutasValidas[0]));

                var sentPhotoMessage = await BotClientInstance.SendPhotoAsync(
                    chatId: chatId,
                    photo: file,
                    caption: Contenido,
                    parseMode: ParseMode.Html
                );

                TelegramMessageId = sentPhotoMessage.MessageId;
                Console.WriteLine("Imagen y texto enviado.");
                return;
            }

            //TODO : Cuando son varias imagenes con texto
            throw new InvalidOperationException("Solo se permite enviar una imagen como máximo.");
        }

        //Valida que el destinatario sea un ID numérico válido y que el contenido no esté vacío.
        public override bool Validar()
        {
            bool baseValidacion = base.Validar();
            bool chatIdValido = long.TryParse(Destinatario, out _);
            return baseValidacion && chatIdValido;
        }
    }
}
