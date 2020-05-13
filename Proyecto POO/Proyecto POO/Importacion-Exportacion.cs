using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.InteropServices;
using WMPLib;


namespace Proyecto_POO
{
    [Serializable()]
    public class Importacion_Exportacion
    {
       
        public Importacion_Exportacion()
        {

        }//pendiente

        public void agregar_cancion(Almacenamiento almacenamiento, Usuario usu)
        {
            if ((usu.Get_Lista_Canciones_Agregadas().Count() < 5 && usu.Get_Premium() == false) || usu.Get_Premium())
                {
                Console.WriteLine("Titulo");
                string TITULO = Console.ReadLine();
                Console.WriteLine("Letra");
                string LETRA = Console.ReadLine();
                Console.WriteLine("Ingrese los datos del artista de la cancion");
                List<Personas> cantantes = new List<Personas>();
                List<Personas> generos = new List<Personas>();
                List<Usuario> seguidores = new List<Usuario>();
                int resp2 = 0;
                while (resp2 == 0)
                {
                    Console.WriteLine("Escriba el nombre del artista: ");
                    string NAME_ARTISTA = Console.ReadLine();
                    Console.WriteLine("Escriba el apellido del artista: ");
                    string APELLIDO_ARTISTA = Console.ReadLine();
                    Console.WriteLine("Escriba el sexo del artista (Hombre/Mujer): ");
                    string SEXO_ARTISTA = Console.ReadLine();
                    int EDAD_ARTISTA = 0;
                    while (EDAD_ARTISTA == 0)
                    {
                        Console.WriteLine("Escriba la edad del artista: ");
                        int.TryParse(Console.ReadLine(), out EDAD_ARTISTA);
                    }
                    Personas persona = new Personas(NAME_ARTISTA, APELLIDO_ARTISTA, SEXO_ARTISTA, "cantante", EDAD_ARTISTA, seguidores);
                    almacenamiento.CrearPersona(persona);
                    cantantes.Add(persona);
                    Console.WriteLine("Quieres agregar otro artista?(1 = YES/2 = NO)");
                    while (resp2 == 0 || resp2 > 2)
                    {
                        int.TryParse(Console.ReadLine(), out resp2);
                    }
                    if (resp2 == 1)
                        resp2 = 0;
                }



                Console.WriteLine("Fecha De Publicacion de la cancion (Formato Dia/Mes/Año)");
                string PUBLICACION = Console.ReadLine();

                List<string> lista_genero = new List<string>();
                int resp = 0;
                while (resp == 0)
                {
                    Console.WriteLine("agregue el genero de la cancion");
                    lista_genero.Add(Console.ReadLine());
                    Console.WriteLine("Quieres agregar otro mas?(1 = YES/2 = NO)");
                    while (resp == 0 || resp > 2)
                    {
                        int.TryParse(Console.ReadLine(), out resp);
                    }
                    if (resp == 1)
                        resp = 0;

                }
                Console.WriteLine("Estudio");
                string ESTUDIO = Console.ReadLine();
                Console.WriteLine("Ingrese directorio del archivo (Recuerde que los formatos validos son .mp3/.wav/.wmv/.flac)");
                Console.WriteLine("Formato ejemplo del Input -> C:\\Users\\Persona\\Musica\\MiMusica.mp3");
                string PATH = Console.ReadLine();
                while (!File.Exists(PATH))
                {
                    Console.WriteLine("La direccion ingresada no existe");
                    PATH = Console.ReadLine();
                }

                string tipo = System.IO.Path.GetExtension(PATH);
                List<string> tipos = new List<string> { ".mp3", ".wav", ".wmv",".flac" };
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
                        PATH = Console.ReadLine();
                        tipo = System.IO.Path.GetExtension(PATH);
                    }
                }
                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(PATH);

                int DURACION = Convert.ToInt32(TimeSpan.FromSeconds(clip.duration).TotalSeconds);


                Console.WriteLine("Descripcion");
                string DESCRIPCION = Console.ReadLine();


                Console.WriteLine("Album al cual pertenece la cancion");
                string album = Console.ReadLine();

