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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CargarHistorialGmail();
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
    }
}
