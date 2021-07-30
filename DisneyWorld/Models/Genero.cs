using System.Collections.Generic;

namespace DisneyWorld.Models
{
    public  class Genero
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public List<Peliculas> Peliculas { get; set; }
        public List<Series> Series { get; set; }

    }
}