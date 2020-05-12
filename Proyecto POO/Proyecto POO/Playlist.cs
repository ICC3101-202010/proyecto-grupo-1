using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    [Serializable()]
    public class Playlist
    {
        private string name;

        private List<Canciones> Playlist_canciones = new List<Canciones>();
        private List<Video> Playlist_videos = new List<Video>();
        private List<Usuario> Seguidores = new List<Usuario>();


        public Playlist(string name, List<Canciones> Playlist_canciones, List<Video> Playlist_videos, List<Usuario> Seguidores)
        {
            this.name = name;
            this.Playlist_canciones = Playlist_canciones;
            this.Playlist_videos = Playlist_videos;
            this.Seguidores = Seguidores;
        }

        public void Seguir(Usuario usu)
        {
            int verificador = 1;
            foreach (Usuario data in Seguidores)
            {
                if (usu.Get_Nickname() == data.Get_Nickname())
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                Seguidores.Add(usu);
            }
            else
            {
                Console.WriteLine("No puedes seguir a esta playlist");
            }
        }

        public void MostrarCanciones()
        {
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Canciones pertenecientes");
            int i = 1;
            foreach (Canciones data in Playlist_canciones)
            {
                Console.Write(i + " ) ");
                data.informacion();
                i++;
            }
            Console.WriteLine("Seguidores: " + Seguidores.Count());
        }

        public void MostrarVideos()
        {
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Videos pertenecientes");
            int i = 1;
            foreach (Video data in Playlist_videos)
            {
                Console.Write(i + " ) ");
                data.informacion();
                i++;
            }
            Console.WriteLine("Seguidores: " + Seguidores.Count());
        }

        public List<Canciones> Get_Playlist_Canciones()
        {
            return Playlist_canciones;
        }

        public List<Video> Get_Playlist_Video()
        {
            return Playlist_videos;
        }

        public string Get_Name()
        {
            return name;
        }

        public List<Usuario> Get_Seguidores()
        {
            return Seguidores;
        }

        public void Add_Music_To_Playlist(Canciones cancion)
        {
            Playlist_canciones.Add(cancion);
        }

        public void Add_Videos_To_Playlist(Video videos)
        {
            Playlist_videos.Add(videos);
        }
    }
}