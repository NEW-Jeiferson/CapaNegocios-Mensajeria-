using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Para permitir el arrastre de la ventana

namespace CapaPresentacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BTNcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación al hacer clic en el botón de cerrar
        }

        private void BTNmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Maximiza la ventana al hacer clic en el botón de maximizar
            BTNmaximizar.Visible = false; // Oculta el botón de maximizar
            BTNrestaurar.Visible = true; // Muestra el botón de restaurar
        }

        private void BTNrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; // Restaura la ventana al estado normal
            BTNrestaurar.Visible = false; // Oculta el botón de restaurar
            BTNmaximizar.Visible = true; // Muestra el botón de maximizar
        }

        private void BTNminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana al hacer clic en el botón de minimizar
        }

        /// <summary>
        /// Importa y declara la función nativa SendMessage de user32.dll.
        /// Permite enviar mensajes de bajo nivel a ventanas y controles de Windows
        /// para simular interacciones (ej. clics, teclas) o controlar su comportamiento.
        //TODO Permite arrastrar la ventana al hacer clic y arrastrar en el área del título
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Envía un mensaje para mover la ventana
        }

        private void BTNhistorial_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Esta línea alterna la visibilidad del panel 'SubmenuHistorial'.
            /// Si 'SubmenuHistorial.Visible' es 'true' (está visible), el operador '!' (NOT lógico)
            /// lo convierte en 'false', haciendo que el panel se oculte.
            /// Si 'SubmenuHistorial.Visible' es 'false' (está oculto), el operador '!'
            /// lo convierte en 'true', haciendo que el panel se muestre.
            /// De esta manera, el mismo botón sirve para mostrar y ocultar el panel.
            SubmenuHistorial.Visible = !SubmenuHistorial.Visible;
        }

        private void BTNhitorialTelegram_Click(object sender, EventArgs e)
        {
            SubmenuHistorial.Visible = false; // Oculta el submenú de historial al hacer clic en el botón
        }

        private void BTNhistorialGmail_Click(object sender, EventArgs e)
        {
            SubmenuHistorial.Visible = false; // Oculta el submenú de historial al hacer clic en el botón
        }
    }
}
