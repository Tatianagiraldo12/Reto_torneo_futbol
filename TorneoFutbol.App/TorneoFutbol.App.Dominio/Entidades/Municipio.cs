using System;
namespace TorneoFutbol.App.Dominio
{
    /// <summary>Class <c>Municipio</c>
    /// Modela un Municipio 
    /// </summary>   
    public class Municipio 
    {
        /// Id de cada municipio 
        public int ID { get; set; }    
        ///Nombre del municipio 
        public string Nombre { get; set; }
        ///Nombre del departamento 
        public string Departamento { get; set; }
        public Estadio Estadio {get; set;}
    }
}