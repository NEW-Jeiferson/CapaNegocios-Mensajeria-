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
        //Empty para que inicialice las propiedades con valores por defecto
        public string Asunto { get; set; } = string.Empty;
        public string CuerpoMensaje { get; set; } = string.Empty; 
        public List<string> RutasAdjuntos { get; set; } = new List<string>(); // Para los archivos a adjuntar

      
        private const string SenderEmail = "goatcomm2002@gmail.com";
        private const string SenderPassword = "purmgcasgkmbldno";
        private const string SenderAlias = "GoatComm";

        public override void Enviar() // Implementación del método abstracto Enviar()
        {
            MailMessage message = null;
            try
            {
                MailAddress addressFrom = new MailAddress(SenderEmail, SenderAlias);
                MailAddress addressTo = new MailAddress(this.Destinatario);
                message = new MailMessage(addressFrom, addressTo);

                message.Subject = this.Asunto;       
                message.Body = this.CuerpoMensaje;   
                message.IsBodyHtml = false;

                foreach (string filePath in RutasAdjuntos) 
                {
                    if (File.Exists(filePath)) // Verifica si el archivo existe antes de adjuntarlo
                    {
                        message.Attachments.Add(new Attachment(filePath));
                    }
                    else
                    {
                        throw new FileNotFoundException($"El archivo adjunto no fue encontrado: {filePath}");
                    }
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587; // Puerto SMTP para Gmail
                client.EnableSsl = true;
                client.UseDefaultCredentials = false; 
                client.Credentials = new NetworkCredential(SenderEmail, SenderPassword);

                client.Send(message);
                this.Contenido = this.CuerpoMensaje; //TODO Asigna el contenido del mensaje al campo Contenido de la clase base Mensaje
            }
            catch (SmtpException ex)
            {
                throw new Exception($"Error SMTP al enviar Gmail: {ex.StatusCode} - {ex.Message}\n" +
                                                        $"Asegúrate de que las credenciales sean válidas.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al enviar el Gmail: {ex.Message}", ex); 
            }
            finally
            {
                //TODO liberar los recursos utilizados por el mensaje
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


        public override bool Validar() // ¡Añade o asegura este método!
        {
            bool baseValidation = base.Validar();

            bool gmailSpecificValidation = !string.IsNullOrWhiteSpace(Asunto) &&
                                           !string.IsNullOrWhiteSpace(CuerpoMensaje);

            // Combina ambas validaciones
            return baseValidation && gmailSpecificValidation;
        }
    }
}
