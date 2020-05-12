using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Proyecto_POO
{
    [Serializable()]
    public class Canciones : Multimedia
    {
        private string Letra { get; set; }
        private string Album { get; set; }

        private List<Personas> PersonasCancion = new List<Personas>();

        private List<string> ComentariosDeLaCancion = new List<string>();




        public Canciones(string Letra, List<Personas> PersonasCancion, int Duracion, string Titulo, string Fecha_Inclusion, List<int> Ranking, long Size, List<string> Genero,
            string Estudio, string CarpetaArchivo, string Fecha_publicacion, string Descripcion, int Numero_reproducciones, List<string> Comentarios, string Album,string Portada, List<Usuario> Seguidores) : base(Duracion, Titulo, Fecha_Inclusion,
            Ranking, Size, Genero, Estudio, CarpetaArchivo, Fecha_publicacion, Descripcion, Numero_reproducciones, Comentarios,Portada,Seguidores)
        {

            this.Letra = Letra;
            this.PersonasCancion = PersonasCancion;
            this.Numero_reproducciones = Numero_reproducciones;
            this.Album = Album;
        }

        public void informacion()
        {
            string persona = "";
            for (int i = 0; i < PersonasCancion.Count(); i++)
            {
                persona += PersonasCancion[i].Get_Name() + " " + PersonasCancion[i].Get_LastName() + " ";
            }
            Console.WriteLine("El titulo de la cancion es: " + Titulo + "\nCantada por " + persona + "\nLa cancion dura " + Duracion +
                "\npublicada por el estudio " + Estudio + "\nPublicada en: " + Fecha_publicacion + "\nSe a reproducido " + Numero_reproducciones +
                "\nSeguidores"+ Seguidores.Count() +"\nSu ranking es " + Get_Mean_Tier() );
            Console.WriteLine("Los comentarios de la cancion son:");
            for (int i = 0; i < Comentarios.Count(); i++)
            {
                Console.WriteLine(Comentarios[i]);
            }
        }
        public string Get_Letra()
        {
            return this.Letra;
        }

        public string Get_Album()
        {
            return this.Album;
        }

        public List<Personas> Get_Artistas()
        {
            return this.PersonasCancion;
        }


        public List<string> Get_Comentarios_Cancion()
        {
            return this.ComentariosDeLaCancion;
        }

        public override string ToString()
        {
            return this.Titulo;
        }


    }
}
