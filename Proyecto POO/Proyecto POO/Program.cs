using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Proyecto_POO
{
    [Serializable()]
    class Program
    {
        static void Main(string[] args)
        {
            Almacenamiento almacenamiento = new Almacenamiento();
            Importacion_Exportacion impor_expo = new Importacion_Exportacion();

            int numcase = 0;
            string workingDirectory = Environment.CurrentDirectory;

            Console.ForegroundColor = ConsoleColor.Green;
            IFormatter formatter2 = new BinaryFormatter();
            IFormatter formatter = new BinaryFormatter();

            string path_song = @System.IO.Directory.GetCurrentDirectory() + "\\canciones.bin";
            string path_video = @System.IO.Directory.GetCurrentDirectory() + "\\videos.bin";
            string path_usuario = @System.IO.Directory.GetCurrentDirectory() + "\\usuarios.bin";
            string path_playlist = @System.IO.Directory.GetCurrentDirectory() + "\\playlist.bin";
            
            if (File.Exists(path_song) && File.Exists(path_video) && File.Exists(path_usuario) && File.Exists(path_playlist))
            {

                Stream stream2 = new FileStream("canciones.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream3 = new FileStream("videos.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream4 = new FileStream("usuarios.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream7 = new FileStream("playlist.bin", FileMode.Open, FileAccess.Read, FileShare.Read);//playlist
                //Stream stream9 = new FileStream("persona.bin", FileMode.Open, FileAccess.Read, FileShare.Read);//playlist
                try
                {
                    int p = (int)formatter2.Deserialize(stream2);

                    for (int i = 0; i < p; i++)
                    {

                        Canciones obj = (Canciones)formatter2.Deserialize(stream2);

                        almacenamiento.add_cancion(obj);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    stream2.Close();
                }
                try
                {

                    int p = (int)formatter2.Deserialize(stream3);
                    for (int i = 0; i < p; i++)
                    {
                        Video obj = (Video)formatter2.Deserialize(stream3);
                        almacenamiento.add_videos(obj);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    stream3.Close();
                }
                try
                {

                    int p = (int)formatter2.Deserialize(stream4);
                    for (int i = 0; i < p; i++)
                    {
                        Usuario obj = (Usuario)formatter2.Deserialize(stream4);
                        almacenamiento.AgregarUsuario(obj);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    stream4.Close();
                }
                try
                {
                    int p = (int)formatter2.Deserialize(stream7);

                    for (int i = 0; i < p; i++)
                    {

                        Playlist obj = (Playlist)formatter2.Deserialize(stream7);

                        almacenamiento.add_playlist(obj);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    stream7.Close();
                }
            }
            else
            {
                List<Canciones> a = new List<Canciones>();
                List<Video> b = new List<Video>();
                List<Playlist> c = new List<Playlist>();
                List<Usuario> d = new List<Usuario>();
                List<Canciones> e = new List<Canciones>();
                List<Video> f = new List<Video>();
                Usuario yo = new Usuario("benja", 21, false, false, "dark", "lol", true, "",a,b,c,d,e,f);
                almacenamiento.AgregarUsuario(yo);
            }
            string nv = "";
            while (numcase != 3)
            {
                numcase = 0;
                Console.WriteLine("SPOTFLEX!!!!");
                Console.WriteLine("");
                Console.WriteLine("(1) Ingresar como usuario");
                Console.WriteLine("(2) Crear usuario");
                Console.WriteLine("(3) Salir del programa");
                while (numcase == 0 || numcase >= 4)
                {
                    nv = Console.ReadLine();
                    int.TryParse(nv, out numcase);
                }
                switch (numcase)
                {
                    case 1: //ingresar como usuario
                        {

                            Console.Clear();
                            Console.WriteLine("Ingrese su nick de usuario");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña");
                            string contra = Console.ReadLine();
                            int y = almacenamiento.comprobarusuario(nom, contra);
                            if (y == 1)
                            {
                                Console.Clear();
                                int icase = 0;
                                while (icase != 13)
                                {

                                    icase = 0;
                                    Console.WriteLine("MENU DE SPOTFLEX");
                                    Console.WriteLine("(1) Modificar Opciones de Usuario");
                                    Console.WriteLine("(2) Reproducir");
                                    Console.WriteLine("(3) Descargar Cancion");
                                    Console.WriteLine("(4) Rankear una cancion o video");
                                    Console.WriteLine("(5) Ranking actual");
                                    Console.WriteLine("(6) Buscador Personalizado");
                                    Console.WriteLine("(7) Subir un video");
                                    Console.WriteLine("(8) Subir una cancion");
                                    Console.WriteLine("(9) Quitar Cancion");
                                    Console.WriteLine("(10) Quitar Video");
                                    Console.WriteLine("(11) Hacer Playlist");
                                    Console.WriteLine("(12) Modificar Playlist ");
                                    Console.WriteLine("(13) Cerrar Sesion");
                                    Console.WriteLine("(14) Cerrar Programa");


                                    while (icase == 0 || icase >= 16)
                                    {
                                        string f = Console.ReadLine();
                                        int.TryParse(f, out icase);
                                    }
                                    Console.Clear();
                                    switch (icase)
                                    {
                                        case 1://modificar Opciones de Usuario
                                            {

                                                for (int i = 0; i < almacenamiento.Get_Usuarios().Count(); i++)
                                                {

                                                    if (almacenamiento.Get_Usuarios()[i].Get_Nickname() == nom && almacenamiento.Get_Usuarios()[i].Get_Password() == contra)
                                                    {
                                                        int pass = 0;
                                                        while (pass != 12)
                                                        {
                                                            pass = 0;
                                                            Console.WriteLine("Que desea cambiar de su perfil?");
                                                            Console.WriteLine("(1) Cambiar su Nombre");
                                                            Console.WriteLine("(2) Cambiar su Edad");
                                                            Console.WriteLine("(3) Cambiar Accesibilidad del Perfil");
                                                            Console.WriteLine("(4) Cambiar Tipo de Cuenta (premium / no premium)");
                                                            Console.WriteLine("(5) Cambiar Nick");
                                                            Console.WriteLine("(6) Cambiar Contraseña");
                                                            Console.WriteLine("(7) Cambiar Administrador");
                                                            Console.WriteLine("(8) Ver informacion del perfil");
                                                            Console.WriteLine("(9) Ver foto perfil");
                                                            Console.WriteLine("(10) Consultar Favoritos");
                                                            Console.WriteLine("(11) Borrar Usuario");
                                                            Console.WriteLine("(12) Volver al menu anterior");

                                                            while (pass == 0 || pass > 12)
                                                            {
                                                                string f = Console.ReadLine();
                                                                int.TryParse(f, out pass);
                                                            }
                                                            Console.Clear();
                                                            switch (pass)
                                                            {
                                                                case 1://cambiar nombre
                                                                    {
                                                                        Console.WriteLine("ingrese su nuevo nombre");
                                                                        string nombre = Console.ReadLine();
                                                                        almacenamiento.Get_Usuarios()[i].Cambiar_dato_string(1, nombre);
                                                                        Console.WriteLine("Su nombre a sido actualizado");
                                                                        Thread.Sleep(1000);
                                                                        break;
                                                                    }
                                                                case 2://cambiar edad
                                                                    {
                                                                        Console.WriteLine("ingrese su nueva edad");
                                                                        int nuevaedad = 0;
                                                                        while (nuevaedad == 0)
                                                                        {
                                                                            string f = Console.ReadLine();
                                                                            int.TryParse(f, out nuevaedad);
                                                                        }
                                                                        almacenamiento.Get_Usuarios()[i].Cambiar_dato_edad(nuevaedad);
                                                                        Console.WriteLine("Su edad a sido actualizada");
                                                                        Thread.Sleep(1000);
                                                                        break;
                                                                    }
                                                                case 3://cambiar perfil publico o privado
                                                                    {
                                                                        almacenamiento.Get_Usuarios()[i].Cambiar_dato_booleano(1);
                                                                        break;
                                                                    }
                                                                case 4://cambiar premium
                                                                    {
                                                                        Console.WriteLine("ingrese la clave para volverse premium");
                                                                        string resp = Console.ReadLine();
                                                                        if (resp == "viper")
                                                                            almacenamiento.Get_Usuarios()[i].Cambiar_dato_booleano(2);
                                                                        else
                                                                            Console.WriteLine("clave incorrecta");
                                                                        break;
                                                                    }
                                                                case 5://cambiar nick
                                                                    {
                                                                        Console.WriteLine("ingrese su nuevo Nickname");
                                                                        string nickname = Console.ReadLine();
                                                                        for (int ñ = 0; ñ < almacenamiento.Get_Usuarios().Count; ñ++)
                                                                        {
                                                                            if (almacenamiento.Get_Usuarios()[i].Get_Nickname() == almacenamiento.Get_Usuarios()[ñ].Get_Nickname())
                                                                            {
                                                                                almacenamiento.Get_Usuarios()[ñ].Cambiar_dato_string(2, nickname);
                                                                            }

                                                                        }
                                                                        Console.WriteLine("Nickname actualizado");
                                                                        Thread.Sleep(1000);
                                                                        break;
                                                                    }
                                                                case 6://cambiar contraseña
                                                                    {
                                                                        Console.WriteLine("ingrese su nueva Contraseña");
                                                                        string nuevacontra = Console.ReadLine();

                                                                        for (int ñ = 0; ñ < almacenamiento.Get_Usuarios().Count; ñ++)
                                                                        {
                                                                            if (almacenamiento.Get_Usuarios()[i].Get_Password() == almacenamiento.Get_Usuarios()[ñ].Get_Password())
                                                                            {
                                                                                almacenamiento.Get_Usuarios()[ñ].Cambiar_dato_string(3, nuevacontra);
                                                                            }

                                                                        }
                                                                        Console.WriteLine("Contraseña actualizada");
                                                                        Thread.Sleep(1000);
                                                                        break;
                                                                    }
                                                                case 7://cambiar si es administrador
                                                                    {
                                                                        if (almacenamiento.Get_Usuarios()[i].Get_Admin() == false)
                                                                        {
                                                                            Console.WriteLine("Escriba la clave de administrador");
                                                                            if (Console.ReadLine() == "pollo")
                                                                            {
                                                                                Console.WriteLine("Eres un usuario autorizado para ser administrador");
                                                                                almacenamiento.Get_Usuarios()[i].Cambiar_dato_booleano(3);
                                                                                Thread.Sleep(1500);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            almacenamiento.Get_Usuarios()[i].Cambiar_dato_booleano(3);
                                                                        }
                                                                        break;
                                                                    }
                                                                case 8://Ver informacion perfil
                                                                    {
                                                                        almacenamiento.Get_Usuarios()[i].Informacion_Usuario();

                                                                        break;
                                                                    }
                                                                case 9:// ver foto perfil
                                                                    {
                                                                        if (almacenamiento.Get_Usuarios()[i].Get_Fotoperfil() == "")
                                                                        {
                                                                            Console.WriteLine("No tiene foto de perfil, desea agregar una? (si = 1 / no = 2)");
                                                                            int h = 0;
                                                                            while (h == 0 || h > 2)
                                                                            {
                                                                                int.TryParse(Console.ReadLine(), out h);
                                                                            }
                                                                            if (h == 1)
                                                                            {
                                                                                almacenamiento.Get_Usuarios()[i].AgregarFotoPerfil();
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Que quiere hacer?");
                                                                            Console.WriteLine("(1) Ver foto de perfil");
                                                                            Console.WriteLine("(2) Cambiar foto de perfil");
                                                                            int h = 0;
                                                                            while (h == 0 || h > 2)
                                                                            {
                                                                                int.TryParse(Console.ReadLine(), out h);
                                                                            }
                                                                            if (h == 1)
                                                                            {
                                                                                almacenamiento.Get_Usuarios()[i].CargarFotoPerfil();
                                                                            }
                                                                            if (h == 2)
                                                                            {
                                                                                almacenamiento.Get_Usuarios()[i].AgregarFotoPerfil();
                                                                            }
                                                                        }

                                                                        break;
                                                                    }
                                                                case 10: //Consultar favoritos
                                                                    {
                                                                        almacenamiento.Get_Usuarios()[i].Consultar_Favoritos();
                                                                        break;
                                                                    }
                                                                case 11://Borrar Usuario
                                                                    {
                                                                        if (almacenamiento.Get_Usuarios()[i].Get_Admin())
                                                                        {
                                                                            int k = 1;
                                                                            foreach (Usuario data in almacenamiento.Get_Usuarios())
                                                                            {
                                                                                Console.WriteLine(k + ") " + data.Get_Nickname());
                                                                                k++;
                                                                            }
                                                                            Console.WriteLine("Elija al usuario que desea eliminar con su numero");
                                                                            int ban = 0;
                                                                            while (ban == 0 || ban > k)
                                                                            {
                                                                                int.TryParse(Console.ReadLine(), out ban);
                                                                            }
                                                                            if (ban == 1)
                                                                            {
                                                                                almacenamiento.Get_Usuarios().RemoveAt(ban - 1);
                                                                                pass = 12;
                                                                                icase = 13;
                                                                            }
                                                                            else
                                                                            {
                                                                                almacenamiento.Get_Usuarios().RemoveAt(ban - 1);
                                                                            }


                                                                        }
                                                                        else
                                                                        {
                                                                            for (int u = 0; u < almacenamiento.Get_Usuarios().Count; u++)
                                                                            {
                                                                                if (almacenamiento.Get_Usuarios()[i].Get_Nickname() == almacenamiento.Get_Usuarios()[u].Get_Nickname())
                                                                                {
                                                                                    almacenamiento.Get_Usuarios().RemoveAt(u);
                                                                                }
                                                                            }
                                                                            pass = 12;
                                                                            icase = 13;
                                                                        }

                                                                        break;
                                                                    }
                                                                case 12://Salir del menu
                                                                    {
                                                                        pass = 12;
                                                                        break;
                                                                    }
                                                                default:
                                                                    break;
                                                            }
                                                            if (pass == 12)
                                                                icase = 13;

                                                            Console.Clear();
                                                        }

                                                    }
                                                }

                                                break;
                                            }                                   
                                        case 2:// reproducir cancion
                                            {

                                                Console.WriteLine("Quiere reproducir una playlist o hacer una cola de reproduccion de de canciones ");
                                                Console.WriteLine("(1) Playlist");
                                                Console.WriteLine("(2) Hacer cola de reproduccion");
                                                Console.WriteLine("(3) Reproducir playlist de canciones favoritas");
                                                Console.WriteLine("(4) Reproducir playlist de videos favoritas");
                                                int operacion = 0;
                                                while (operacion == 0 || operacion > 4)
                                                {
                                                    int.TryParse(Console.ReadLine(), out operacion);
                                                }
                                                if (operacion == 1)
                                                {
                                                    if (almacenamiento.Get_Playlist().Count() != 0)
                                                    {
                                                        for (int i = 1; i <= almacenamiento.Get_Playlist().Count(); i++)
                                                        {
                                                            Console.WriteLine(i + ") " + almacenamiento.Get_Playlist()[i - 1].Get_Name());
                                                        }
                                                        
                                                        int index = 0;
                                                        while (index == 0 || index > almacenamiento.Get_Playlist().Count())
                                                        {
                                                            string q = Console.ReadLine();
                                                            int.TryParse(q, out index);
                                                        }
                                                        if (almacenamiento.Get_Playlist()[index - 1].Get_Playlist_Video().Count() == 0)
                                                        {
                                                            for (int i = 0; i < almacenamiento.Get_Playlist()[index - 1].Get_Playlist_Canciones().Count(); i++)
                                                            {
                                                                almacenamiento.ReproducirMultimedia(almacenamiento.Get_Playlist()[index - 1].Get_Playlist_Canciones()[i]);
                                                            }
                                                        }
                                                        if (almacenamiento.Get_Playlist()[index - 1].Get_Playlist_Canciones().Count() == 0)
                                                        {
                                                            for (int i = 0; i < almacenamiento.Get_Playlist()[index - 1].Get_Playlist_Video().Count(); i++)
                                                            {
                                                                almacenamiento.ReproducirMultimedia(almacenamiento.Get_Playlist()[index - 1].Get_Playlist_Video()[i]);
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No existen playlist para reproducir");
                                                    }

                                                    Thread.Sleep(1000);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Clear();
                                                }


                                                if (operacion == 2)
                                                {
                                                    Console.WriteLine("Dsea hacer una cola de Canciones o Videos??? ");
                                                    Console.WriteLine("(1) Canciones");
                                                    Console.WriteLine("(2) Videos");
                                                    int operacion2 = 0;
                                                    while (operacion2 == 0 || operacion2 > 2)
                                                    {
                                                        int.TryParse(Console.ReadLine(), out operacion2);
                                                    }
                                                    if (operacion2 == 1)
                                                    {


                                                        if (almacenamiento.Get_ListaCanciones().Count() > 0)
                                                        {
                                                            almacenamiento.ColaReproduccionCanciones();
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("No se puede realizar el proceso: No hay canciones en el sistema");
                                                        }
                                                        Thread.Sleep(1000);
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.Clear();
                                                    }
                                                    if (operacion2 == 2)
                                                    {
                                                        if (almacenamiento.Get_ListaVideos().Count() > 0)
                                                        {
                                                            almacenamiento.ColaReproduccionVideos();

                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("No se puede realizar el proceso: No hay videos en el sistema");
                                                        }
                                                        Thread.Sleep(1000);
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.Clear();

                                                    }
                                                }
                                                    if (operacion == 3)
                                                    {
                                                        for (int i = 0; i < almacenamiento.Get_Usuarios().Count(); i++)
                                                        {


                                                            if (almacenamiento.Get_Usuarios()[i].Get_Nickname() == nom && almacenamiento.Get_Usuarios()[i].Get_Password() == contra)
                                                            {
                                                                if (almacenamiento.Get_Usuarios()[i].Get_Lista_Canciones_Fav().Count != 0)
                                                                {
                                                                    for (int k = 0; k < almacenamiento.Get_Usuarios()[i].Get_Lista_Canciones_Fav().Count(); k++)
                                                                    {
                                                                        almacenamiento.ReproducirMultimedia(almacenamiento.Get_Usuarios()[i].Get_Lista_Canciones_Fav()[k]);
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("No hay canciones en favorito para reproducir");
                                                                    Thread.Sleep(2000);
                                                                }
                                                            }
                                                        }
                                                        Console.Clear();
                                                    }
                                                    if (operacion == 4)
                                                    {
                                                        for (int i = 0; i < almacenamiento.Get_Usuarios().Count(); i++)
                                                        {


                                                            if (almacenamiento.Get_Usuarios()[i].Get_Nombre() == nom && almacenamiento.Get_Usuarios()[i].Get_Password() == contra)
                                                            {
                                                                if (almacenamiento.Get_Usuarios()[i].Get_Lista_Video_Fav().Count != 0)
                                                                {
                                                                    for (int k = 0; k < almacenamiento.Get_Usuarios()[i].Get_Lista_Video_Fav().Count(); k++)
                                                                    {
                                                                        almacenamiento.ReproducirMultimedia(almacenamiento.Get_Usuarios()[i].Get_Lista_Video_Fav()[k]);
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("No hay videos en favorito para reproducir");
                                                                    Thread.Sleep(2000);
                                                                }
                                                            }
                                                        }
                                                        Console.Clear();

                                                    }                                                   
                                                
                                                break;
                                            }

                                        case 3: //descargar cancion
                                            {
                                                if (almacenamiento.Get_ListaCanciones().Count() > 0)
                                                {
                                                    Console.WriteLine("Elije la cancion que quieres descargar");
                                                    for (int i = 1; i <= almacenamiento.Get_ListaCanciones().Count; i++)
                                                    {
                                                        Console.WriteLine(i + ") " + almacenamiento.Get_ListaCanciones()[i - 1].Get_Titulo());
                                                    }
                                                    int resp = 0;
                                                    Console.WriteLine("Seleccione con su numero\n");
                                                    while (resp == 0 || resp > almacenamiento.Get_ListaCanciones().Count)
                                                    {
                                                        string q = Console.ReadLine();
                                                        int.TryParse(q, out resp);
                                                    }
                                                    impor_expo.Descarga(almacenamiento.Get_ListaCanciones()[resp - 1]);
                                                    Console.WriteLine("Cancion descargada correctamente");
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("No se puede realizar el proceso: No hay canciones en el sistema");
                                                }
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            }

                                        case 4: //rankear cancion
                                            {
                                                Console.WriteLine("RANKEAR:");
                                                Console.WriteLine("(1) Canciones");
                                                Console.WriteLine("(2) Videos");
                                                int opt = 0;
                                                while (opt == 0 || opt >= 3)
                                                {
                                                    int.TryParse(Console.ReadLine(), out opt);
                                                }
                                                if (opt == 1)
                                                {
                                                    if (almacenamiento.Get_ListaCanciones().Count() > 0)
                                                    {
                                                        Console.WriteLine("Elije la cancion que quieres rankear");
                                                        for (int i = 1; i <= almacenamiento.Get_ListaCanciones().Count(); i++)
                                                        {
                                                            Console.WriteLine(i + ") " + almacenamiento.Get_ListaCanciones()[i - 1].Get_Titulo());
                                                        }
                                                        int resp = 0;
                                                        while (resp == 0 || resp > almacenamiento.Get_ListaCanciones().Count())
                                                        {
                                                            string q = Console.ReadLine();
                                                            int.TryParse(q, out resp);
                                                        }
                                                        int estrellas = 0;
                                                        while (estrellas == 0 || estrellas > 5)
                                                        {
                                                            Console.WriteLine("Ingrese la puntuacion con la cual rankeara la cancion (entre 1 a 5)");
                                                            string q = Console.ReadLine();
                                                            int.TryParse(q, out estrellas);
                                                        }
                                                        almacenamiento.Get_ListaCanciones()[resp - 1].Ranked(estrellas);
                                                        if (estrellas >= 4)
                                                        {
                                                            foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                            {
                                                                if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                                {
                                                                    for (int i = 0; i < almacenamiento.Get_ListaCanciones().Count() ; i++)
                                                                    {
                                                                        if(almacenamiento.Get_ListaCanciones()[resp - 1].Get_Genero() == almacenamiento.Get_ListaCanciones()[i].Get_Genero())
                                                                            usu.Get_Recomendacion().Add(almacenamiento.Get_ListaCanciones()[i]);
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        Console.WriteLine("Calificado corretamente");
                                                        Thread.Sleep(1000);
                                                        Console.Clear();
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No se puede realizar el proceso: No hay canciones en el sistema");
                                                        Thread.Sleep(1500);
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                    }
                                                }
                                                else
                                                {
                                                    if (almacenamiento.Get_ListaVideos().Count() > 0)
                                                    {
                                                        Console.WriteLine("Elije el video que quieres rankear");
                                                        for (int i = 1; i <= almacenamiento.Get_ListaVideos().Count(); i++)
                                                        {
                                                            Console.WriteLine(i + ") " + almacenamiento.Get_ListaVideos()[i - 1].Get_Titulo());
                                                        }
                                                        int resp = 0;
                                                        while (resp == 0 || resp > almacenamiento.Get_ListaVideos().Count())
                                                        {
                                                            string q = Console.ReadLine();
                                                            int.TryParse(q, out resp);
                                                        }
                                                        int estrellas = 0;
                                                        while (estrellas == 0 || estrellas > 5)
                                                        {
                                                            Console.WriteLine("Ingrese la puntuacion con la cual rankeara el video (entre 1 a 5)");
                                                            string q = Console.ReadLine();
                                                            int.TryParse(q, out estrellas);
                                                        }
                                                        almacenamiento.Get_ListaVideos()[resp - 1].Ranked(estrellas);
                                                        if (estrellas >= 4)
                                                        {
                                                            foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                            {
                                                                if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                                {
                                                                    for (int i = 0; i < almacenamiento.Get_ListaVideos().Count(); i++)
                                                                    {
                                                                        if (almacenamiento.Get_ListaVideos()[resp - 1].Get_Genero() == almacenamiento.Get_ListaVideos()[i].Get_Genero())
                                                                            usu.Get_Recomendacion().Add(almacenamiento.Get_ListaVideos()[i]);
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        Console.WriteLine("Calificado corretamente");
                                                        Thread.Sleep(1000);
                                                        Console.Clear();
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No se puede realizar el proceso: No hay videos en el sistema");
                                                        Thread.Sleep(1500);
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                    }
                                                }



                                                break;
                                            }
                                        case 5://Ranking
                                            {
                                                Console.WriteLine("Elija el Ranking que quiera ver");
                                                Console.WriteLine("(1) Canciones");
                                                Console.WriteLine("(2) Videos");
                                                Console.WriteLine("Escriba el numero de la opcion");
                                                int opt = 0;
                                                while(opt == 0 || opt >= 3) 
                                                {
                                                    int.TryParse(Console.ReadLine(), out opt);
                                                }
                                                if (opt == 1)
                                                {
                                                    almacenamiento.RankingDeCanciones();
                                                }
                                                else
                                                {
                                                    almacenamiento.RankingDeVideos();
                                                }
                                                Console.WriteLine("Presione cualquier tecla para continuar");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break; 
                                            }
                                        case 6://buscador
                                            {
                                                foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                {
                                                    if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                    {
                                                        Console.WriteLine("Elija metodo de busqueda");
                                                        Console.WriteLine("(1) Buscar por nombre de cancion/video/playlist/usuario/persona");
                                                        Console.WriteLine("(2) Buscar por genero de cancion/video");
                                                        Console.WriteLine("(3) Buscar por duracion de cancion/video");
                                                        Console.WriteLine("(4) Buscar por fecha de inclusion al sistema");
                                                        Console.WriteLine("(5) Buscar por fecha de creacion al sistema");
                                                        Console.WriteLine("(6) Buscar cancion/video por puesto de trabajo de la persona involucrada");
                                                        Console.WriteLine("(7) Buscar cancion/video por genero de la persona involucrada");
                                                        Console.WriteLine("(8) Buscar cancion/video por edad de la persona involucrada");
                                                        Console.WriteLine("(9) Buscar cancion/video por nombre o apellido de la persona involucrada");
                                                        Console.WriteLine("(10) Buscar cancion/video por informacion del archivo");
                                                        Console.WriteLine("(11) Buscar video por calidad");
                                                        Console.WriteLine("(12) Buscar cancion/video por ranking");

                                                        List<int> criterios = new List<int>();
                                                        List<string> buscar = new List<string>();
                                                        int ver = 1;
                                                        List<int> cond_extra = new List<int>();
                                                        while(ver == 1)
                                                        {
                                                            int cond = 0;
                                                            int opt = 0;
                                                            while (opt == 0 || opt > 12)
                                                            {
                                                                Console.WriteLine("Indique numero de la opcion: ");
                                                                int.TryParse(Console.ReadLine(), out opt);
                                                            }
                                                            criterios.Add(opt);
                                                            if (opt == 1)
                                                            {
                                                                Console.WriteLine("Indique su palabra clave");
                                                            }
                                                            else if (opt == 2)
                                                            {
                                                                Console.WriteLine("Indique el genero de la cancion/video");
                                                            }
                                                            else if (opt == 3)
                                                            {
                                                                Console.WriteLine("Indique la duracion de la cancion/video en segundos");
                                                            }
                                                            else if (opt == 4)
                                                            {
                                                                Console.WriteLine("Indique la fecha de inclusion al sistema (Dia-Mes-Año)");
                                                            }
                                                            else if (opt == 5)
                                                            {
                                                                Console.WriteLine("Indique la fecha de publicacion (Dia-Mes-Año)");
                                                            }
                                                            else if (opt == 6)
                                                            {
                                                                Console.WriteLine("Indique el puesto de trabajo de la persona involucrada");
                                                            }
                                                            else if (opt == 7)
                                                            {
                                                                Console.WriteLine("Indique el genero de la persona involucrada (Hombre/Mujer)");
                                                            }
                                                            else if (opt == 8)
                                                            {
                                                                Console.WriteLine("Indique la edad de la persona involucrada");
                                                            }
                                                            else if (opt == 9)
                                                            {
                                                                Console.WriteLine("Indique el nombre de la persona involucrada");
                                                            }
                                                            else if (opt == 10)
                                                            {
                                                                Console.WriteLine("Indique alguna frase clave de la informacion");
                                                            }
                                                            else if (opt == 11)
                                                            {
                                                                Console.WriteLine("Indique la calidad del video a buscar, usando solo el modulo (Ej: 720 si quiero buscar 720p)");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Indique la calificacion promedio minima a buscar");
                                                            }


                                                            buscar.Add(Console.ReadLine());
                                                            if (opt == 3 || opt == 8 || opt == 11 || opt == 12)
                                                            {
                                                                Console.WriteLine("Quiere buscar algo:\n(1)Igual\n(2)Mayor\n(3)Menor\nal dato ingresado\nPonga el numero de la opcion");
                                                                while (cond == 0 || cond > 2)
                                                                {
                                                                    int.TryParse(Console.ReadLine(), out cond);
                                                                }
                                                                cond_extra.Add(cond);
                                                            }
                                                            else
                                                            {
                                                                cond_extra.Add(0);
                                                            }
                                                            Console.WriteLine("Quiere agregar otro criterio\n(1)SI\n(2)NO");
                                                            int op2 = 0;
                                                            while (op2 == 0 || op2 > 2) 
                                                            {
                                                                int.TryParse(Console.ReadLine(), out op2);
                                                                if (op2 == 2)
                                                                    ver = 2;

                                                            }

                                                        }
                                                      
                                                        almacenamiento.filtro_busqueda(buscar, criterios, usu, cond_extra);
                                                        Console.Clear();
                                                        
                                                    }
                                                }


                                                break;
                                            }
                                        case 7://subir un video
                                            {
                                                foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                {
                                                    if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                    {
                                                        impor_expo.agregar_video(almacenamiento, usu);
                                                        Thread.Sleep(1000);
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                    }
                                                }

                                                almacenamiento.Save();


                                                break;
                                            }
                                        case 8:// subir cancion
                                            {
                                                foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                {
                                                    if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                    {
                                                        impor_expo.agregar_cancion(almacenamiento,usu);
                                                        Thread.Sleep(1000);
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                    }

                                                }

                                                almacenamiento.Save();

                                                break;
                                            }
                                        case 9://borrar cancion
                                            {
                                                if (almacenamiento.Get_ListaCanciones().Count() != 0)
                                                {
                                                    Console.WriteLine("Elije la cancion que quieres borrar del programa");
                                                    for (int i = 1; i <= almacenamiento.Get_ListaCanciones().Count; i++)
                                                    {
                                                        Console.WriteLine(i + ") " + almacenamiento.Get_ListaCanciones()[i - 1].Get_Titulo());
                                                    }
                                                    int resp = 0;
                                                    while (resp == 0 || resp > almacenamiento.Get_ListaCanciones().Count)
                                                    {
                                                        string q = Console.ReadLine();
                                                        int.TryParse(q, out resp);
                                                    }
                                                    string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\CancionesSubidas" + "\\" + Path.GetFileName(almacenamiento.Get_ListaCanciones()[resp - 1].Get_Carpeta_Archivo());
                                                    File.Delete(subdir);
                                                    impor_expo.quitar_cancion(almacenamiento.Get_ListaCanciones()[resp - 1], almacenamiento);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay canciones que borrar");
                                                    Thread.Sleep(1000);
                                                }
                                                Console.Clear();


                                                break;
                                            }
                                        case 10: //borrar video
                                            {
                                                if (almacenamiento.Get_ListaVideos().Count() != 0)
                                                {
                                                    Console.WriteLine("Elije el video que quieres borrar del programa");
                                                    for (int i = 1; i <= almacenamiento.Get_ListaVideos().Count; i++)
                                                    {
                                                        Console.WriteLine(i + ") " + almacenamiento.Get_ListaVideos()[i - 1].Get_Titulo());
                                                    }
                                                    int resp = 0;
                                                    while (resp == 0 || resp >= almacenamiento.Get_ListaVideos().Count)
                                                    {
                                                        string q = Console.ReadLine();
                                                        int.TryParse(q, out resp);
                                                    }
                                                    string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\VideosSubidos" + "\\" + Path.GetFileName(almacenamiento.Get_ListaVideos()[resp - 1].Get_Carpeta_Archivo());
                                                    File.Delete(subdir);
                                                    impor_expo.quitar_videos(almacenamiento.Get_ListaVideos()[resp - 1], almacenamiento);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay videos que borrar");
                                                    Thread.Sleep(1000);
                                                }
                                                Console.Clear();
                                                break;
                                            }
                                        case 11: // hacer playlist
                                            {
                                                foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                {
                                                    if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                    {
                                                        if (almacenamiento.Get_ListaCanciones().Count() != 0)
                                                        {
                                                            Console.WriteLine("La playlist que desea es de canciones o videos?? (1-Canciones / 2-Videos)");
                                                            int des = 0;
                                                            while (des == 0 || des >= 3)
                                                            {
                                                                string k = Console.ReadLine();
                                                                int.TryParse(k, out des);
                                                            }
                                                            Console.WriteLine("Ingrese el Nombre de la playlist que va a crear");
                                                            string resp = Console.ReadLine();
                                                            if (des == 1)
                                                                almacenamiento.crear_playlist_canciones(resp,usu);
                                                            if (des == 2)
                                                                almacenamiento.crear_playlist_videos(resp,usu);
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("no hay canciones para hacer playlists");
                                                            Thread.Sleep(1000);
                                                            Console.Clear();
                                                        }
                                                    }
                                                }

                                                almacenamiento.Save();

                                                break;
                                            }

                                        case 12:// modificar playlist
                                            {
                                                foreach (Usuario usu in almacenamiento.Get_Usuarios())
                                                {
                                                    if (usu.Get_Nickname() == nom && usu.Get_Password() == contra)
                                                    {
                                                        if (usu.Get_Lista_Playlist_Agregados().Count() != 0)
                                                        {
                                                            almacenamiento.ModificarPlaylist(usu);
                                                            Console.Clear();
                                                        }

                                                        else
                                                        {
                                                            Console.WriteLine("no hay playlist para poder modificar");
                                                            Thread.Sleep(1000);
                                                            Console.Clear();
                                                        }
                                                    }
                                                }

                                                almacenamiento.Save();

                                                break;
                                            }
                                        case 13: // salir de la sesion
                                            {
                                                almacenamiento.Save();
                                                icase = 13;
                                                break;
                                            }
                                        case 14:// salir del programa
                                            {

                                                almacenamiento.Save();


                                                icase = 13;
                                                numcase = 3;
                                                break;
                                            }                                      
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Usuario o contraseña incorrecto \n");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.Clear();
                            break;
                        }
                    case 2: // crear usuario
                        {
                            Console.Clear();
                            bool boolperfil = false;
                            bool premier = false;
                            int edad = 0;
                            string aux = "";
                            string premium = "";
                            string perfil = "";
                            Console.WriteLine("Se tomaran tus datos personales a continuación:");
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingrese su nombre");
                            string nom = Console.ReadLine();
                            while (edad == 0)
                            {
                                Console.WriteLine("Ingrese su edad");
                                aux = Console.ReadLine();
                                int.TryParse(aux, out edad);
                            }
                            while (perfil != "publico" && perfil != "privado")
                            {
                                Console.WriteLine("Ingrese si quiere un perfil publico o privado (publico/privado)");
                                perfil = Console.ReadLine();
                            }
                            while (premium != "si" && premium != "no")
                            {
                                Console.WriteLine("Sera un usuario premium? (si/no)");
                                premium = Console.ReadLine();
                            }
                            Console.WriteLine("Ingrese su nickname");
                            string nick = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña");
                            string contra = Console.ReadLine();
                            if (perfil == "privado")
                                boolperfil = true;
                            if (premium == "si")
                                premier = true;
                            List<Canciones> a = new List<Canciones>();
                            List<Video> b = new List<Video>();
                            List<Playlist> c = new List<Playlist>();
                            List<Usuario> d = new List<Usuario>();
                            List<Canciones> e = new List<Canciones>();
                            List<Video> f = new List<Video>();
                            Usuario persona = new Usuario(nom, edad, boolperfil, premier, nick, contra, false,"",a,b,c,d,e,f);
                            almacenamiento.AgregarUsuario(persona);
                            Console.WriteLine("Cuenta creada con exito");
                            Thread.Sleep(1000);
                            Console.Clear();

                            almacenamiento.Save();



                            break;
                        }
                    case 3: // salir del programa
                        {
                            almacenamiento.Save();
                            numcase = 3;
                            break;
                        }
                    default:
                        Console.WriteLine("Ingrese opcion valida");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                }
        }
    }
}
