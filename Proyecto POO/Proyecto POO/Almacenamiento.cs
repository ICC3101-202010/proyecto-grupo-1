using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;
namespace Proyecto_POO
{
    [Serializable()]
    public class Almacenamiento
    {
        private List<Canciones> Lista_canciones = new List<Canciones>();
        private List<Video> Lista_videos = new List<Video>();
        private List<Usuario> Usuario = new List<Usuario>();
        private List<Video> Cola_reproduccion_videos = new List<Video>();
        private List<Canciones> Cola_reproduccion_canciones = new List<Canciones>();
        private List<Playlist> Playlist_multimedia = new List<Playlist>();
        private List<Personas> Persona = new List<Personas>();



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

        public void RankingDeCanciones() 
        {
            Console.WriteLine("Ranking de Canciones");
            List<Canciones> temp = new List<Canciones>();
            for (int i = 0; i < Lista_canciones.Count(); i++)
            {
                temp.Add(Lista_canciones[i]);
            }
            List<Canciones> ordenado = temp.OrderBy(o => o.Get_Mean_Tier()).ToList();
            
            for (int i = ordenado.Count(); i > 0; i--)
            {
                Console.WriteLine(i + ") " + ordenado[i -1].Get_Titulo() + " Ptje: " + ordenado[i-1 ].Get_Mean_Tier());
            }

        }

        public void RankingDeVideos() 
        {
            Console.WriteLine("Ranking de Videos");
            List<Video> temp = new List<Video>();
            for (int i = 0; i < Lista_videos.Count(); i++)
            {
                temp.Add(Lista_videos[i]);
            }
            List<Video> ordenado = temp.OrderBy(o => o.Get_Mean_Tier()).ToList();

            for (int i = ordenado.Count(); i > 0; i--)
            {
                Console.WriteLine(i + ") " + ordenado[i - 1].Get_Titulo() + " Ptje: " + ordenado[i - 1].Get_Mean_Tier());
            }
        }


        public void ReproducirMultimedia(Multimedia multi)
        {
            System.Diagnostics.Process.Start(multi.Get_Carpeta_Archivo());
            Thread.Sleep(multi.Get_Duracion() * 1000);
            multi.Sumar_Reproducciones();
        }

        public void crear_playlist_canciones(string nombreplaylist, Usuario usu)
        {


            List<Canciones> Playlist_canciones = new List<Canciones>();
            List<Video> Playlist_videos = new List<Video>();
            List<Usuario> Seguidores = new List<Usuario>();
            Playlist newplay = new Playlist(nombreplaylist, Playlist_canciones, Playlist_videos, Seguidores);
            int operacion = 0;

            while (operacion == 0)
            {

                int i = 1;
                foreach (Canciones data in Lista_canciones)
                {

                    Console.WriteLine(i + ") " + data.Get_Titulo()  + "; " + data.Get_Album());
                    i++;
                }

                Console.WriteLine("Elija una cancion a agregar con el numero");
                int index = 0;
                while (index == 0 || index > i)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out index);
                }
                newplay.Get_Playlist_Canciones().Add(Lista_canciones[index-1]);         

