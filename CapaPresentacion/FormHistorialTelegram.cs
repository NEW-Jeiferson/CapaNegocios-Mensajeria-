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
using Telegram.Bot;
using Telegram.Bot.Exceptions;

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

                    string query = @"SELECT Id, Destinatario, CuerpoMensaje, FechaEnvio, TelegramMessageId, TipoMensaje
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

        private async void BTNeliminarTelegram_Click(object sender, EventArgs e)
        {
            //TODO : Verifica que se haya seleccionado una fila antes de intentar eliminar
            if (DGVtelegram.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un mensaje para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //TODO : Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show(
                "¿Estás full seguro que quieres eliminar el mensaje de Telegram?",
                "Confirma la eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            //TODO : Si el usuario no confirma, no se realiza ninguna acción
            if (resultado != DialogResult.Yes)
            {
                return;
            }
            //TODO : Obtiene el ID del mensaje seleccionado y el TelegramMessageId
            int idMensaje = Convert.ToInt32(DGVtelegram.SelectedRows[0].Cells["Id"].Value);
            object telegramIdObj = DGVtelegram.SelectedRows[0].Cells["TelegramMessageId"].Value;
            string destinatarioStr = DGVtelegram.SelectedRows[0].Cells["Destinatario"].Value.ToString();

            long telegramMessageId = 0;
            bool canDeleteFromTelegram = false;
            //TODO : Verifica si el TelegramMessageId es válido y puede ser eliminado de Telegram
            if (telegramIdObj != DBNull.Value && telegramIdObj != null)
            {
                //TODO : Intenta convertir el TelegramMessageId a long
                if (long.TryParse(telegramIdObj.ToString(), out telegramMessageId))
                {
                    canDeleteFromTelegram = true;
                }
                else
                {
                    MessageBox.Show("El 'TelegramMessageId' no es un número válido. No se intentará eliminar de Telegram.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Este mensaje no tiene un 'TelegramMessageId' asociado. Solo se eliminará de la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //TODO : Verifica que el destinatario sea un Chat ID válido
            long chatId = 0;
            if (!long.TryParse(destinatarioStr, out chatId))
            {
                MessageBox.Show("El 'Destinatario' no es un Chat ID válido. No se intentará eliminar de Telegram.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                canDeleteFromTelegram = false;
            }
            //TODO : Si se puede eliminar de Telegram, intenta eliminar el mensaje
            if (canDeleteFromTelegram)
            {
                try
                {
                    //TODO : Elimina el mensaje de Telegram usando el BotClientInstance
                    await CapaNegocios.Telegram.BotClientInstance.DeleteMessageAsync(
                        chatId: chatId,
                        messageId: (int)telegramMessageId
                    );
                    MessageBox.Show("Mensaje eliminado de Telegram correctamente.", "Éxito en Telegram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //TODO : Maneja las excepciones específicas de la API de Telegram
                catch (ApiRequestException apiEx)
                {
                    MessageBox.Show($"Error de la API de Telegram al eliminar el mensaje: {apiEx.Message}\nCode: {apiEx.ErrorCode}", "Error de Telegram", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo eliminar el mensaje de Telegram (error inesperado): {ex.Message}", "Error de Telegram", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                //TODO : Elimina el mensaje de la base de datos
                using (SqlConnection conn = new SqlConnection(new Mensajeriaconexion().Conexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM MENSAJES WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", idMensaje);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mensaje eliminado correctamente de la base de datos.", "Éxito en Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorialTelegram();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar de la base de datos: {ex.Message}", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
