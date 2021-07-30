using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Models
{
    public class Personaje
    {
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public string Historia{ get; set; }
        public List<Peliculas> Peliculas { get; set; }
        public List<Series> Series { get; set; }

    }
}
