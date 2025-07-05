using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                if (string.IsNullOrWhiteSpace(contenido) && rutasImagenes.Count == 0)
                {
                    MessageBox.Show("Debes ingresar contenido o al menos una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CapaNegocios.Telegram mensaje = new CapaNegocios.Telegram
                {
                    Destinatario = destinatario,
                    Contenido = contenido,
                    RutasImagenes = rutasImagenes
                };

                if (!mensaje.Validar())
                {
                    MessageBox.Show("El destinatario debe ser un ID numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await mensaje.Enviar();
                MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void BTNinicio_Click(object sender, EventArgs e)
        {
            Form2 nuevoForm = new Form2(); //TODO Nos pasa de nuestro form de Gmail hacia el form Principal
            nuevoForm.Show();
            this.Dispose(); //TODO Esconde nuestro formulario de Gmail cuando volvemos al Form principal
        }

        private void LimpiarCampos()
        {
            TXTmensajeTelegram.Clear();
            LBLfiles.Text = string.Empty;
            rutasImagenes.Clear();
        }
    }
}
