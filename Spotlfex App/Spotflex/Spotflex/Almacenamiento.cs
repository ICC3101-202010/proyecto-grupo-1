using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;

namespace Spotflex
{
    [Serializable()]
    public class Almacenamiento
    {
        private List<Canciones> lista_canciones = new List<Canciones>();
        private List<Video> lista_videos = new List<Video>();
        private List<Usuario> usuario = new List<Usuario>();
        private List<Video> cola_reproduccion_videos = new List<Video>();
        private List<Canciones> cola_reproduccion_canciones = new List<Canciones>();
        private List<Playlist> playlist_multimedia = new List<Playlist>();
        private List<Personas> persona = new List<Personas>();


        public List<Canciones> Lista_canciones { get => lista_canciones; set => lista_canciones = value; }
        public List<Video> Lista_videos { get => lista_videos; set => lista_videos = value; }
        public List<Usuario> Usuario { get => usuario; set => usuario = value; }
        public List<Video> Cola_reproduccion_videos { get => cola_reproduccion_videos; set => cola_reproduccion_videos = value; }
        public List<Canciones> Cola_reproduccion_canciones { get => cola_reproduccion_canciones; set => cola_reproduccion_canciones = value; }
        public List<Playlist> Playlist_multimedia { get => playlist_multimedia; set => playlist_multimedia = value; }
        public List<Personas> Persona { get => persona; set => persona = value; }

        public int comprobarusuario(string nom, string contra)
        {
            for (int i = 0; i < Usuario.Count(); i++)
            {
                if (Usuario[i].Nickname == nom && Usuario[i].Contraseña == contra)
                {
                    return 1;
                }
            }
            return 0;
        }

        public void Save()
        {
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream = new FileStream("canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream5 = new FileStream("videos.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream6 = new FileStream("usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream8 = new FileStream("playlist.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter3.Serialize(stream, Lista_canciones.Count());
            for (int i = 0; i < Lista_canciones.Count(); i++)
            {
                formatter3.Serialize(stream, Lista_canciones[i]);
            }
            stream.Close();
            formatter3.Serialize(stream5, Lista_videos.Count());
            for (int i = 0; i < Lista_videos.Count(); i++)
            {
                formatter3.Serialize(stream5, Lista_videos[i]);
            }
            stream5.Close();
            formatter3.Serialize(stream6, Usuario.Count());
            for (int i = 0; i < Usuario.Count(); i++)
            {
                formatter3.Serialize(stream6, Usuario[i]);
            }
            stream6.Close();
            formatter3.Serialize(stream8, Playlist_multimedia.Count());
            for (int i = 0; i < Playlist_multimedia.Count(); i++)
            {
                formatter3.Serialize(stream8, Playlist_multimedia[i]);
            }
            stream8.Close();
        }

        public void Quitar_cancion(Canciones cancion)
        {
            Lista_canciones.Remove(cancion);
        }

        public void Quitar_videon(Video mp4)
        {
            Lista_videos.Remove(mp4);
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
        public void add_playlist(Playlist playlits)
        {
            int x = 0;
            foreach (Playlist esta in Playlist_multimedia)
            {
                if (playlits == esta)
                    x = 1;
            }
            if (x == 0)
                Playlist_multimedia.Add(playlits);
        }

        public void AgregarUsuario(Usuario user)
        {
            Usuario.Add(user);
        }

        public void CrearPersona(Personas persona)
        {
            Persona.Add(persona);
        }

        public void Ranking_Canciones()
        {

        }

        public void Ranking_Videos()
        {

        }

        public void Crear_Playlist_Canciones()
        {

        }

        public void Crear_Playlist_Videos()
        {

        }

        public void Modificar_Playlist()
        {

        }

        public void Cola_Reproduccion_Canciones()
        {

        }

        public void Cola_Reproduccion_Videos()
        {

        }

        public void Portada_Cancion()
        {

        }

        public void Portada_Video()
        {

        }

        public void Mostrar_Portada_Cancion()
        {

        }

        public void Mostrar_Portada_Video()
        {

        }

        public void Filtro_Busqueda()
        {

        }

        public void Bonus_Game()
        {

        }
    }
}
