using System;
using System.Collections.Generic;
using System.Linq; // Para manejar listas
using System.Net; // Para manejar las credenciales de la cuenta de Gmail
using System.Net.Mail; // Para enviar correos electrónicos
using System.Text;
using System.Threading.Tasks;
using System.IO; // Para manejar archivos adjuntos

namespace CapaNegocios
{
    public class Gmail : Mensaje
    {
        private static string _senderEmail;
        private static string _applicationPassword;

        public string Asunto { get; set; } = string.Empty;
        public List<string> RutasAdjuntos { get; set; } = new List<string>();

        //Método estático para configurar las credenciales de Gmail
        public static void GuardarCredenciales(string senderEmail, string applicationPassword)
        {
            if (string.IsNullOrEmpty(senderEmail))
            {
                throw new ArgumentNullException(nameof(senderEmail), "El correo del remitente de Gmail no puede ser nulo o vacío.");
            }
            if (string.IsNullOrEmpty(applicationPassword))
            {
                throw new ArgumentNullException(nameof(applicationPassword), "La contraseña de aplicación de Gmail no puede ser nula o vacía.");
            }

            _senderEmail = senderEmail;
            _applicationPassword = applicationPassword;
        }

        public string CuerpoMensaje
        {
            get => Contenido;
            set => Contenido = value;
        }


        public override async Task Enviar()
        {
            //TODO Verificar que las credenciales estén configuradas antes de intentar enviar
            if (string.IsNullOrEmpty(_senderEmail) || string.IsNullOrEmpty(_applicationPassword))
            {
                throw new InvalidOperationException("Las credenciales de Gmail no se han configurado");
            }

            MailMessage message = null;
            try
            {
                MailAddress addressFrom = new MailAddress(_senderEmail, "GoatComm");
                MailAddress addressTo = new MailAddress(this.Destinatario.Trim());
                message = new MailMessage(addressFrom, addressTo);

                message.Subject = this.Asunto;
                message.Body = this.CuerpoMensaje;
                message.IsBodyHtml = false;

                foreach (string filePath in RutasAdjuntos)
                {
                    if (File.Exists(filePath))
                    {
                        message.Attachments.Add(new Attachment(filePath));
                    }
                    else
                    {
                        throw new FileNotFoundException($"El archivo adjunto no fue encontrado: {filePath}");
                    }
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_senderEmail, _applicationPassword);

                client.Send(message); 
            }
            catch (SmtpException ex)
            {
                throw new Exception($"Error SMTP al enviar Gmail: {ex.StatusCode} - {ex.Message}\nAsegúrate de que las credenciales sean válidas.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al enviar el Gmail: {ex.Message}", ex);
            }
            finally
            {
                if (message != null)
                {
                    foreach (Attachment attachment in message.Attachments)
                    {
                        attachment.Dispose();
                    }
                    message.Dispose(); 
                }
            }
        }

        public override bool Validar()
        {
            bool baseValidation = base.Validar(); // Valida Destinatario y Contenido
            bool gmailSpecificValidation = !string.IsNullOrWhiteSpace(Asunto);

            // Validación robusta del correo
            bool isValidEmailFormat = false;
            try
            {
                var mail = new MailAddress(Destinatario.Trim());
                isValidEmailFormat = true;
            }
            catch
            {
                isValidEmailFormat = false;
            }

            return baseValidation && gmailSpecificValidation && isValidEmailFormat;
        }
    }
}
