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

        }

        public void buscar_cancion(string cancion_buscada)
        {

        }

        public void add_cancion(string path)
        {

        }

        public void add_videos(string path)
        {

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
