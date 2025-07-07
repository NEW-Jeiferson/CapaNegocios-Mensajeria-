using CapaDatos;
using System;
using CapaNegocios;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        private List<string> _rutasArchivosAdjuntos = new List<string>(); // Lista para almacenar las rutas de los archivos adjuntos


        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }

        private void TXTenviarA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTmensaje_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TXTasunto_TextChanged(object sender, EventArgs e)
        {

        }



        private void BTNenviarguardar_Click(object sender, EventArgs e)
        {
            //TODO Validar que el campo de destinatario no esté vacío y tenga un formato y un dominio de correo electrónico válido
            if (string.IsNullOrWhiteSpace(TXTenviarA.Text) || !ValidarFormatoCorreo(TXTenviarA.Text) || !ValidarDominioFlexible(TXTenviarA.Text))
            {
                MessageBox.Show("El destinatario debe ser un correo electrónico válido con dominio permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //TODO Validar los campos de entrada antes de enviar el correo
            CapaNegocios.Gmail emailParaEnviar = new CapaNegocios.Gmail();
            emailParaEnviar.Destinatario = TXTenviarA.Text.Trim();
            emailParaEnviar.Asunto = TXTasunto.Text.Trim();
            emailParaEnviar.CuerpoMensaje = TXTmensaje.Text.Trim();
            emailParaEnviar.FechaEnvio = DateTime.Now;
            emailParaEnviar.RutasAdjuntos = _rutasArchivosAdjuntos;

            //TODO Validar que los campos requeridos no estén vacíos
            if (!emailParaEnviar.Validar())
            {
                MessageBox.Show("Todos los campos obligatorios (destinatario, asunto y mensaje) deben estar completos.", "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //TODO Enviar el correo electrónico y que se guarde en la DB
                emailParaEnviar.Enviar();
                MensajeRepositorio repo = new MensajeRepositorio();
                repo.Guardar(emailParaEnviar);

                MessageBox.Show("Gmail enviado y Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ioEx)
            {
                //TODO Manejar la excepción si las credenciales de Gmail no están configuradas
                MessageBox.Show($"Error de configuración de Gmail: {ioEx.Message}", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine($"Excepción de configuración: {ioEx}");
            }
            catch (System.Net.Mail.SmtpException smtpEx)
            {
                //TODO Manejar la excepción SMTP al enviar el correo
                MessageBox.Show($"Error SMTP al enviar Gmail: {smtpEx.Message}\nAsegúrate de que el destinatario sea válido.", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine($"Excepción SMTP: {smtpEx}");
            }
            catch (FileNotFoundException fnfEx)
            {
                //TODO Manejar la excepción si un archivo adjunto no se encuentra
                MessageBox.Show($"Error al adjuntar archivo: {fnfEx.Message}", "Error de Envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine($"Excepción de archivo no encontrado: {fnfEx}");
            }
            catch (Exception ex)
            {
                //TODO Manejar cualquier otra excepción general
                MessageBox.Show($"Ocurrió un error al Enviar o Guardar el Gmail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine($"Excepción general: {ex}");
            }

            LimpiarCampos();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LBLfiles.Text = "No se seleccionaron archivos adjuntos.";
        }

        private void LimpiarCampos()
        {

            TXTasunto.Clear();
            TXTmensaje.Clear();
            _rutasArchivosAdjuntos.Clear(); // Borrar la lista de adjuntos
            LBLfiles.Text = "No se seleccionaron archivos adjuntos.";
        }

        private void BTNadjuntar_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }

        public void AdjuntarArchivos()
        {
            _rutasArchivosAdjuntos.Clear();

            OpenFileDialog ofd = new OpenFileDialog(); // Cuadro de diálogo para abrir archivos
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar Archivos a Correo";

            if (ofd.ShowDialog() == DialogResult.OK) //Si el usuario presiona OK
            {
                _rutasArchivosAdjuntos.AddRange(ofd.FileNames); //TODO Agregar las rutas seleccionadas
            }

            //TODO Actualizar la etiqueta LBLfiles con los nombres de los archivos
            if (_rutasArchivosAdjuntos.Count > 0)
            {
                //TODO Mostrar solo el nombre del archivo, no la ruta completa, separados por saltos de línea
                LBLfiles.Text = string.Join("\n", _rutasArchivosAdjuntos.Select(Path.GetFileName));
            }
            else
            {
                LBLfiles.Text = "No se seleccionaron archivos adjuntos.";
            }
        }


        private void TXTenviarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si no es una letra, ni un número, ni punto, ni arroba, ni tecla de control
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //TODO Bloquea el caracter
            }
        }

        private void TXTasunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si no es una letra y no es una tecla de control, se bloquea
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //TODO Bloquea la tecla
            }
        }

        private bool ValidarFormatoCorreo(string correo)
        {
            try
            {
                //TODO Intenta crear una instancia de MailAddress para validar el formato del correo
                var mail = new System.Net.Mail.MailAddress(correo.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarDominioFlexible(string correo)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(correo.Trim());
                string dominio = mail.Host.ToLower();

                //TODO Lista de terminaciones válidas para el dominio
                List<string> terminacionesValidas = new List<string>
                {
                    ".com",
                    ".net",
                    ".org",
                    ".edu",
                    ".edu.do",
                    ".gov",
                    ".do",
                    ".es"
                };

                //TODO Verifica si el dominio contiene un punto y termina con una de las terminaciones válidas
                return dominio.Contains('.') && terminacionesValidas.Any(t => dominio.EndsWith(t));
            }
            catch
            {
                return false; //TODO Si ocurre un error al validar el dominio, retorna falso
            }
        }
    }
}




