using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormHistorialTelegram : Form
    {

        public FormHistorialTelegram()
        {
            InitializeComponent();
            ConfigurarDataGridviewNoEditable(); // Configura el DataGridView para que no sea editable
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarHistorialTelegram();
        }

        private void CargarHistorialTelegram()
        {
            Mensajeriaconexion conexionDatos = new Mensajeriaconexion();

            try
            {
                using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
                {
                    conn.Open();

                    string query = @"SELECT Id, Destinatario, CuerpoMensaje, FechaEnvio
                             FROM MENSAJES
                             WHERE TipoMensaje = 'Telegram'";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    DGVtelegram.DataSource = tabla;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar el historial de Telegram: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void ConfigurarDataGridviewNoEditable()
        {
            // Reemplaza 'tuDataGridView' con el nombre de tu DataGridView
            DGVtelegram.ReadOnly = true;
            DGVtelegram.AllowUserToAddRows = false;
            DGVtelegram.AllowUserToDeleteRows = false;

            // Opcional: Otras propiedades útiles para un DataGridView de solo lectura
            DGVtelegram.AllowUserToResizeColumns = true;  // ¿Permitir cambiar el tamaño de las columnas?
            DGVtelegram.AllowUserToResizeRows = false;   // ¿Permitir cambiar el tamaño de las filas?
            DGVtelegram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; // Ajuste automático de la altura de la cabecera
            DGVtelegram.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa al hacer clic
            DGVtelegram.MultiSelect = false; // Permitir seleccionar solo una fila a la vez
            DGVtelegram.EditMode = DataGridViewEditMode.EditProgrammatically; // Solo se puede editar programáticamente
        }
        

        
    }
    
}
