using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Importacion_Exportacion
    {
       
        public Importacion_Exportacion()
        {

        }//pendiente

        void agregar_cancion(string path)
        {
            Console.WriteLine("Ingrese Titulo");
            string titulo = Console.ReadLine();
            Console.WriteLine("Calidad");
            string calidad = Console.ReadLine();
            Console.WriteLine("Tamaño");
            string tamaño = Console.ReadLine();
            Console.WriteLine("Estudio");
            string estudio = Console.ReadLine();
            Console.WriteLine("Genero");
            string genero = Console.ReadLine();
            Console.WriteLine("Fecha de publicacion");
            string fechapublicacion = Console.ReadLine();
            Console.WriteLine("Descripcion");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Letra de la cancion");
            string letra = Console.ReadLine();
            Console.WriteLine("Genero Del Compositor");
            Console.WriteLine("Genero del Cantante");
            Console.WriteLine();
            //Canciones canci = new Canciones();
        }

        void agregar_video(string path)
        {

        }

        void quitar_cancion(Canciones cancion)
        {

        }

        void quitar_videos(Video mp4)
        {

        }

        void foto_de_portada(string path)
        {

        }

    }
}