                string workingDirectory = Environment.CurrentDirectory;
                string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\CancionesSubidas";
                string archivo = @Path.GetFileName(PATH);
                string carpeta = Path.GetDirectoryName(PATH);

                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                }
                string sourceFile = System.IO.Path.Combine(carpeta, archivo);
                string destFile = System.IO.Path.Combine(subdir, archivo);
                System.IO.File.Copy(sourceFile, destFile, true);

                
                FileInfo info = new FileInfo(@PATH);
                var FECHA = info.LastWriteTime;
                DateTime localDate = DateTime.Now;
                string INCLUSION = localDate.ToString();

                List<int> ranking = new List<int>();
                List<Usuario> Seguidores = new List<Usuario>();

                try
                {
                    long SIZE = info.Length;
                    List<string> comentarios = new List<string>();
                    int numero_reproduccion = 0;
                    Canciones cancion = new Canciones(LETRA, cantantes, DURACION, TITULO, INCLUSION, ranking, SIZE, lista_genero, ESTUDIO, PATH, PUBLICACION, DESCRIPCION, numero_reproduccion, comentarios, album,"",Seguidores);
                    cancion.Cambiar_ubicacion(subdir + "\\" + archivo);

                    almacenamiento.add_cancion(cancion);
                    usu.Add_Song_To_My_List(cancion);
                    Console.WriteLine("Cancion agregada correctamente");
                    Thread.Sleep(1000);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El archivo no se pudo leer, verifique su direccion o el nombre del archivo e intentalo de nuevo");
                    Thread.Sleep(1000);
                }

            }
            else
            {
                Console.WriteLine("Se paso del limite de canciones que puede agregar");
                if (usu.Get_Contador() > 0)
                {
                    Console.WriteLine("Sin embargo puede tener la oportunidad de ser premium sin pagar si gana este minijuego");
                    Console.WriteLine("Quiere intentarlo? (si/no)");
                    if (Console.ReadLine() == "si")
                    {
                        almacenamiento.Bonus_Game(usu);
                    }
                }
            }
        }

        public void agregar_video(Almacenamiento almacenamiento, Usuario usu)
        {
            if ((usu.Get_Lista_Videos_Agregados().Count() < 5 && usu.Get_Premium() == false) || usu.Get_Premium())
            {
                Console.WriteLine("Titulo");
                string TITULO = Console.ReadLine();
                Console.WriteLine("Directorio del archivo (Recuerde que los formatos validos son .mp4/.mkv/.flv/.mov/.wmv)");
                Console.WriteLine("Formato ejemplo del Input -> C:\\Users\\Persona\\Video\\MiVideo.mp4");
                string PATH = Console.ReadLine();



                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(PATH);
                int DURACION = Convert.ToInt32(TimeSpan.FromSeconds(clip.duration).TotalSeconds);


                while (!File.Exists(PATH))
                {
                    Console.WriteLine("La direccion ingresada no existe");
                    PATH = Console.ReadLine();
                }

                string tipo =  System.IO.Path.GetExtension(PATH);
                List<string> tipos = new List<string>{ ".mp4",".mkv", ".flv", ".mov", ".wmv" };
                int t = 0;
                while(t == 0)
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
                        PATH = Console.ReadLine();
                        tipo = System.IO.Path.GetExtension(PATH);
                    }
                }

                DateTime localDate = DateTime.Now;

                FileInfo info = new FileInfo(@PATH);
                var FECHA = info.LastWriteTime;
                string INCLUSION = localDate.ToString();

                long SIZE = 0;
                Console.WriteLine("Generos");
                List<string> generos = new List<string>();
                string yes = "yes";
                while (yes == "yes")
                {
                    string GENERO = Console.ReadLine();
                    generos.Add(GENERO);
                    Console.WriteLine("Quieres ingresar otro genero?(yes/no)");
                    yes = Console.ReadLine();
                }
                Console.WriteLine("Estudio");
                string ESTUDIO = Console.ReadLine();
                Console.WriteLine("Fecha Publicacion");
                string PUBLICACION = Console.ReadLine();
                Console.WriteLine("Descripcion");
                string DESCRIPCION = Console.ReadLine();
                Console.WriteLine("Calidad (Tipo 720p, 1080p, etc), ponga solo el modulo");
                int CALIDAD = 0;
                int.TryParse(Console.ReadLine(),out CALIDAD);

                //Ver como sacar la calidad

                List<Personas> personasvid = new List<Personas>();

                Console.WriteLine("Ingrese los Actores del video");
                int resp = 0;
                while (resp == 0)
                {

                    Console.WriteLine("ingrese el Nombre del actor");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese el apellido del actor");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese el sexo del actor (Hombre/Mujer)");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("ingrese la edad del actor");
                    int edad = 0;
                    List<Usuario> Seguidores3 = new List<Usuario>();
                    while (edad == 0)
                    {
                        string f = Console.ReadLine();
                        int.TryParse(f, out edad);
                    }
                    Personas actor = new Personas(nombre, apellido, sexo, "actor", edad, Seguidores3);
                    Console.WriteLine("Quieres agregar otro actor?(1 = YES/2 = NO)");
                    while (resp == 0 || resp > 2)
                    {
                        int.TryParse(Console.ReadLine(), out resp);
                    }
                    if (resp == 1)
                        resp = 0;
                    personasvid.Add(actor);
                    almacenamiento.CrearPersona(actor);
                }
                Console.WriteLine("Directores");
                int resp2 = 0;
                while (resp2 == 0)
                {
                    Console.WriteLine("ingrese el Nombre del Director");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese el apellido del Director");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese el sexo del Director (Hombre/Mujer)");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("ingrese la edad del Director");
                    int edad = 0;
                    List<Usuario> Seguidores2 = new List<Usuario>();
                    while (edad == 0)
                    {
                        string f = Console.ReadLine();
                        int.TryParse(f, out edad);
                    }
                    Personas director = new Personas(nombre, apellido, sexo, "Director", edad, Seguidores2);
                    Console.WriteLine("Quieres agregar otro director?(1 = YES/2 = NO)");
                    while (resp2 == 0 || resp2 > 2)
                    {
                        int.TryParse(Console.ReadLine(), out resp2);
                    }
                    if (resp2 == 1)
                        resp2 = 0;
                    personasvid.Add(director);
                    almacenamiento.CrearPersona(director);
                }
                List<int> ranking = new List<int>();
                List<string> comentarios = new List<string>();

                List<Usuario> Seguidores = new List<Usuario>();

                Video video = new Video(DURACION, TITULO, INCLUSION, ranking, SIZE, generos, ESTUDIO, PATH, PUBLICACION, DESCRIPCION, 0, comentarios, CALIDAD, personasvid,"",Seguidores);
                almacenamiento.add_videos(video);
                usu.Add_Video_To_My_List(video);
                Console.WriteLine("se agrego el video correctamente");
                Thread.Sleep(1000);
                string workingDirectory = Environment.CurrentDirectory;
                string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\VideosSubidos";
                string archivo = @Path.GetFileName(PATH);
                string carpeta = Path.GetDirectoryName(PATH);



                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                }
                string sourceFile = System.IO.Path.Combine(carpeta, archivo);
                string destFile = System.IO.Path.Combine(subdir, archivo);
                System.IO.File.Copy(sourceFile, destFile, true);
                video.Cambiar_ubicacion(subdir + "\\" + archivo);
            }
            else
            {
                Console.WriteLine("Se paso del limite de videos que puede agregar");
                if (usu.Get_Contador() > 0)
                {
                    Console.WriteLine("Sin embargo puede tener la oportunidad de ser premium sin pagar si gana este minijuego");
                    Console.WriteLine("Quiere intentarlo? (si/no)");
                    if (Console.ReadLine() == "si")
                    {
                        almacenamiento.Bonus_Game(usu);
                    }
                }
            }

        }


        public void Descarga(Canciones cancion)
        {
            string workingDirectory = Environment.CurrentDirectory;
            //string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\DescargasSpotflix3";
            string C = Path.GetDirectoryName(cancion.Get_Carpeta_Archivo());
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\DescargasSpotflix3"; // bla bla
            string subdir2 = @C;
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            string sourceFile = System.IO.Path.Combine(subdir2, @Path.GetFileName(cancion.Get_Carpeta_Archivo()));
            string destFile = System.IO.Path.Combine(subdir, @Path.GetFileName(cancion.Get_Carpeta_Archivo()));
            System.IO.File.Copy(sourceFile, destFile, true);
        }
        public void quitar_cancion(Canciones cancion,Almacenamiento alma)
        {
            alma.Quitar_cancion(cancion);          
        }

        public void quitar_videos(Video mp4, Almacenamiento alma)
        {
            alma.Quitar_videon(mp4);
        }

    }
}
