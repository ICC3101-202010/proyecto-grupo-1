using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Almacenamiento
    {
        private List<Canciones> Lista_canciones = new List<Canciones>();
        private List<Video> Lista_videos = new List<Video>();
        private List<string> Nicknames = new List<string>();
        private List<Usuario> Usuario = new List<Usuario>();
        private List<Video> Cola_reproduccion_videos = new List<Video>();
        private List<Canciones> Cola_reproduccion_canciones = new List<Canciones>();
        private List<Canciones> Playlist_canciones = new List<Canciones>();
        private List<Video> Playlist_videos = new List<Video>();

        public List<Canciones> lista_canciones { get => Lista_canciones; set => Lista_canciones = value; }
        public List<Video> lista_videos { get => Lista_videos; set => Lista_videos = value; }
        public List<string> nicknames { get => Nicknames; set => Nicknames = value; }
        public List<Usuario> usuario { get => Usuario; set => Usuario = value; }
        public List<Video> cola_reproduccion_videos { get => Cola_reproduccion_videos; set => Cola_reproduccion_videos = value; }
        public List<Canciones> cola_reproduccion_canciones { get => Cola_reproduccion_canciones; set => Cola_reproduccion_canciones = value; }
        public List<Canciones> playlist_canciones { get => Playlist_canciones; set => Playlist_canciones = value; }
        public List<Video> playlist_videos { get => Playlist_videos; set => Playlist_videos = value; }

        public void buscar_videos(string video_buscado)
        {
            List<Video> ListaDeBusqueda = new List<Video>();
            int x = 1;
            foreach (Video i in lista_videos)
            {
                if(video_buscado == i.titulo)
                {
                    ListaDeBusqueda.Add(i);
                }
            }
            foreach (Video j in ListaDeBusqueda)
            {
                Console.WriteLine(x +") "+ j.titulo);
            }
        }

        public void buscar_cancion(string cancion_buscada)
        {
            List<Canciones> ListaDeBusqueda = new List<Canciones>();
            int x = 1;
            foreach (Canciones i in lista_canciones)
            {
                if (cancion_buscada == i.titulo)
                {
                    ListaDeBusqueda.Add(i);
                }
            }
            foreach (Canciones j in ListaDeBusqueda)
            {
                Console.WriteLine(x + ") " + j.titulo);
            }


        }

        public void add_cancion(Canciones CancionAMeter)
        {
            int x = 0;
            foreach (Canciones esta in lista_canciones)
            {
                if (CancionAMeter == esta) 
                x = 1;
            }
            if (x == 0)
                Lista_canciones.Add(CancionAMeter);


        }

        public void add_videos(Video VideoAMeter)
        {
            int x = 0;
            foreach (Video esta in lista_videos)
            {
                if (VideoAMeter == esta)
                    x = 1;
            }
            if (x == 0)
                Lista_videos.Add(VideoAMeter);
        }
        

        public void buscar_playlist(string nombreplaylist)
        {

        }

        public void crear_playlist_canciones(string playcancion)
        {

        }

        public void crear_playlist_videos(string playvideos)
        {

        }

        public void filtro_busqueda(string buscado)
        {

        }

        public void add_cola_cancion(Canciones song)
        {

        }

        public void add_cola_videos(Video mp4)
        {

        }
    }
}
