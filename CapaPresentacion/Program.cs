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
            ApplicationConfiguration.Initialize(); // Esto puede variar según la versión de .NET, déjalo como esté si ya funciona.

            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           //TODO cargará el archivo de desarrollo y sobrescribirá los valores
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
            .Build();


            string telegramBotToken = configuration.GetSection("TelegramBot:Token").Value;

            if (!string.IsNullOrEmpty(telegramBotToken))
            {
                CapaNegocios.Telegram.SetBotToken(telegramBotToken);
            }
            else
            {
                MessageBox.Show("Error: Token de Telegram no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gmailAppPassword = configuration.GetSection("Gmail:ApplicationPassword").Value;
            string gmailSenderEmail = configuration.GetSection("Gmail:SenderEmail").Value;

            if (!string.IsNullOrEmpty(gmailAppPassword) && !string.IsNullOrEmpty(gmailSenderEmail))
            {
                CapaNegocios.Gmail.GuardarCredenciales(gmailSenderEmail, gmailAppPassword);
            }
            else
            {
                MessageBox.Show("Advertencia: Credenciales de Gmail incompletas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Application.Run(new Form1());
        }
    }
}