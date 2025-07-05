using System;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaNegocios;

public abstract class Mensaje
{
    public int Id { get; set; } 
    public string Contenido { get; set; }  = string.Empty;
    public string Destinatario { get; set; } = string.Empty;
    public DateTime FechaEnvio { get; set; } = DateTime.Now;
 

    public abstract Task Enviar(); 

    public virtual bool Validar() 
    {
        return !string.IsNullOrWhiteSpace(Destinatario) && !string.IsNullOrWhiteSpace(Contenido);
    }


}
    
