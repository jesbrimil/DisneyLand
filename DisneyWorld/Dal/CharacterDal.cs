using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DisneyWorld.Dal
{
    public class CharacterDal
    {
        public string SaveCharacter(Personaje personaje)
        {
            int PersonajeNumber = 1;

            string pje = personaje.Imagen + "," + personaje.Nombre + "," + personaje.Edad + "," + personaje.Peso + ":";
            string historia = personaje.Historia;
            string separador = ":";
            string peliculas="";
            string series = "";

            foreach (var pelicula in personaje.Peliculas)
            {
                peliculas = peliculas +","+ pelicula;
            }
            foreach (var serie in personaje.Series)
            {
                series = series +","+ serie;
            }

            List<string> Datos = new List<string>();



            Datos.Add(pje);
            Datos.Add(historia);
            Datos.Add(separador);
            Datos.Add(peliculas);
            Datos.Add(separador);
            Datos.Add(series);


            string txtName = $@"C:\DisneyWorld\{personaje.Nombre}.txt";

            try
            {
                File.WriteAllLines(txtName, Datos);
                return "se guardo el usuario";


            }
            catch (Exception)
            {

                throw new Exception("personaje ya agregado, intente con otro");
            }


        }

        public SavePeliculas(Peliculas peliculas)
        { }

        public SaveSeries(Series series)
        { }




        public Peliculas GetPeliculas(string Nombre)
        {
            string txtName = $@"c:\DisneyWorld\Peliculas\{Nombre}.txt";


        }
        public Series GetSeries(string Nombre)
        {
            string txtName = $@"c:\DisneyWorld\Series\{Nombre}.txt";



        }
        public Personaje GetCharacter(Personaje personaje)
        {
            string txtName = $@"c:\DisneyWorld\{personaje.Nombre}.txt";
            Personaje PjeObtenido = new Personaje();


            if (File.Exists(txtName))
            {
                string Datos = File.ReadAllText(txtName);


                foreach (var dato in Datos)
                {
                    try
                    {
                        var splitDatos=Datos.Split(':');
                        var splitPersonaje = splitDatos[0].Split(',');
                        PjeObtenido.Imagen =splitPersonaje[0];
                        PjeObtenido.Nombre = splitPersonaje[1];
                        PjeObtenido.Edad = int.Parse(splitPersonaje[2]);
                        PjeObtenido.Peso = int.Parse(splitPersonaje[3]);

                        PjeObtenido.Historia = splitDatos[2];

                        var splitPeliculas = splitDatos[3].Split(',');

                        foreach (var pelicula in splitPeliculas)
                        {
                            PjeObtenido.Peliculas.Add(pelicula);
                        }

                        var splitSeries = splitDatos[4].Split(',');

                        foreach (var serie in splitSeries)
                        {
                            PjeObtenido.Series.Add(serie);
                        }






                    }
                    catch (Exception)
                    {

                        throw new Exception("no se pudo obtener el personaje");

                    }

                }


            }
            else
            {
                throw new Exception("no se pudo obtener el personaje");

            }

            return PjeObtenido;

        }

    }
}