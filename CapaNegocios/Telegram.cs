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
        public List<string> RutasImagenes { get; set; } = new(); // Lista para almacenar múltiples rutas de imágenes

        private static TelegramBotClient BotClientInstance
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
            _botClient = null; // Reinicia el cliente para usar el nuevo token
        }

        public override async Task Enviar()
        {

            if (!long.TryParse(Destinatario, out long chatId))
                throw new ArgumentException("El destinatario para Telegram debe ser un ID de chat numérico válido.");

            var tieneImagenes = RutasImagenes.Any(ruta => System.IO.File.Exists(ruta));
            var tieneTexto = !string.IsNullOrWhiteSpace(Contenido);

            //Cuando tenemos Solo mensaje de texto
            if (!tieneImagenes && tieneTexto)
            {
                await BotClientInstance.SendTextMessageAsync(
                    chatId: chatId,
                    text: Contenido,
                    parseMode: ParseMode.Html
                );
                Console.WriteLine($"Mensaje de texto enviado a {chatId}");
                return;
            }

            //Cuando Es Solo imágenes o imágenes + Texto
            if (tieneImagenes)
            {
                var mediaGroup = new List<IAlbumInputMedia>();
                var fileStreams = new List<FileStream>();

                try
                {
                    foreach (var ruta in RutasImagenes)
                    {
                        if (System.IO.File.Exists(ruta))
                        {
                            var stream = System.IO.File.OpenRead(ruta);
                            fileStreams.Add(stream);

                            var inputMedia = new InputMediaPhoto(new InputFileStream(stream, Path.GetFileName(ruta)));
                            mediaGroup.Add(inputMedia);
                        }
                    }

                    if (mediaGroup.Count > 0)
                    {
                        //Si también hay texto, lo agregamos como caption a la primera imagen
                        if (tieneTexto && mediaGroup[0] is InputMediaPhoto primeraFoto)
                        {
                            primeraFoto.Caption = Contenido;
                            primeraFoto.ParseMode = ParseMode.Html;
                        }

                        await BotClientInstance.SendMediaGroupAsync(chatId, mediaGroup);
                        Console.WriteLine($"Se enviaron {mediaGroup.Count} imágenes al chat ID: {chatId}");
                    }
                }
                finally
                {
                    foreach (var stream in fileStreams)
                        stream.Dispose();
                }

                return;
            }

            //Para cuando No hay texto ni imágenes válidas
            throw new InvalidOperationException("No se proporcionó texto ni imágenes válidas para enviar.");
        }
        

        public override bool Validar()
        {
            bool baseValidacion = base.Validar();
            bool chatIdValido = long.TryParse(Destinatario, out _);
            return baseValidacion && chatIdValido;
        }
    }
}
