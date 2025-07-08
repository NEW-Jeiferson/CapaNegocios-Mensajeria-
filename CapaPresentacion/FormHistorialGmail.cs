using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormHistorialGmail : Form
    {
        public FormHistorialGmail()
        {
            InitializeComponent();
            ConfigurarDataGridviewNoEditable(); // Configura el DataGridView para que no sea editable

        }

        private void CargarHistorialGmail()
        {
            Mensajeriaconexion conexionDatos = new Mensajeriaconexion();

            try
            {
                using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
                {
                    conn.Open();

                    string query = @"SELECT Id, Destinatario, Asunto, CuerpoMensaje, FechaEnvio
                             FROM MENSAJES
                             WHERE TipoMensaje = 'Gmail'";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    DGVgmail.DataSource = tabla;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar el historial de Gmail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormGmail_Load(object sender, EventArgs e)
        {
            CargarHistorialGmail();
        }

        private void ConfigurarDataGridviewNoEditable()
        {
            // Reemplaza 'tuDataGridView' con el nombre de tu DataGridView
            DGVgmail.ReadOnly = true;
            DGVgmail.AllowUserToAddRows = false;
            DGVgmail.AllowUserToDeleteRows = false;

            // Opcional: Otras propiedades útiles para un DataGridView de solo lectura
            DGVgmail.AllowUserToResizeColumns = true;  // ¿Permitir cambiar el tamaño de las columnas?
            DGVgmail.AllowUserToResizeRows = false;   // ¿Permitir cambiar el tamaño de las filas?
            DGVgmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; // Ajuste automático de la altura de la cabecera
            DGVgmail.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa al hacer clic
            DGVgmail.MultiSelect = false; // Permitir seleccionar solo una fila a la vez
            DGVgmail.EditMode = DataGridViewEditMode.EditProgrammatically; // Solo se puede editar programáticamente
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            //TODO : Verifica si hay una fila seleccionada en el DataGridView
            if (DGVgmail.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Selecciona un mensaje de Gmail para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //TODO : Preguntamos al usuario si está seguro de eliminar el mensaje
            DialogResult resultado = MessageBox.Show(
                "¿Estás full seguro que quieres eliminar el mensaje de la base de datos?",
                "Confirma Eliminación del Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            //TODO : Obtenemos el ID del mensaje seleccionado
            int idMensaje = Convert.ToInt32(DGVgmail.SelectedRows[0].Cells["Id"].Value);

            try
            {
                //TODO : Conectamos a la base de datos y eliminamos el mensaje
                using (SqlConnection conn = new SqlConnection(new Mensajeriaconexion().Conexion))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM MENSAJES WHERE Id = @Id AND TipoMensaje = 'Gmail'", conn);
                    cmd.Parameters.AddWithValue("@Id", idMensaje);
                    cmd.ExecuteNonQuery(); 

                    MessageBox.Show("Mensaje de Gmail eliminado correctamente de la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarHistorialGmail();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al eliminar el mensaje: {ex.Message}", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
