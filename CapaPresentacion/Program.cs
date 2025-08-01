using System;
using CapaNegocios;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize(); // Esto puede variar seg�n la versi�n de .NET, d�jalo como est� si ya funciona.

            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //TODO : Cargar la configuraci�n desde el archivo appsettings.json
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           //TODO cargar� el archivo de desarrollo y sobrescribir� los valores
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
            .Build();


            string telegramBotToken = configuration["TelegramBot:Token"];

            if (!string.IsNullOrEmpty(telegramBotToken))
            {
                CapaNegocios.Telegram.SetBotToken(telegramBotToken);
            }
            else
            {
                MessageBox.Show("Error: Token de Telegram no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gmailAppPassword = configuration["Gmail:ApplicationPassword"];
            string gmailSenderEmail = configuration["Gmail:SenderEmail"];

            if (!string.IsNullOrEmpty(gmailAppPassword) && !string.IsNullOrEmpty(gmailSenderEmail))
            {
                CapaNegocios.Gmail.GuardarCredenciales(gmailSenderEmail, gmailAppPassword);
            }
            else
            {
                MessageBox.Show("Advertencia: Credenciales de Gmail incompletas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Application.Run(new FormPresentacion());
        }
    }
}