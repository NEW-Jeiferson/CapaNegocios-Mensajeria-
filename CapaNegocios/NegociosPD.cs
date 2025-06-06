using System;
using CapaDatos;
using Microsoft.Data.SqlClient;
//entrega final 2.1
namespace Mensajeria
{
    // Repositorio para manejar la persistencia de mensajes en la base de datos
    public class MensajeRepositorio
    {
        // Método para guardar un mensaje en la base de datos
        public void Guardar (Mensaje mensaje)
        {
            mensaje.Validar(); // Validar el mensaje antes de guardarlo

            // Validar que el contenido y destinatario del mensaje no estén vacíos
            if (string.IsNullOrWhiteSpace(mensaje.Contenido) || string.IsNullOrWhiteSpace(mensaje.Destinatario))
                throw new ArgumentException("Contenido y Destinatario son obligatorios."); // Validación de argumentos

            using (SqlConnection conexion = new SqlConnection(new Mensajeriaconexion().Conexion))
            {
                // Abrir la conexión a la base de datos
                conexion.Open();
                string query = "INSERT INTO Mensaje (Contenido, Destinatario, Tipo) VALUES (@Contenido, @Destinatario, @Tipo)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Asignar los parámetros del comando con los valores del mensaje
                    comando.Parameters.AddWithValue("@Contenido", mensaje.Contenido);
                    comando.Parameters.AddWithValue("@Destinatario", mensaje.Destinatario);
                    comando.Parameters.AddWithValue("@Tipo", mensaje.Tipo);
                    // Ejecutar el comando para insertar el mensaje en la base de datos
                    comando.ExecuteNonQuery();
                }
            }
            
        }
    }

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


        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Contenido))
                throw new ArgumentException("El contenido del mensaje no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Destinatario))
                throw new ArgumentException("El destinatario del mensaje no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Tipo))
                throw new ArgumentException("El tipo de mensaje no puede estar vacío.");
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
            Console.WriteLine($"Enviando {Tipo} a {Destinatario} con Asunto: {Contenido}");
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
            Console.WriteLine($"Enviando mensaje de {Tipo} a {Destinatario}: {Contenido}");
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
            Console.WriteLine($"Enviando {Tipo} a {Destinatario}: {Contenido}");
        }

    }


        
}
