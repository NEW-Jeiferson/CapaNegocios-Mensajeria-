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
            //TODO Validaciones
            if (string.IsNullOrWhiteSpace(TXTenviarA.Text))
            {
                MessageBox.Show("El campo 'Enviar a' no puede estar vacío.", "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TXTasunto.Text))
            {
                MessageBox.Show("El Campo 'Asunto' no puede estar Vacío.", "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TXTmensaje.Text))
            {
                MessageBox.Show("El Campo 'Mensaje' no puede estar Vacío.", "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //TODO Crear un objeto de negocio (Gmail) con los datos del formulario
                Gmail emailParaEnviar = new Gmail();
                emailParaEnviar.Destinatario = TXTenviarA.Text.Trim();
                emailParaEnviar.Asunto = TXTasunto.Text.Trim();
                emailParaEnviar.CuerpoMensaje = TXTmensaje.Text.Trim();
                emailParaEnviar.FechaEnvio = DateTime.Now; // La fecha de envío es el momento actual
                emailParaEnviar.RutasAdjuntos = _rutasArchivosAdjuntos; // Pasar las rutas de los adjuntos

                //TODO Llamar a la lógica de negocio para enviar el email
                emailParaEnviar.Enviar(); // La clase Gmail se encarga de todo el SMTP

                //TODO Llamar a la lógica de negocio para guardar el mensaje
                MensajeRepositorio repo = new MensajeRepositorio();
                repo.Guardar(emailParaEnviar); // El repositorio se encarga de la interacción con la DB


                MessageBox.Show("Gmail enviado y Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al Enviar o Guardar el Gmail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BTNinicio_Click(object sender, EventArgs e)
        {
            Form2 nuevoForm = new Form2(); //TODO Nos pasa de nuestro form de Gmail hacia el form Principal
            nuevoForm.Show();
            this.Hide(); //TODO Esconde nuestro formulario de Gmail cuando volvemos al Form principal
        }
    }


}

