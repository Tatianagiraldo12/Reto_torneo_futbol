using System;
using System.Collections.Generic;
namespace TorneoFutbol.App.Dominio
{
     /// <summary>Class <c>Equipo</c>
     /// Modela una Equipo en general en el sistema 
     /// </summary>        
    public class Equipo
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DirectorTecnico Director { get; set; }
        public Municipio Municipio { get; set; } 
        public Desempenio Desempenio {get;set;}
        public List<Jugador> Jugadores { get; set; } 
        
    }
}