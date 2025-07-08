using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocios;
using Microsoft.Data.SqlClient;

namespace CapaNegocios
{
    public class MensajeRepositorio
    {
        public void Guardar(Mensaje mensaje)
        {
            if (!mensaje.Validar())
            {
                throw new ArgumentException("El mensaje no es válido (destinatario o contenido vacíos).");
            }

            string query = @"INSERT INTO MENSAJES (Destinatario, Asunto, CuerpoMensaje, FechaEnvio, TipoMensaje, TelegramMessageId)
                             VALUES (@Destinatario, @Asunto, @CuerpoMensaje, @FechaEnvio, @TipoMensaje, @TelegramMessageId)";

            Mensajeriaconexion conexionDatos = new Mensajeriaconexion();

            using (SqlConnection connection = new SqlConnection(conexionDatos.Conexion))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Destinatario", mensaje.Destinatario);

                        if (mensaje is Gmail gmailMensaje)
                        {
                            command.Parameters.AddWithValue("@Asunto", gmailMensaje.Asunto);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Asunto", DBNull.Value);
                        }


                        command.Parameters.AddWithValue("@CuerpoMensaje", mensaje.Contenido);
                        command.Parameters.AddWithValue("@FechaEnvio", mensaje.FechaEnvio);

                        // Determinar el tipo de mensaje
                        string tipoMensaje = mensaje switch
                        {
                            Gmail => "Gmail",
                            Telegram => "Telegram",
                            _ => throw new ArgumentException("Tipo de mensaje no reconocido.")
                        };

                        command.Parameters.AddWithValue("@TipoMensaje", tipoMensaje);

                        //TODO : Manejo del ID del mensaje de Telegram
                        int? telegramId = null;

                        if (mensaje is Telegram t && t.TelegramMessageId.HasValue)
                        {
                            telegramId = t.TelegramMessageId.Value;
                        }

                        command.Parameters.AddWithValue("@TelegramMessageId", (object?)telegramId ?? DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Error de base de datos al guardar el mensaje: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error inesperado al guardar el mensaje: {ex.Message}", ex);
                }
            }
        }
    }
}



