using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CapaNegocios;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.Enums;




namespace CapaNegocios
{
    public class Telegram : Mensaje
    {
        private static string? _botToken;
        private static TelegramBotClient? _botClient;

        public string? RutaImagen { get; set; } // Propiedad opcional para la imagen

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

        public override async void Enviar()
        {
            try
            {
                if (!long.TryParse(Destinatario, out long chatId))
                    throw new ArgumentException("El destinatario para Telegram debe ser un ID de chat numérico válido.");
                if (!string.IsNullOrEmpty(RutaImagen) && System.IO.File.Exists(RutaImagen))
                {
                    using var stream = System.IO.File.OpenRead(RutaImagen);

                    await BotClientInstance.SendPhotoAsync(
                        chatId: chatId,
                        photo: new InputFileStream(stream),
                        caption: this.Contenido,
                        parseMode: ParseMode.Html
                    );

                    Console.WriteLine($"Imagen enviada a chat ID: {chatId}");
                }
                else
                {
                    await BotClientInstance.SendTextMessageAsync(
                        chatId: chatId,
                        text: this.Contenido,
                        parseMode: ParseMode.Html
                    );

                    Console.WriteLine($"Mensaje de texto enviado a chat ID: {chatId}");
                }
            }
            catch (ApiRequestException apiEx)
            {
                Console.Error.WriteLine($"Error en la API de Telegram al enviar: {apiEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error inesperado al enviar mensaje: {ex.Message}");
                throw;
            }
        }

        public override bool Validar()
        {
            bool baseValidacion = base.Validar();
            bool chatIdValido = long.TryParse(Destinatario, out _);
            return baseValidacion && chatIdValido;
        }
    }
}
