using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocios;
using Microsoft.Data.SqlClient;
//1

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

            string query = "INSERT INTO MENSAJES (Destinatario, Asunto, CuerpoMensaje, FechaEnvio, TipoMensaje)" +
                           "VALUES (@Destinatario, @Asunto, @CuerpoMensaje, @FechaEnvio, @TipoMensaje)";

            //TODO Crear una instancia de Mensajeriaconexion para obtener la cadena de conexión
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
                        command.Parameters.AddWithValue("@TipoMensaje", mensaje.GetType().Name);

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



