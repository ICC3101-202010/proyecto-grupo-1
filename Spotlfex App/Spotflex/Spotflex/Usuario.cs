using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex
{
    [Serializable()]
    public class Usuario
    {
        private string nombre;
        private int edad;
        private bool user_type;
        private bool premium;
        private string nickname;
        private string contraseña;
        private bool administrador;
        private string fotoperfil;
        private int contador = 3;
        private List<string> generosQueSigue = new List<string>();
        private List<Personas> cantantes_que_sigue = new List<Personas>();
        private List<Canciones> favoritos_canciones = new List<Canciones>();
        private List<Video> favoritos_videos = new List<Video>();
        private List<Multimedia> recomendaciones = new List<Multimedia>();
        private List<Usuario> usuarios_seguidores = new List<Usuario>();
        private List<Canciones> canciones_agregadas = new List<Canciones>();
        private List<Video> videos_agregados = new List<Video>();
        private List<Playlist> playlist_agregadas = new List<Playlist>();
        private List<Canciones> cola_cancion = new List<Canciones>();
        private List<Video> cola_video = new List<Video>();

        public Usuario(string nombre, int edad, bool user_type, bool premium, string nickname,
            string contraseña, bool administrador, string fotoperfil, int contador,
            List<string> generosQueSigue, List<Personas> cantantes_que_sigue, List<Canciones> favoritos_canciones,
            List<Video> favoritos_videos, List<Multimedia> recomendaciones, List<Usuario> usuarios_seguidores,
            List<Canciones> canciones_agregadas, List<Video> videos_agregados, List<Playlist> playlist_agregadas,
            List<Canciones> cola_cancion, List<Video> cola_video)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.User_type = user_type;
            this.Premium = premium;
            this.Nickname = nickname;
            this.Contraseña = contraseña;
            this.Administrador = administrador;
            this.Fotoperfil = fotoperfil;
            this.Contador = contador;
            this.GenerosQueSigue = generosQueSigue;
            this.Cantantes_que_sigue = cantantes_que_sigue;
            this.Favoritos_canciones = favoritos_canciones;
            this.Favoritos_videos = favoritos_videos;
            this.Recomendaciones = recomendaciones;
            this.Usuarios_seguidores = usuarios_seguidores;
            this.Canciones_agregadas = canciones_agregadas;
            this.Videos_agregados = videos_agregados;
            this.Playlist_agregadas = playlist_agregadas;
            this.Cola_cancion = cola_cancion;
            this.Cola_video = cola_video;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool User_type { get => user_type; set => user_type = value; }
        public bool Premium { get => premium; set => premium = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string Fotoperfil { get => fotoperfil; set => fotoperfil = value; }
        public int Contador { get => contador; set => contador = value; }
        public List<string> GenerosQueSigue { get => generosQueSigue; set => generosQueSigue = value; }
        public List<Personas> Cantantes_que_sigue { get => cantantes_que_sigue; set => cantantes_que_sigue = value; }
        public List<Canciones> Favoritos_canciones { get => favoritos_canciones; set => favoritos_canciones = value; }
        public List<Video> Favoritos_videos { get => favoritos_videos; set => favoritos_videos = value; }
        public List<Multimedia> Recomendaciones { get => recomendaciones; set => recomendaciones = value; }
        public List<Usuario> Usuarios_seguidores { get => usuarios_seguidores; set => usuarios_seguidores = value; }
        public List<Canciones> Canciones_agregadas { get => canciones_agregadas; set => canciones_agregadas = value; }
        public List<Video> Videos_agregados { get => videos_agregados; set => videos_agregados = value; }
        public List<Playlist> Playlist_agregadas { get => playlist_agregadas; set => playlist_agregadas = value; }
        public List<Canciones> Cola_cancion { get => cola_cancion; set => cola_cancion = value; }
        public List<Video> Cola_video { get => cola_video; set => cola_video = value; }

        public void AgregarFotoPerfil(string path)
        {
            Fotoperfil = path;
        }
        public List<Canciones> get_Lista_Canciones_Subidas()
        {
            return Canciones_agregadas;
        }
        public List<Video> get_Lista_Videos_Subidos()
        {
            return Videos_agregados;
        }



        public void Add_Song_To_My_List(Canciones cancion)
        {
            Canciones_agregadas.Add(cancion);
        }

        public void Add_Video_To_My_List(Video video)
        {
            Videos_agregados.Add(video);
        }

        public void Add_Playlist_To_My_List(Playlist playlist)
        {
            Playlist_agregadas.Add(playlist);
        }
        public void Remove_Playlist(Playlist playlist)
        {

            int i = 0;
            int check = 0;
            foreach (Playlist cosa in playlist_agregadas)
            {

                if (cosa.Name == playlist.Name)
                {
                    check = i;
                }
                i++;

            }
            Playlist_agregadas.RemoveAt(check);
        }

        public void Cambiar_dato_string(int caso, string palabra)
        {
            if (caso == 1)
                Nombre = palabra;
            if (caso == 2)
                Nickname = palabra;
            if (caso == 3)
                Contraseña = palabra;
        }

        public void Cambiar_dato_booleano(int caso)
        {
            if (caso == 1)
            {
                User_type = !User_type;
            }
            if (caso == 2)
            {
                Premium = !Premium;
            }
            if (caso == 3)
            {
                Administrador = !Administrador;
            }
        }

        public void Cambiar_dato_edad(int edad)
        {
            Edad = edad;
        }

        public void Lose_Bonus_Game()
        {
            Contador -= 1;
        }


  }
}
