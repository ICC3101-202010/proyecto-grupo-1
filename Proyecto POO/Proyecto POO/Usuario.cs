using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_POO
{
    [Serializable()]
    public class Usuario
    {

        private string Nombre { get; set; }
        private int Edad { get; set; }
        private bool TipoDeUsuario { get; set; }
        private bool Premium { get; set; }
        private string Nickname { get; set; }
        private string Contraseña { get; set; }
        private bool Administrador { get; set; }
        private string FotoPerfil { get; set; }
        private List<string> GenerosQueSigue = new List<string>();
        private List<Personas> CantantesQueSigue = new List<Personas>();
        private List<Canciones> FavoritosCanciones = new List<Canciones>();
        private List<Video> FavoritosVideo = new List<Video>();
        private List<Multimedia> Recomendaciones = new List<Multimedia>();
        private List<Usuario> UsuariosSeguidores = new List<Usuario>();
        private int Contador = 3;
        private List<Canciones> CancionesAgregadas = new List<Canciones>();
        private List<Video> VideosAgregados = new List<Video>();
        private List<Playlist> PlaylistAgregadas = new List<Playlist>();


        public Usuario(string name,int years,bool usertipe,bool premi, string sobrenombre,string pasword, bool admin,string fotoperfil, List<Canciones> CancionesAgregadas,
          List<Video> VideosAgregados, List<Playlist> PlaylistAgregadas, List<Usuario> UsuariosSeguidores, List<Canciones> FavoritosCanciones, List<Video> FavoritosVideo)
        {
            Nombre = name;
            Edad = years;
            TipoDeUsuario = usertipe;
            Premium = premi;
            Nickname = sobrenombre;
            Contraseña = pasword;
            Administrador = admin;
            FotoPerfil = fotoperfil;
            this.CancionesAgregadas = CancionesAgregadas;
            this.VideosAgregados = VideosAgregados;
            this.PlaylistAgregadas = PlaylistAgregadas;
            this.UsuariosSeguidores = UsuariosSeguidores;
            this.FavoritosVideo = FavoritosVideo;
            this.FavoritosCanciones = FavoritosCanciones;
        }
        
        public Usuario()
        {
        }
        public void AgregarFotoPerfil()
        {
            Console.WriteLine("Ingrese el path del archivo que quieras que sea tu foto de perfil ");
            string path = Console.ReadLine();
            while (!File.Exists(path))
            {
                Console.WriteLine("La direccion ingresada no existe");
                path = Console.ReadLine();
            }
            string tipo = System.IO.Path.GetExtension(path);
            List<string> tipos = new List<string> { ".jpg", ".png", ".bmap", ".gif", ".bmp",".raw" };
            int t = 0;
            while (t == 0)
            {
                for (int i = 0; i < tipos.Count(); i++)
                {
                    if (tipos[i] == tipo)
                    {
                        t = 1;
                    }
                }
                if (t == 0)
                {
                    Console.WriteLine("Tipo de archivo incorrecto");
                    Console.WriteLine("Ingrese denuevo");
                    path = Console.ReadLine();
                    tipo = System.IO.Path.GetExtension(path);
                }
            }
            FotoPerfil = path;

            string workingDirectory = Environment.CurrentDirectory;
            string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\FotosDePerfil";
            string archivo = @Path.GetFileName(path);
            string carpeta = Path.GetDirectoryName(path);
            string C = Path.GetDirectoryName(path);



            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            string sourceFile = System.IO.Path.Combine(carpeta, archivo);
            string destFile = System.IO.Path.Combine(subdir, archivo);
            System.IO.File.Copy(sourceFile, destFile, true);

        }
        public void CargarFotoPerfil()
        {
            string archivo = Path.GetFileName(FotoPerfil);
            string carpeta = @System.IO.Directory.GetCurrentDirectory() + "\\FotosDePerfil" + "\\" + archivo;
            System.Diagnostics.Process.Start(FotoPerfil);
        }
        public string Get_Fotoperfil()
        {
            return FotoPerfil;
        }

        public void Seguir(Usuario usu)
        {
            int verificador = 1;
            foreach(Usuario data in UsuariosSeguidores)
            {
                if (data.Get_Nickname() == Nickname || usu.Get_Nickname() == data.Get_Nickname())
                {
                    verificador = 0;
                }
            }
            if( verificador == 1)
            {
                UsuariosSeguidores.Add(usu);
            }
            else
            {
                Console.WriteLine("No puedes seguir a este usuario");
            }
        }

        public void Informacion_Usuario()
        {
            Console.Clear();
            if (TipoDeUsuario == true)
            {
                Console.WriteLine("Esta informacion esta oculta porque es privada");
            }
            else
            {
                Console.WriteLine("Nombre: " + Nombre + "\nEdad: " + Edad + "\nEstado de Premium: " + Premium + "\nNickname: " + Nickname + "\nEs administrador: " + Administrador + "\nSeguidores: " + UsuariosSeguidores.Count() +"\nFoto de perfil");
                try
                {
                    CargarFotoPerfil();
                }

                catch
                {
                    Console.WriteLine("Este Usuario no tiene Foto de perfil");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }

        public void Add_Song_To_My_List(Canciones cancion)
        {
            CancionesAgregadas.Add(cancion);
        }

        public void Add_Video_To_My_List(Video video)
        {
            VideosAgregados.Add(video);
        }

        public void Add_Playlist_To_My_List(Playlist playlist)
        {
            PlaylistAgregadas.Add(playlist);
        }


        public string Get_Nombre()
        {
            return Nombre;
        }

        public int Get_Edad()
        {
            return Edad;
        }

        public bool Get_TipoDeUsuario()
        {
            return TipoDeUsuario;
        }

        public bool Get_Premium()
        {
            return Premium;
        }

        public string Get_Nickname()
        {
            return Nickname;
        }

        public string Get_Password()
        {
            return Contraseña;
        }
        public List<string> Get_GeneroSigue()
        {
            return GenerosQueSigue;
        }


        public List<Multimedia> Get_Recomendacion()
        {
            return Recomendaciones;
        }

        public List<Usuario> Get_Seguidores()
        {
            return UsuariosSeguidores;
        }

        public bool Get_Admin()
        {
            return Administrador;
        }

        public int Get_Contador()
        {
            return Contador;
        }

        public void Cambiar_dato_string(int caso, string palabra)
        {
            if(caso == 1)
             Nombre = palabra;
            if (caso == 2)
                Nickname =palabra;
            if (caso == 3)
                Contraseña = palabra;
        }

        public void Cambiar_dato_booleano(int caso)
        {
            if (caso == 1)
            {
                TipoDeUsuario = !TipoDeUsuario;
                if (TipoDeUsuario == true)
                {
                    Console.WriteLine("Su perfil ahora es privado");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Su perfil ahora es publico");
                    Thread.Sleep(1000);
                }

            }
            if (caso == 2)
            {
                Premium = !Premium;
                if (Premium == true)
                {
                    Console.WriteLine("Su perfil ahora es Premium");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Su perfil ahora no es premium");
                    Thread.Sleep(1000);
                }
            }


            if (caso == 3)
            {
                Administrador = !Administrador;
                if (Administrador == true)
                {
                    Console.WriteLine("Su perfil ahora tiene permisos de administrador");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Su perfil ahora no tiene permisos de administrador");
                    Thread.Sleep(1000);
                }
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

        public void Add_FavoritosCan(Canciones multi)
        {
            int verificador = 1;
            foreach(Canciones data in FavoritosCanciones)
            {
                if (data.Get_Titulo() == multi.Get_Titulo())
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                FavoritosCanciones.Add(multi);
                Console.WriteLine("Este archivo multimedia esta incluida en la lista de favoritos");
            }
            else
            {
                FavoritosCanciones.Remove(multi);
                Console.WriteLine("Este archivo multimedia sera eliminada de favoritos");
            }
            Thread.Sleep(1500);
        }

        public void Add_FavoritosVid(Video multi)
        {
            int verificador = 1;
            foreach (Video data in FavoritosVideo)
            {
                if (data.Get_Titulo() == multi.Get_Titulo())
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                FavoritosVideo.Add(multi);
                Console.WriteLine("Este archivo multimedia esta incluida en la lista de favoritos");
            }
            else
            {
                FavoritosVideo.Remove(multi);
                Console.WriteLine("Este archivo multimedia sera eliminada de favoritos");
            }
            Thread.Sleep(1500);
        }
        public void Consultar_Favoritos()
        {
            int i = 1;
            Console.WriteLine("Canciones favoritas:");
            foreach(Canciones data in FavoritosCanciones)
            {
                Console.WriteLine(i + " ) " + data.Get_Titulo());
                i++;
            }
            Console.WriteLine("Videos favoritos");
            foreach (Video data in FavoritosVideo)
            {
                Console.WriteLine(i + " ) " + data.Get_Titulo());
                i++;
            }
        }

        public List<Video> Get_Lista_Videos_Agregados()
        {
            return VideosAgregados;
        }

        public List<Canciones> Get_Lista_Canciones_Agregadas()
        {
            return CancionesAgregadas;
        }

        public List<Playlist> Get_Lista_Playlist_Agregados()
        {
            return PlaylistAgregadas;
        }

        public List<Canciones> Get_Lista_Canciones_Fav()
        {
            return FavoritosCanciones;
        }
        public List<Video> Get_Lista_Video_Fav()
        {
            return FavoritosVideo;
        }


    }
}
