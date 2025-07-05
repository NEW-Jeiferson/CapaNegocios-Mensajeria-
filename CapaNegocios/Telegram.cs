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

        private static TelegramBotClient BotClientInstance
        {
            get
            {
                if (_botClient == null)
                {
                    if (string.IsNullOrEmpty(_botToken))
                    {
                        throw new InvalidOperationException("El token del bot de Telegram no se ha configurado");
                    }
                    _botClient = new TelegramBotClient(_botToken);
                }
                return _botClient;
            }
        }

        public static void SetBotToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentNullException(nameof(token), "El Token de Bot de Telegram no puede ser nulo o vacío.");
            }
            _botToken = token;
            _botClient = null;
        }

        public override async void Enviar()
        {
            try
            {
                if (!long.TryParse(Destinatario, out long chatId))
                {
                    throw new ArgumentException("El destinatario para Telegram debe ser un ID de chat numérico válido.");
                }

                await BotClientInstance.SendTextMessageAsync(
                    chatId: new ChatId(chatId),
                    text: this.Contenido,       
                    parseMode: ParseMode.Html
                );
                Console.WriteLine($"Mensaje de Telegram (texto) enviado a chat ID: {chatId}");

            }
            // --- Bloque de manejo de excepciones ---
            catch (ApiRequestException apiEx)
            {
                Console.Error.WriteLine($"Error en la API de Telegram al enviar mensaje: {apiEx.Message}");
                throw new Exception($"Error de la API de Telegram: {apiEx.Message}", apiEx);
            }
            catch (FormatException ex)
            {
                Console.Error.WriteLine($"Error de formato del ID de chat en Telegram: {ex.Message}");
                throw new ArgumentException("El destinatario para Telegram debe ser un ID de chat numérico válido.", ex);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Ocurrió un error inesperado al enviar el mensaje de Telegram: {ex.Message}");
                throw new Exception($"Error inesperado al enviar mensaje de Telegram: {ex.Message}", ex);
            }
        }

        public override bool Validar()
        {
            bool baseValidation = base.Validar();
            bool isChatIdNumeric = long.TryParse(Destinatario, out _);

            // El mensaje es válido si pasa la validación de la clase base Y la validación específica del ID de chat.
            return baseValidation && isChatIdNumeric;
        }
    }
}
