using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex
{
    [Serializable()]
    public class Playlist
    {
        private string name;
        private List<Canciones> Playlist_canciones = new List<Canciones>();
        private List<Video> Playlist_videos = new List<Video>();
        private List<Usuario> Seguidores = new List<Usuario>();
        private bool priv;
        private string foto;

        public Playlist(string name, List<Canciones> playlist_canciones, List<Video> playlist_videos, List<Usuario> seguidores, bool priv,string foto)
        {
            this.Name = name;
            Playlist_canciones1 = playlist_canciones;
            Playlist_videos1 = playlist_videos;
            Seguidores1 = seguidores;
            this.priv = priv;
            this.foto = foto;
        }

        public string Name { get => name; set => name = value; }
        public List<Canciones> Playlist_canciones1 { get => Playlist_canciones; set => Playlist_canciones = value; }
        public List<Video> Playlist_videos1 { get => Playlist_videos; set => Playlist_videos = value; }
        public List<Usuario> Seguidores1 { get => Seguidores; set => Seguidores = value; }
        public string Foto { get => foto; set => foto = value; }
        public bool Priv { get => priv; set => priv = value; }


        public List<Canciones> Mostrar_Canciones()
        {
            return Playlist_canciones1;
        }

        public List<Video> Mostrar_Videos()
        {
            return Playlist_videos1;
        }

    }
}
