using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private const string BotToken = "7823587100:AAHe4zBNa4xpCO9ClkU6PnFP6FWFe6nk_Lc";

        public override async void Enviar()
        {
            //TODO Creamos una instancia del cliente del bot de telegram Usando nuestro Token
            var botClient = new TelegramBotClient(BotToken);

            try
            {
                
                if (!long.TryParse(Destinatario, out long chatId)) 
                {
                    throw new ArgumentException("El destinatario para Telegram debe ser un ID de chat válido.");
                }

                await botClient.SendTextMessageAsync(
                    chatId: new ChatId(chatId),
                    text: this.Contenido,
                    parseMode: ParseMode.Html
                );

            }
            catch (FormatException ex)
            {
                throw new ArgumentException("El destinatario para TELEGRAM debe ser un ID de chat válido.", ex);
            }


        }

        public override bool Validar()
        {
            bool baseValidation = base.Validar();

            bool isChatIdNumeric = long.TryParse(Destinatario, out _);

            return baseValidation && isChatIdNumeric;
        }

    }   

}
