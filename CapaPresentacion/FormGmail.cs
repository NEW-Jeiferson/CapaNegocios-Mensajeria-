using CapaDatos;
using System;
using CapaNegocios;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace CapaPresentacion
{
    public partial class FormGmail : Form
    {
        private ErrorProvider errorProviderCorreo = new ErrorProvider(); //TODO : Manejar errores de validaci�n de correo electr�nico
        private List<string> _rutasArchivosAdjuntos = new(); //TODO : Lista para almacenar m�ltiples rutas de archivos adjuntos

        public FormGmail()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.TXTenviarA.TextChanged += TXTenviarA_TextChanged; //TODO : Evento para validar el correo electr�nico ingresado
        }

        private void TXTenviarA_TextChanged(object sender, EventArgs e)
        {
            //TODO : Validar el correo electr�nico ingresado en el campo TXTenviarA
            string correo = TXTenviarA.Text.Trim();
            if (!ValidarCorreoCompleto(correo))
                errorProviderCorreo.SetError(TXTenviarA, "Por favor, ingresa un correo electr�nico v�lido y con un dominio permitido.");
            else
                errorProviderCorreo.SetError(TXTenviarA, "");

        }

        private void TXTmensaje_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TXTasunto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNenviarguardar_Click(object sender, EventArgs e)
        {
            string correo = TXTenviarA.Text.Trim(); //TODO : Obtener el correo electr�nico del destinatario

            //TODO : Validar que el correo electr�nico sea v�lido y tenga un dominio permitido
            if (!ValidarCorreoCompleto(correo))
            {
                MessageBox.Show("Ingrese un correo electr�nico v�lido y los campos faltantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //TODO : Crear una instancia de Gmail con los datos ingresados
            Gmail emailParaEnviar = new()
            {
                Destinatario = correo,
                Asunto = TXTasunto.Text.Trim(),
                CuerpoMensaje = TXTmensaje.Text.Trim(),
                FechaEnvio = DateTime.Now,
                RutasAdjuntos = _rutasArchivosAdjuntos
            };

            try
            {
                //TODO : Validar que todos los campos obligatorios est�n completos
                if (!emailParaEnviar.Validar())
                {
                    MessageBox.Show("Todos los campos obligatorios (destinatario, asunto y mensaje) deben estar completos.", "Validaci�n de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //TODO : Enviar el correo electr�nico utilizando el m�todo Enviar de la clase Gmail
                emailParaEnviar.Enviar();
                MensajeRepositorio repo = new();
                repo.Guardar(emailParaEnviar);

                MessageBox.Show("Gmail enviado y Guardado con �xito.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show($"Error de configuraci�n de Gmail: {ioEx.Message}", "Error de Env�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Net.Mail.SmtpException smtpEx)
            {
                MessageBox.Show($"Error SMTP al enviar Gmail: {smtpEx.Message}\nAseg�rate de que el destinatario sea v�lido.", "Error de Env�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show($"Error al adjuntar archivo: {fnfEx.Message}", "Error de Env�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error al Enviar o Guardar el Gmail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LBLfiles.Text))
                LBLfiles.Text = "No se seleccionaron archivos adjuntos.";
        }

        private void LimpiarCampos()
        {
            TXTasunto.Clear();
            TXTmensaje.Clear();
            _rutasArchivosAdjuntos.Clear();
            LBLfiles.Text = "No se seleccionaron archivos adjuntos.";
        }

        private void BTNadjuntar_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }

        public void AdjuntarArchivos()
        {
            //TODO : Permitir al usuario seleccionar m�ltiples archivos para adjuntar al correo
            OpenFileDialog ofd = new()
            {
                Multiselect = true,
                Title = "Adjuntar Archivos a Correo"
            };

            //TODO : Filtrar los tipos de archivos permitidos (opcional)
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //TODO : Verificar si las rutas de los archivos ya est�n en la lista
                foreach (var archivo in ofd.FileNames)
                {
                    //TODO : Validar que el archivo exista y no est� vac�o
                    if (!_rutasArchivosAdjuntos.Contains(archivo))
                        _rutasArchivosAdjuntos.Add(archivo);
                }
            }

            //TODO : Actualizar la etiqueta LBLfiles para mostrar los nombres de los archivos adjuntos seleccionados
            LBLfiles.Text = _rutasArchivosAdjuntos.Count > 0
                ? string.Join("\n", _rutasArchivosAdjuntos.Select(Path.GetFileName))
                : "No se seleccionaron archivos adjuntos.";
        }

        private void TXTenviarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO : Validar que solo se ingresen caracteres v�lidos en el campo de correo electr�nico
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXTasunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO : Permite solo letras, espacios y teclas de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea cualquier otro car�cter
            }
        }

        private bool ValidarCorreoCompleto(string correo)
        {
            //TODO : Validar que el correo electr�nico no est� vac�o y tenga un formato v�lido
            if (string.IsNullOrWhiteSpace(correo)) return false;

            try
            {
                //TODO : Verificar que el correo tenga un formato v�lido y un dominio permitido
                var mail = new System.Net.Mail.MailAddress(correo);
                string dominio = mail.Host.ToLower();

                List<string> terminacionesValidas = new()
                {
                    ".com", ".net", ".org", ".edu", ".edu.do", ".gov", ".do", ".es"
                };

                //TODO : Comprobar que el dominio tenga una terminaci�n v�lida
                return dominio.Contains('.') && terminacionesValidas.Any(t => dominio.EndsWith(t));
            }
            catch
            {
                return false;
            }
        }

    }
}