                Console.WriteLine("Quieres agregar otra cancion a la playlist (1 = YES/2 = NO)");
                while (operacion == 0 || operacion > 2)
                {
                    int.TryParse(Console.ReadLine(), out operacion);
                }
                if (operacion == 1)
                    operacion = 0;
            }
            Playlist_multimedia.Add(newplay);
            usu.Add_Playlist_To_My_List(newplay);


        }
        public void crear_playlist_videos(string nombreplaylist, Usuario usu)
        {
            List<Canciones> Playlist_canciones = new List<Canciones>();
            List<Video> Playlist_videos = new List<Video>();
            List<Usuario> Seguidores = new List<Usuario>();

            Playlist newplay = new Playlist(nombreplaylist, Playlist_canciones, Playlist_videos, Seguidores);
            int operacion = 0;

            while (operacion == 0)
            {
                int i = 1;
                foreach (Video data in Lista_videos)
                {
                    Console.WriteLine(i + ") " + data.Get_Titulo());
                    i++;
                }

                Console.WriteLine("Elija una pelicula a agregar con el numero");
                int index = 0;
                while (index == 0 || index > i)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out index);
                }
                newplay.Get_Playlist_Video().Add(Lista_videos[index - 1]);


                Console.WriteLine("Quieres agregar otro video a la playlist (1 = YES / 2 = NO)");
                while (operacion == 0 || operacion > 2)
                {
                    int.TryParse(Console.ReadLine(), out operacion);
                }
                if (operacion == 1)
                    operacion = 0;
            }

            Playlist_multimedia.Add(newplay);
            usu.Add_Playlist_To_My_List(newplay);
        }

        public void ModificarPlaylist(Usuario usu)//falta testear AQUI AQUI!!!!
        {
            int re = 0;
            int a = 0;
            int again = 0;
      
            for(int i = 0; i < usu.Get_Lista_Playlist_Agregados().Count; i++)
            {
                Console.WriteLine((i+1) + ") " + usu.Get_Lista_Playlist_Agregados()[i].Get_Name());
                a = i;
            }
            Console.WriteLine("Elige el numero de la playlist");
            int index = 0;
            while (index == 0 || index > usu.Get_Lista_Playlist_Agregados().Count)
            {
                string q = Console.ReadLine();
                int.TryParse(q, out index);
            }
            Thread.Sleep(1000);
            Console.Clear();
            while(again == 0)
            { 
            if (usu.Get_Lista_Playlist_Agregados()[index-1].Get_Playlist_Canciones().Count == 0)
            {
                Console.WriteLine("La playlist tiene los siguientes videos");
                for(int i= 0; i < usu.Get_Lista_Playlist_Agregados()[index-1].Get_Playlist_Video().Count; i++)
                {
                    Console.WriteLine((i+1)+ ") " + usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video()[i].Get_Titulo());
                }

                Console.WriteLine("Que quieres hacer ahora?");
                Console.WriteLine("(1) Agregar video");
                Console.WriteLine("(2) Quitar video");
                Console.WriteLine("(3) Borrar playlist");
                int index2 = 0;
                while (index2 == 0 || index2 > 3)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out index2);
                }
                Thread.Sleep(1000);
                Console.Clear();
                switch (index2)
                {
                    case 1:
                        for(int i = 0; i < Lista_videos.Count();i++)
                        {
                            Console.WriteLine((i+1)+ ") " + Lista_videos[i].Get_Titulo());
                        }
                        Console.WriteLine("Elige el numero del video que quieres agregar");
                        int index3 = 0;
                        while (index3 == 0 || index3 > Lista_videos.Count())
                        {
                            string q = Console.ReadLine();
                            int.TryParse(q, out index3);
                        }

                            usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video().Add(Lista_videos[index3-1]);
                            Console.WriteLine("quieres realizar otra accion? (1 = YES / 2 = NO)");
                            re = 0;
                            while (re == 0 || re > 2)
                            {
                                int.TryParse(Console.ReadLine(), out re);
                            }
                            if (re == 2)
                                again = 1;
                            break;
                    case 2:
                        for (int i = 0; i < usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video().Count; i++)
                        {
                            Console.WriteLine((i + 1) + ") " + usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video()[i].Get_Titulo());
                        }
                        Console.WriteLine("Elige el numero del video que quieres quitar");
                        index3 = 0;
                        while (index3 == 0 || index3 > usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video().Count)
                        {
                            string q = Console.ReadLine();
                            int.TryParse(q, out index3);
                        }
                        usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video().Remove(usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Video()[index3 - 1]);
                        Console.WriteLine("quieres realizar otra accion? (1 = YES / 2 = NO)");
                        re = 0;
                        while (re == 0 || re > 2)
                        {
                            int.TryParse(Console.ReadLine(), out re);
                        }
                        if (re == 2)
                            again = 1;

                            break;
                    case 3:
 
                            for (int i = 0; i < Playlist_multimedia.Count(); i++)
                            {
                                for (int j = 0; j < usu.Get_Lista_Playlist_Agregados().Count(); i++)
                                {
                                    if (Playlist_multimedia[i].Get_Name() == usu.Get_Lista_Playlist_Agregados()[j].Get_Name())
                                        Playlist_multimedia.Remove(Playlist_multimedia[i]);

                                }

                            }
                         
                        usu.Get_Lista_Playlist_Agregados().Remove(usu.Get_Lista_Playlist_Agregados()[index - 1]);
                        Thread.Sleep(1000);
                        Console.WriteLine("Tu playlist ha sido eliminada");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("quieres realizar otra accion? (1 = YES / 2 = NO)");
                        re = 0;
                        while (re == 0 || re > 2)
                        {
                            int.TryParse(Console.ReadLine(), out re);
                        }
                        if (re == 2)
                            again = 1;

                            break;
                }
            }
            else if (usu.Get_Lista_Playlist_Agregados()[index-1].Get_Playlist_Video().Count == 0)
            {

                Console.WriteLine("La playlist tiene las siguientes canciones");
                for (int i = 0; i < usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones().Count; i++)
                {
                    Console.WriteLine((i + 1) + ") " + usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones()[i].Get_Titulo());
                }

                Console.WriteLine("Que quieres hacer ahora?");
                Console.WriteLine("(1) Agregar cancion");
                Console.WriteLine("(2) Quitar cancion");
                Console.WriteLine("(3) Borrar playlist");
                int index2 = 0;
                while (index2 == 0 || index2 > 3)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out index2);
                }
                Thread.Sleep(1000);
                Console.Clear();
                switch (index2)
                {
                    case 1:
                        for (int i = 0; i < Lista_canciones.Count(); i++)
                        {
                            Console.WriteLine((i + 1) + ") " + Lista_canciones[i].Get_Titulo());
                        }
                        Console.WriteLine("Elige el numero del canciones que quieres agregar");
                        int index3 = 0;
                        while (index3 == 0 || index3 > Lista_canciones.Count())
                        {
                            string q = Console.ReadLine();
                            int.TryParse(q, out index3);
                        }

                        usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones().Add(Lista_canciones[index3 - 1]);
                        Console.WriteLine("quieres realizar otra accion? (1 = YES / 2 = NO)");
                        re = 0;
                        while (re == 0 || re > 2)
                        {
                            int.TryParse(Console.ReadLine(), out re);
                        }
                        if (re == 2)
                            again = 1;
                            break;
                    case 2:
                        for (int i = 0; i < usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones().Count; i++)
                        {
                            Console.WriteLine((i + 1) + ") " + usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones()[i].Get_Titulo());
                        }
                        Console.WriteLine("Elige el numero de la cancion que quieres quitar");
                        index3 = 0;
                        while (index3 == 0 || index3 > usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones().Count)
                        {
                            string q = Console.ReadLine();
                            int.TryParse(q, out index3);
                        }
                            usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones().Remove(usu.Get_Lista_Playlist_Agregados()[index - 1].Get_Playlist_Canciones()[index3 - 1]);
                            Console.WriteLine("quieres realizar otra accion? (1 = YES / 2 = NO)");
                            re = 0;
                            while (re == 0 || re > 2)
                            {
                                int.TryParse(Console.ReadLine(), out re);
                            }
                            if (re == 2)
                                again = 1;
                            break;
                    case 3:
                            for (int i = 0; i < Playlist_multimedia.Count(); i++)
                            {
                                for (int j = 0; j < usu.Get_Lista_Playlist_Agregados().Count(); i++)
                                {
                                    if (Playlist_multimedia[i].Get_Name() == usu.Get_Lista_Playlist_Agregados()[j].Get_Name())
                                        Playlist_multimedia.Remove(Playlist_multimedia[i]);

                                }

                            }
                        usu.Get_Lista_Playlist_Agregados().Remove(usu.Get_Lista_Playlist_Agregados()[index - 1]);
                        Thread.Sleep(1000);
                        Console.WriteLine("Tu playlist ha sido eliminada");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("quieres realizar otra accion? (1 = YES / 2 = NO)");
                        re = 0;
                        while (re == 0 || re > 2)
                        {
                            int.TryParse(Console.ReadLine(), out re);
                        }
                        if (re == 2)
                            again = 1;
                            break;
                    }
                }
            }//falta testear
        }

        public void ColaReproduccionCanciones()
        {
            List<Canciones> Cola = new List<Canciones>();

            int operacion = 0;

            while (operacion == 0)
            {

                int i = 1;
                foreach (Canciones data in Lista_canciones)
                {

                    Console.WriteLine(i + ") " + data.Get_Titulo() + "; " + data.Get_Album());
                    i++;
                }

                Console.WriteLine("Elija una cancion a agregar la cola con el numero");
                int index = 0;
                while (index == 0 || index > i)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out index);
                }

                Console.WriteLine("Quieres agregar otra cancion a la playlist (1 = YES / 2 = NO)");
                while (operacion == 0 || operacion > 2)
                {
                    int.TryParse(Console.ReadLine(), out operacion);
                }
                if (operacion == 1)
                    operacion = 0;
                Cola.Add(Lista_canciones[index-1]);
            }
            for(int j = 0; j < Cola.Count; j++)
            {
                ReproducirMultimedia(Cola[j]);

            }


        }

        public void ColaReproduccionVideos()
        {
            List<Video> Cola = new List<Video>();

            int operacion = 0;

            while (operacion == 0)
            {

                int i = 1;
                foreach (Video data in Lista_videos)
                {

                    Console.WriteLine(i + ") " + data.Get_Titulo());
                    i++;
                }

                Console.WriteLine("Elija un video a agregar la cola con el numero");
                int index = 0;
                while (index == 0 || index > i)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out index);
                }

                Console.WriteLine("Quieres agregar otro video a la playlist (1 = YES / 2 = NO)");
                while (operacion == 0 || operacion > 2)
                {
                    int.TryParse(Console.ReadLine(), out operacion);
                }
                if (operacion == 1)
                    operacion = 0;
                Cola.Add(Lista_videos[index - 1]);
            }
            for (int j = 0; j < Cola.Count; j++)
            {
                ReproducirMultimedia(Cola[j]);
            }


        }

        public void PortadaCancion(Canciones cancion)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\PortadasCanciones";

            string archivo = @Path.GetFileName(cancion.Get_Portada());
            string carpeta = Path.GetDirectoryName(cancion.Get_Portada());
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            string sourceFile = System.IO.Path.Combine(carpeta, archivo);
            string destFile = System.IO.Path.Combine(subdir, archivo);
            System.IO.File.Copy(sourceFile, destFile, true);
        }
        public void PortadaVideo(Video video)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\PortadasVideos";
            string archivo = @Path.GetFileName(video.Get_Portada());
            string carpeta = Path.GetDirectoryName(video.Get_Portada());

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            string sourceFile = System.IO.Path.Combine(carpeta, archivo);
            string destFile = System.IO.Path.Combine(subdir, archivo);
            System.IO.File.Copy(sourceFile, destFile, true);

        }
        public void MostrarPortadaCancion(Canciones cancion)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string archivo = @Path.GetFileName(cancion.Get_Portada());
            string direccion = @System.IO.Directory.GetCurrentDirectory() + "\\PortadasCanciones" + "\\" + archivo;
            System.Diagnostics.Process.Start(direccion);

            
        }
        public void MostrarPortadaCancion(Video video)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string archivo = @Path.GetFileName(video.Get_Portada());
            string direccion = @System.IO.Directory.GetCurrentDirectory() + "\\PortadasCanciones" + "\\" + archivo;
            System.Diagnostics.Process.Start(direccion);


        }







        public void filtro_busqueda(List<string>buscado, List<int> criterio, Usuario usu, List<int> cond_Extra)
        {
            int i = 1;
            int index = 0;
            int terminoCan = 0;
            int terminoVid = 0;
            int terminoUsu = 0;
            int terminoPlay = 0;
            int terminoPers = 0;
            List<Canciones> cancion_encontrada = new List<Canciones>();
            List<Video> videos_encontrados = new List<Video>();
            List<Playlist> playlist_encontradas = new List<Playlist>();
            List<Usuario> usuarios_encontrados = new List<Usuario>();
            List<Personas> personas_encontradas = new List<Personas>();

            foreach (int k in criterio)
            {
                if (k == 1) //Nombre
                {

                    foreach (Canciones data in Lista_canciones)
                    {
                        if (data.Get_Titulo().Contains(buscado[index]) && !cancion_encontrada.Contains(data)) //Si el titulo contiene el substring buscado
                        {
                            cancion_encontrada.Add(data);
                        }
                    }
                    Console.WriteLine("");
                    foreach (Video data in Lista_videos)
                    {
                        if (data.Get_Titulo().Contains(buscado[index]) && !videos_encontrados.Contains(data)) //Si el titulo contiene el substring buscado
                        {
                            videos_encontrados.Add(data);
                        }
                    }
                    foreach (Playlist data in Playlist_multimedia)
                    {
                        if (data.Get_Name().Contains(buscado[index]) && !playlist_encontradas.Contains(data)) //Si el titulo contiene el substring buscado
                        {
                            playlist_encontradas.Add(data);
                        }
                    }
                    foreach (Usuario data in Usuario)
                    {
                        if ((data.Get_Nombre().Contains(buscado[index]) || data.Get_Nickname().Contains(buscado[index])) && !usuarios_encontrados.Contains(data)) //Si el titulo contiene el substring buscado
                        {
                            usuarios_encontrados.Add(data);
                        }
                    }
                    foreach (Personas data in Persona)
                    {
                        if (data.Get_Name().Contains(buscado[index]) && !personas_encontradas.Contains(data)) //Si el titulo contiene el substring buscado
                        {
                            personas_encontradas.Add(data);
                        }
                    }
                }

                if (k == 2) //Genero del archivo Multimedia
                {
                    foreach (Canciones data in Lista_canciones)
                    {
                        if (data.Get_Genero().Contains(buscado[index]) && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                        {
                            cancion_encontrada.Add(data);
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        if (data.Get_Genero().Contains(buscado[index]) && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                        {
                            videos_encontrados.Add(data);
                        }
                    }
                }

                if (k == 3) //Duracion
                {
                    if (cond_Extra[index] == 1)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            if (data.Get_Duracion() == Convert.ToInt32(buscado[index]) && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            if (data.Get_Duracion() == Convert.ToInt32(buscado[index]) && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                    if (cond_Extra[index] == 2)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            if (data.Get_Duracion() >= Convert.ToInt32(buscado[index]) && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            if (data.Get_Duracion() >= Convert.ToInt32(buscado[index]) && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                    if (cond_Extra[index] == 3)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            if (data.Get_Duracion() <= Convert.ToInt32(buscado[index]) && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            if (data.Get_Duracion() <= Convert.ToInt32(buscado[index]) && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                }

                if (k == 4) //Fecha de inclusion
                {
                    foreach (Canciones data in Lista_canciones)
                    {
                        if (data.Get_Fecha_Inclusion().Contains(buscado[index]) && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                        {
                            cancion_encontrada.Add(data);
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        if (data.Get_Fecha_Inclusion().Contains(buscado[index]) && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                        {
                            videos_encontrados.Add(data);
                        }
                    }
                }

                if (k == 5) //Fecha de publicacion
                {
                    foreach (Canciones data in Lista_canciones)
                    {
                        if (data.Get_Fecha_Publicacion().Contains(buscado[index]) && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                        {
                            cancion_encontrada.Add(data);
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        if (data.Get_Fecha_Publicacion().Contains(buscado[index]) && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                        {
                            videos_encontrados.Add(data);
                        }
                    }
                }

                if (k == 6)//Buscar cancion/video por puesto de trabajo de la persona
                {
                    foreach (Canciones data in Lista_canciones)
                    {
                        foreach (Personas data2 in data.Get_Artistas())
                        {
                            if (data2.Get_Puesto().Contains(buscado[index]) && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        foreach (Personas data2 in data.Get_Staff())
                        {
                            if (data2.Get_Puesto().Contains(buscado[index]) && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                }

                if (k == 7)//Buscar cancion/video por sexo de la persona involucrada
                {
                    foreach (Canciones data in Lista_canciones)
                    {
                        foreach (Personas data2 in data.Get_Artistas())
                        {
                            if (data2.Get_Sex().Contains(buscado[index]) && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        foreach (Personas data2 in data.Get_Staff())
                        {
                            if (data2.Get_Sex().Contains(buscado[index]) && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                }

                if (k == 8)//Buscar por edad
                {
                    if (cond_Extra[index] == 1)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            foreach (Personas data2 in data.Get_Artistas())
                            {
                                int ed = 0;
                                int.TryParse(buscado[index], out ed);
                                if (data2.Get_Edad() == ed && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                                {
                                    cancion_encontrada.Add(data);
                                }
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            foreach (Personas data2 in data.Get_Staff())
                            {
                                int ed = 0;
                                int.TryParse(buscado[index], out ed);
                                if (data2.Get_Edad() == ed && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                                {
                                    videos_encontrados.Add(data);
                                }
                            }
                        }
                    }
                    if (cond_Extra[index] == 2)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            foreach (Personas data2 in data.Get_Artistas())
                            {
                                int ed = 0;
                                int.TryParse(buscado[index], out ed);
                                if (data2.Get_Edad() >= ed && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                                {
                                    cancion_encontrada.Add(data);
                                }
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            foreach (Personas data2 in data.Get_Staff())
                            {
                                int ed = 0;
                                int.TryParse(buscado[index], out ed);
                                if (data2.Get_Edad() >= ed && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                                {
                                    videos_encontrados.Add(data);
                                }
                            }
                        }
                    }
                    if (cond_Extra[index] == 3)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            foreach (Personas data2 in data.Get_Artistas())
                            {
                                int ed = 0;
                                int.TryParse(buscado[index], out ed);
                                if (data2.Get_Edad() <= ed && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                                {
                                    cancion_encontrada.Add(data);
                                }
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            foreach (Personas data2 in data.Get_Staff())
                            {
                                int ed = 0;
                                int.TryParse(buscado[index], out ed);
                                if (data2.Get_Edad() <= ed && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                                {
                                    videos_encontrados.Add(data);
                                }
                            }
                        }
                    }
                }

                if(k == 9) // Buscar por personas involucradas (nombre)
                {
                    foreach(Canciones data in Lista_canciones)
                    {
                        foreach (Personas data2 in data.Get_Artistas())
                        {
                            if (data2.Get_Name().Contains(buscado[index]) || data2.Get_LastName().Contains(buscado[index]) && !cancion_encontrada.Contains(data)) //Si el genero contiene el substring buscado
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        foreach (Personas data2 in data.Get_Staff())
                        {
                            if ((data2.Get_Name().Contains(buscado[index]) || data2.Get_LastName().Contains(buscado[index])) && !videos_encontrados.Contains(data)) //Si el genero contiene el substring buscado
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                }

                if(k == 10) //Informacion
                {
                    foreach(Canciones data in Lista_canciones)
                    {
                        if (data.Get_Descripcion().Contains(buscado[index]) && !cancion_encontrada.Contains(data))
                        {
                            cancion_encontrada.Add(data);
                        }
                    }
                    foreach (Video data in Lista_videos)
                    {
                        if (data.Get_Descripcion().Contains(buscado[index]) && !videos_encontrados.Contains(data))
                        {
                            videos_encontrados.Add(data);
                        }
                    }

                }

                if (k == 11)
                {
                    if (cond_Extra[index] == 1)
                    {
                        foreach (Video data in Lista_videos)
                        {
                            int cal = 0;
                            int.TryParse(buscado[index], out cal);
                            if (data.Get_Calidad() == cal && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                    if (cond_Extra[index] == 2)
                    {
                        foreach (Video data in Lista_videos)
                        {
                            int cal = 0;
                            int.TryParse(buscado[index], out cal);
                            if (data.Get_Calidad() >= cal && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                    if (cond_Extra[index] == 3)
                    {
                        foreach (Video data in Lista_videos)
                        {
                            int cal = 0;
                            int.TryParse(buscado[index], out cal);
                            if (data.Get_Calidad() <= cal && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }

                }

                if (k == 12)
                {
                    if (cond_Extra[index] == 1)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            int q;
                            int.TryParse(buscado[index], out q);
                            if (q == data.Get_Mean_Tier() && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            int q;
                            int.TryParse(buscado[index], out q);
                            if (q == data.Get_Mean_Tier() && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                    if (cond_Extra[index] == 2)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            int q;
                            int.TryParse(buscado[index], out q);
                            if (q >= data.Get_Mean_Tier() && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            int q;
                            int.TryParse(buscado[index], out q);
                            if (q >= data.Get_Mean_Tier() && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                    if (cond_Extra[index] == 3)
                    {
                        foreach (Canciones data in Lista_canciones)
                        {
                            int q;
                            int.TryParse(buscado[index], out q);
                            if (q <= data.Get_Mean_Tier() && !cancion_encontrada.Contains(data))
                            {
                                cancion_encontrada.Add(data);
                            }
                        }
                        foreach (Video data in Lista_videos)
                        {
                            int q;
                            int.TryParse(buscado[index], out q);
                            if (q <= data.Get_Mean_Tier() && !videos_encontrados.Contains(data))
                            {
                                videos_encontrados.Add(data);
                            }
                        }
                    }
                }
                index++;
            }
            
            //Se supone que siempre cancion <video <playlist <usuario <persona
            Console.WriteLine("Canciones encontradas con el criterio de busqueda: ");
            foreach(Canciones data in cancion_encontrada)
            {
                Console.WriteLine(i + " )" + data.Get_Titulo());
                i++;
            }
            terminoCan = i;
            Console.WriteLine("Videos encontrados con el criterio de busqueda: ");
            foreach (Video data in videos_encontrados)
            {
                Console.WriteLine(i + " )" + data.Get_Titulo());
                i++;
            }
            terminoVid = i;
            Console.WriteLine("Playlists encontradas con el criterio de busqueda: ");
            foreach (Playlist data in playlist_encontradas)
            {
                Console.WriteLine(i + " )" + data.Get_Name());
                i++;
            }
            terminoPlay = i;
            Console.WriteLine("Usuarios encontrados con el criterio de busqueda: ");
            foreach (Usuario data in usuarios_encontrados)
            {
                Console.WriteLine(i + " )" + data.Get_Nickname());
                i++;
            }
            terminoUsu = i;
            Console.WriteLine("Personas encontrados con el criterio de busqueda: ");
            foreach (Personas data in personas_encontradas)
            {
                Console.WriteLine(i + " )" + data.Get_Name() + data.Get_LastName());
                i++;
            }
            terminoPers = i;

            if (i > 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Elige la opcion con un numero");//mmmm
                int opcion = 0;
                while (opcion == 0 || opcion > i)
                {
                    string q = Console.ReadLine();
                    int.TryParse(q, out opcion);
                }
                Console.Clear();
                int opcion_2 = 0;
                if (opcion < terminoCan)
                {
                    Console.WriteLine("Opciones para la cancion " + cancion_encontrada[opcion - 1].Get_Titulo());
                    Console.WriteLine("1) Reproducir la Cancion");
                    Console.WriteLine("2) Descargar la Cancion");
                    Console.WriteLine("3) Seguir la Cancion");
                    Console.WriteLine("4) Mostrar Informacion de la Cancion");
                    Console.WriteLine("5) Comentar la Cancion");
                    Console.WriteLine("6) Agregar/Eliminar cancion a favoritos");
                    Console.WriteLine("Escriba numero de la opcion: ");
                    while (opcion_2 == 0 || opcion_2 > 6)
                    {
                        string q = Console.ReadLine();
                        int.TryParse(q, out opcion_2);
                    }
                    Console.Clear();
                    if (opcion_2 == 1)
                    {
                        ReproducirMultimedia(cancion_encontrada[opcion - 1]);
                        Console.WriteLine("La cancion se esta reproduciendo");
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        Console.ReadLine();
                    }
                    if (opcion_2 == 2)
                    {
                        Importacion_Exportacion imp = new Importacion_Exportacion();
                        imp.Descarga(cancion_encontrada[opcion - 1]);

                    }
                    if (opcion_2 == 3)
                    {
                        cancion_encontrada[opcion - 1].seguir(usu);

                    }
                    if (opcion_2 == 4)
                    {
                        cancion_encontrada[opcion - 1].informacion();
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        Console.ReadLine();

                    }
                    if (opcion_2 == 5)
                    {
                        Console.WriteLine("Escriba su comentario");
                        string comentario = Console.ReadLine();
                        cancion_encontrada[opcion - 1].agregar_comentarios(comentario);
                        Console.WriteLine("comentario agregado correctamente");
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        Console.ReadLine();
                    }
                    if (opcion_2 == 6)
                    {
                        usu.Add_Favoritos(cancion_encontrada[opcion - 1]);
                        for (int j = 0; j < Get_ListaCanciones().Count(); j++)
                        {
                            if (cancion_encontrada[opcion - 1].Get_Genero() == Get_ListaCanciones()[j].Get_Genero())
                                usu.Get_Recomendacion().Add(Get_ListaCanciones()[j]);
                        }
                    }

                }
                else if (opcion < terminoVid)
                {
                    Console.WriteLine("Opciones para el video " + videos_encontrados[opcion - terminoCan].Get_Titulo());
                    Console.WriteLine("1) Reprdocuir el video");
                    Console.WriteLine("2) Seguir el video");
                    Console.WriteLine("3) Mostrar Informacion del video");
                    Console.WriteLine("4) Comentar el video");
                    Console.WriteLine("5) Agregar/Eliminar video a favoritos");
                    Console.WriteLine("Escriba numero de la opcion: ");
                    while (opcion_2 == 0 || opcion_2 > 5)
                    {
                        string q = Console.ReadLine();
                        int.TryParse(q, out opcion_2);
                    }
                    if (opcion_2 == 1)
                    {
                        ReproducirMultimedia(videos_encontrados[opcion - terminoCan]);
                        Thread.Sleep(2000);
                    }
                    if (opcion_2 == 2)
                    {
                        videos_encontrados[opcion - terminoCan].seguir(usu);

                    }
                    if (opcion_2 == 3)
                    {
                        videos_encontrados[opcion - terminoCan].informacion();
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        Console.ReadLine();
                    }
                    if (opcion_2 == 4)
                    {
                        Console.WriteLine("Escriba su comentario");
                        string comentario = Console.ReadLine();
                        videos_encontrados[opcion - terminoCan].agregar_comentarios(comentario);

                    }
                    if (opcion_2 == 5)
                    {
                        usu.Add_Favoritos(videos_encontrados[opcion - terminoCan]);
                        for (int j = 0; j < Get_ListaVideos().Count(); j++)
                        {
                            if (cancion_encontrada[opcion - 1].Get_Genero() == Get_ListaVideos()[j].Get_Genero())
                                usu.Get_Recomendacion().Add(Get_ListaVideos()[j]);
                        }

                    }
                }
                else if (opcion < terminoPlay)
                {
                    Console.WriteLine("Opciones para la playlist " + playlist_encontradas[opcion - terminoVid].Get_Name());
                    Console.WriteLine("1) Reprdocuir la playlist");
                    Console.WriteLine("2) Seguir la playlist");
                    Console.WriteLine("3) Mostrar Informacion de la playlist");
                    Console.WriteLine("Escriba numero de la opcion: ");
                    while (opcion_2 == 0 || opcion_2 > 3)
                    {
                        string q = Console.ReadLine();
                        int.TryParse(q, out opcion_2);
                    }
                    if (opcion_2 == 1)
                    {
                        if (playlist_encontradas[opcion - terminoVid].Get_Playlist_Video().Count() == 0)
                        {
                            for (int k = 0; k < Get_Playlist()[index - 1].Get_Playlist_Canciones().Count(); k++)
                            {
                                ReproducirMultimedia(playlist_encontradas[opcion - terminoVid].Get_Playlist_Canciones()[k]);
                            }
                        }
                        if (playlist_encontradas[opcion - terminoVid].Get_Playlist_Canciones().Count() == 0)
                        {
                            for (int o = 0; i < Get_Playlist()[index - 1].Get_Playlist_Video().Count(); o++)
                            {
                                ReproducirMultimedia(playlist_encontradas[opcion - terminoVid].Get_Playlist_Video()[o]);
                            }
                        }
                    }
                    if (opcion_2 == 2)
                    {
                        playlist_encontradas[opcion - terminoVid].Seguir(usu);
                    }
                    if (opcion_2 == 3)
                    {
                        if (playlist_encontradas[opcion - terminoVid].Get_Playlist_Canciones().Count() > 0)
                        {
                            playlist_encontradas[opcion - terminoVid].MostrarCanciones();
                        }
                        if (playlist_encontradas[opcion - terminoVid].Get_Playlist_Video().Count() > 0)
                        {
                            playlist_encontradas[opcion - terminoVid].MostrarVideos();
                        }
                    }
                }
                else if (opcion < terminoUsu)
                {
                    Console.WriteLine("Opciones para el usuario " + usuarios_encontrados[opcion - terminoPlay].Get_Nickname());
                    Console.WriteLine("1) Seguir el usuario");
                    Console.WriteLine("2) Mostrar Informacion del Usuario");
                    Console.WriteLine("3) Ver Favoritos");
                    Console.WriteLine("Escriba numero de la opcion: ");
                    while (opcion_2 == 0 || opcion_2 > 2)
                    {
                        string q = Console.ReadLine();
                        int.TryParse(q, out opcion_2);
                    }
                    if (opcion_2 == 1)
                    {
                        usuarios_encontrados[opcion - terminoPlay].Seguir(usu);
                    }
                    if (opcion_2 == 2)
                    {
                        if (usuarios_encontrados[opcion - terminoPlay].Get_TipoDeUsuario())
                        {
                            Console.WriteLine("No puedes ver esta informacion porque el usuario es privado");
                        }
                        else
                        {
                            usuarios_encontrados[opcion - terminoPlay].Informacion_Usuario();
                        }
                    }
                    if (opcion_2 == 3)
                    {
                        if (usuarios_encontrados[opcion - terminoPlay].Get_TipoDeUsuario())
                        {
                            Console.WriteLine("No puedes ver esta informacion porque el usuario es privado");
                        }
                        else
                        {
                            usuarios_encontrados[opcion - terminoPlay].Consultar_Favoritos();
                        }
                    }
                }
                else if (opcion < terminoPers)
                {
                    Console.WriteLine("Opciones para la persona " + personas_encontradas[opcion - terminoUsu].Get_Name());
                    Console.WriteLine("1) Seguir la persona");
                    Console.WriteLine("2) Mostrar Informacion de la persona");
                    Console.WriteLine("Escriba numero de la opcion: ");
                    while (opcion_2 == 0 || opcion_2 > 2)
                    {
                        string q = Console.ReadLine();
                        int.TryParse(q, out opcion_2);
                    }
                    if (opcion_2 == 1)
                    {
                        personas_encontradas[opcion - terminoUsu].Seguir(usu);
                    }
                    if (opcion_2 == 2)
                    {
                        personas_encontradas[opcion - terminoUsu].Informacion_Persona(Lista_videos, Lista_canciones);
                    }
                }
            }
            else
            {
                Console.WriteLine("no hay elementos con el criterio de busqueda");
                Thread.Sleep(2000);
            }
                Console.Clear();
            
        }

        public void Bonus_Game(Usuario usu)
        {
            Console.Clear();
            Console.WriteLine("Le mostraremos una letra de una cancion al azar en nuestro sistema, si adivina, su usuario pasara a ser premium");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            Random rnd = new Random();
            int rnd_letra = rnd.Next(0, Lista_canciones.Count());
            Console.WriteLine(Lista_canciones[rnd_letra].Get_Letra());
            Console.WriteLine("Escriba la cancion que corresponde a esa letra");
            string adivina = Console.ReadLine();
            if (adivina == Lista_canciones[rnd_letra].Get_Titulo())
            {
                Console.WriteLine("Felicidades, su usuario pasa a ser premium");
                usu.Cambiar_dato_booleano(2);
            }
            else
            {
                Console.WriteLine("La cancion no es correcta");
                usu.Lose_Bonus_Game();
            }
            Thread.Sleep(1500);
            Console.Clear();
        }


        public List<Canciones> Get_ListaCanciones()
        {
            return Lista_canciones;
        }

        public List<Video> Get_ListaVideos()
        {
            return Lista_videos;
        }



        public List<Usuario> Get_Usuarios()
        {
            return Usuario;
        }

        public List<Video> Get_Cola_Reproduccion_Video()
        {
            return Cola_reproduccion_videos;
        }

        public List<Canciones> Get_Cola_Reproduccion_Canciones()
        {
            return Cola_reproduccion_canciones;
        }

        public List<Playlist> Get_Playlist()
        {
            return Playlist_multimedia;
        }

        public List<Personas> Get_Personas()
        {
            return Persona;
        }
        public int comprobarusuario(string nom, string contra)
        {
            for (int i = 0; i < Usuario.Count(); i++)
            {
                if (Usuario[i].Get_Nickname() == nom && Usuario[i].Get_Password() == contra)
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
            formatter3.Serialize(stream, Get_ListaCanciones().Count());
            for (int i = 0; i < Get_ListaCanciones().Count(); i++)
            {
                formatter3.Serialize(stream, Get_ListaCanciones()[i]);
            }
            stream.Close();
            formatter3.Serialize(stream5, Get_ListaVideos().Count());
            for (int i = 0; i < Get_ListaVideos().Count(); i++)
            {
                formatter3.Serialize(stream5, Get_ListaVideos()[i]);
            }
            stream5.Close();
            formatter3.Serialize(stream6, Get_Usuarios().Count());
            for (int i = 0; i < Get_Usuarios().Count(); i++)
            {
                formatter3.Serialize(stream6, Get_Usuarios()[i]);
            }
            stream6.Close();
            formatter3.Serialize(stream8, Get_Playlist().Count());
            for (int i = 0; i < Get_Playlist().Count(); i++)
            {
                formatter3.Serialize(stream8, Get_Playlist()[i]);
            }
            stream8.Close();
        }
    }
}
