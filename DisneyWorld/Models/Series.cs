using System;
using System.Collections.Generic;

namespace DisneyWorld.Models
{
    public class Series
    {
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime FCreacion{get;set;}
        public int Calificacion { get; set; }
        public Genero Genero { get; set; }
        public List<Personaje> Personajes { get; set; }
    }
}