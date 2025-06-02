using System;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace Mensajeria
{
    //Clase Principal Mensaje 
    public class Mensaje
    {
        // Propiedades de la clase Mensaje que se heredaran en las clases derivadas
        public int Id { get; set; } // Identificador del mensaje
        public string Contenido { get; set; } // Contenido del mensaje
        public string Destinatario { get; set; } // Destinatario del mensaje (Email, Whatsapp, Sms)
        public string Tipo { get; set; } // Tipo de mensaje (Email, Whatsapp, Sms)

        //Metodo Virtual para enviar el mensaje y que pueda ser sobreescrito en las clases derivadas
        public virtual void Enviar()
        {
            // Lógica para enviar el mensaje
            Console.WriteLine($"Enviando {Tipo} a {Destinatario}: {Contenido} ");
        }

        // Método para guardar el mensaje en la base de datos
        public void Guardar()
        {
            // Lógica para guardar el mensaje en la base de datos
            using (SqlConnection conexion = new SqlConnection(new Mensajeriaconexion().Conexion))
            {
                conexion.Open();
                string query = "INSERT INTO Mensajes (Contenido, Destinatario, Tipo) VALUES (@Contenido, @Destinatario, @Tipo)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Contenido", Contenido);
                    comando.Parameters.AddWithValue("@Destinatario", Destinatario);
                    comando.Parameters.AddWithValue("@Tipo", Tipo);
                    comando.ExecuteNonQuery();
                }
            }

        }

    }

    // Clase derivada de Mensaje para enviar mensajes de Email
    public class Email : Mensaje
    {
        // Constructor que inicializa el tipo de mensaje como Email
        public Email() { Tipo = "Email"; }

        // Método que envía el mensaje de Email
        public override void Enviar()
        {
            // Lógica específica para enviar un Email
            Console.WriteLine($"Enviando Correo Electronico a {Destinatario} con Asunto: {Contenido}");
        }
    }

    // Clase derivada de Mensaje para enviar mensajes de Whatsapp
    public class Whatsapp : Mensaje
    {
        // Constructor que inicializa el tipo de mensaje como Whatsapp
        public Whatsapp() { Tipo = "Whatsapp"; }

        // Método que envía el mensaje de Whatsapp
        public override void Enviar()
        {
            // Lógica específica para enviar un mensaje de Whatsapp
            Console.WriteLine($"Enviando mensaje de Whatsapp a {Destinatario}: {Contenido}");
        }

    }

    // Clase derivada de Mensaje para enviar mensajes de SMS
    public class Sms : Mensaje
    {
        // Constructor que inicializa el tipo de mensaje como Sms
        public Sms() { Tipo = "Sms"; }

        public override void Enviar()
        {
            // Lógica específica para enviar un SMS
            Console.WriteLine($"Enviando SMS a {Destinatario}: {Contenido}");
        }

    }

        



}
