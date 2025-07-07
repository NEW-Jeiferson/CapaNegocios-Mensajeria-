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
    public partial class FormGmail : Form
    {
        public FormGmail()
        {
            InitializeComponent();
        
        }

        private void CargarHistorialGmail()
        {
            Mensajeriaconexion conexionDatos = new Mensajeriaconexion();

            try
            {
                using (SqlConnection conn = new SqlConnection(conexionDatos.Conexion))
                {
                    conn.Open();

                    string query = @"SELECT Id, Destinatario, CuerpoMensaje, FechaEnvio
                             FROM MENSAJES
                             WHERE TipoMensaje = 'Gmail'";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    DGVGMAIL.DataSource = tabla;
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
    }
}
