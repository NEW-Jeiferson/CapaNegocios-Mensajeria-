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
            _botClient = null; //TODO Reinicia el cliente para usar el nuevo token
        }

        public override async Task Enviar()
        {
            if (!long.TryParse(Destinatario, out long chatId))
                throw new ArgumentException("El destinatario debe ser un ID de chat numérico válido.");

            var tieneImagenes = RutasImagenes.Any(ruta => System.IO.File.Exists(ruta)); //Investigar que es => 
            var tieneTexto = !string.IsNullOrWhiteSpace(Contenido);

            //TODO Por diferentes Complicaciones Pondre que solo se pueden enviar imagen si hay texto
            if (!tieneTexto)
                throw new InvalidOperationException("Debes ingresar un mensaje de texto para enviar.");

            //TODO Cuando es solo un texto sin imagen
            if (!tieneImagenes)
            {
                await BotClientInstance.SendTextMessageAsync(
                    chatId: chatId,
                    text: Contenido,
                    parseMode: ParseMode.Html
                );
                Console.WriteLine($"Mensaje de texto enviado a {chatId}");
                return;
            }

            //TODO Cuando tenemos Texto e Imágenes
            var rutasValidas = RutasImagenes.Where(r => System.IO.File.Exists(r)).ToList();
            var fileStreams = new List<FileStream>();

            try
            {
                //TODO Si solo hay una imagen
                if (rutasValidas.Count == 1)
                {
                    using var stream = System.IO.File.OpenRead(rutasValidas[0]);
                    var file = new InputFileStream(stream, Path.GetFileName(rutasValidas[0]));

                    await BotClientInstance.SendPhotoAsync(
                        chatId: chatId,
                        photo: file,
                        caption: Contenido,
                        parseMode: ParseMode.Html
                    );
                    Console.WriteLine("Imagen + texto enviado.");
                    return;
                }

                //TODO Si hay varias imágenes
                var mediaGroup = new List<IAlbumInputMedia>();
                for (int idx = 0; idx < rutasValidas.Count; idx++)
                {
                    var stream = System.IO.File.OpenRead(rutasValidas[idx]);
                    fileStreams.Add(stream);

                    var media = new InputMediaPhoto(new InputFileStream(stream, Path.GetFileName(rutasValidas[idx])));

                    if (idx == 0) // Texto como caption solo en la primera imagen
                    {
                        media.Caption = Contenido;
                        media.ParseMode = ParseMode.Html;
                    }

                    mediaGroup.Add(media);
                }

                await BotClientInstance.SendMediaGroupAsync(chatId, mediaGroup);
                Console.WriteLine($"Álbum con {mediaGroup.Count} imágenes enviado.");
            }
            finally
            {
                foreach (var stream in fileStreams) 
                    stream.Dispose();
            }
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
