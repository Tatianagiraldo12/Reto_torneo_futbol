using System;
namespace TorneoFutbol.App.Dominio
{
    /// <summary>Class <c>Arbitro</c>
    /// Modela un Arbitro 
    /// </summary>   
    public class Arbitro  
    {

        public int ID { get; set; }
        public string Nombre{ get; set; } 
        public string Documento{ get; set; } 
        public string NumeroTelefono{ get; set; } 
        public string Colegio { get; set; }    

    }
}