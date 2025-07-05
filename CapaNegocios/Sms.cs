using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios;

namespace CapaNegocios
{

    // Clase derivada de Mensaje para enviar mensajes de SMS
    public class Sms : Mensaje
    {

        public override async Task Enviar()
        {
            // Lógica específica para enviar un SMS
            Console.WriteLine($"Enviando SMS a {Destinatario}: {Contenido}");
        }


    }


}
