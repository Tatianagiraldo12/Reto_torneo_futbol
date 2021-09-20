using System;
namespace TorneoFutbol.App.Dominio

{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>        
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string NumeroTelefono { get; set; }
        
    }
}