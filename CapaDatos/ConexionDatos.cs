using System;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Mensajeriaconexion
    {
        // cadena de conexion a SQL SERVER 
        public string Conexion { get; } = "Server=.;Database=MensajeriaSMTP;Integrated Security=true" + " ;TrustServerCertificate=True;";

    }

}

