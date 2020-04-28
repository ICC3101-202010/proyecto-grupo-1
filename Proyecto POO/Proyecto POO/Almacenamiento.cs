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

        public void buscar_videos(string video_buscado)
        {
            List<Video> ListaDeBusqueda = new List<Video>();
            int x = 1;
            foreach (Video video in Lista_videos)
            {
                if(video_buscado == video.Get_Titulo())
                {
                    ListaDeBusqueda.Add(video);
                }
            }
            foreach (Video video in ListaDeBusqueda)
            {
                Console.WriteLine(x +") "+ video.Get_Titulo());
            }
        }

        public void buscar_cancion(string cancion_buscada)
        {
            List<Canciones> ListaDeBusqueda = new List<Canciones>();
            int x = 1;
            foreach (Canciones cancion in Lista_canciones)
            {
                if (cancion_buscada == cancion.Get_Titulo())
                {
                    ListaDeBusqueda.Add(cancion);
                }
            }
            foreach (Canciones cancion in ListaDeBusqueda)
            {
                Console.WriteLine(x + ") " + cancion.Get_Titulo());
            }


        }

        public void add_cancion(Canciones CancionAMeter)
        {
            int x = 0;
            foreach (Canciones esta in Lista_canciones)
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
            foreach (Video esta in Lista_videos)
            {
                if (VideoAMeter == esta)
                    x = 1;
            }
            if (x == 0)
                Lista_videos.Add(VideoAMeter);
        }
        
        public void AgregarPersona(Usuario user)
        {
            Usuario.Add(user);
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
