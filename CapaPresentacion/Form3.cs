using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Form3 : Form
    {
        private List<string> rutasImagenes = new();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void BTNenviarMensaje_Click(object sender, EventArgs e)
        {
            try
            {
                string destinatario = TXTtelegramChatId.Text.Trim();
                string contenido = TXTmensajeTelegram.Text.Trim();

                if (string.IsNullOrWhiteSpace(destinatario))
                {
                    MessageBox.Show("El campo Destinatario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(contenido))
                {
                    MessageBox.Show("Debes ingresar un mensaje de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var mensaje = new CapaNegocios.Telegram
                {
                    Destinatario = destinatario,
                    Contenido = contenido,
                    RutasImagenes = rutasImagenes // Puede estar vacío
                };

                if (!mensaje.Validar())
                {
                    MessageBox.Show("El destinatario debe ser un ID numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await mensaje.Enviar();
                MensajeRepositorio repo = new MensajeRepositorio();
                repo.Guardar(mensaje);

                MessageBox.Show("Mensaje enviado y Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar mensaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();
        }

        private void BTNadjuntar_Click(object sender, EventArgs e)
        {

            using OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dialogo.Multiselect = true;
            dialogo.Title = "Selecciona una o más imágenes";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                rutasImagenes = dialogo.FileNames.ToList();
                LBLfiles.Text = string.Join(", ", rutasImagenes.Select(Path.GetFileName));
            }
        }

        private void LimpiarCampos()
        {
            TXTmensajeTelegram.Clear();
            LBLfiles.Text = string.Empty;
            rutasImagenes.Clear();
        }

        private void BTNlimpiarFotos_Click(object sender, EventArgs e)
        {
            LimpiarFIles();
        }

        private void LimpiarFIles()
        {
            rutasImagenes.Clear();
            LBLfiles.Text = string.Empty;
        }

        private void TXTtelegramChatId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO Permite solo dígitos, control y el signo menos "-"
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; //TODO Ignora la tecla si no es un dígito, control o signo menos
            }

            //TODO Solo permite un signo menos al principio
            if (e.KeyChar == '-' && ((sender as TextBox).SelectionStart != 0 || (sender as TextBox).Text.Contains("-")))
            {
                e.Handled = true;
            }
        }
    }
}
