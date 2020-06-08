using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Spotflex.Eventos;

namespace Spotflex.Controladores
{
    [Serializable()]
    class ControladorPersona
    {
        List<Personas> personas = new List<Personas>();
        Form1 appform;

        public delegate List<Canciones> GetMySongsEventHandler(object source, GetMySongsandVideoEventArgs args);
        public event GetMySongsEventHandler GetMySongs;
        public delegate List<Video> GetMyVideoEventHandler(object source, GetMySongsandVideoEventArgs args);
        public event GetMyVideoEventHandler GetMyVideos;
        public delegate List<Usuario> GetUsersEventHandler(object source, EventArgs args);
        public event GetUsersEventHandler GetUsers;

        public ControladorPersona(Form appform)
        {
            InicioPersona();
            this.appform = appform as Form1;
            this.appform.AddPersonasCancion += OnAddPersonasCancion;
            this.appform.AddPersonasVideo += OnAddPersonasVideo;
            this.appform.SaveData += OnSaveData;
            this.appform.GeneralFindPerson += OnGeneralPeopleSearch;
            this.appform.SearchedPersonInfo += OnSearchedPersonInfo;
            this.appform.CanFollowPerson += OnCanFollowPerson;
            this.appform.FollowPerson += OnFollowPerson;
        }

        private List<Personas> OnAddPersonasCancion(object sender, Eventos.AddSongUserDataEventArgs e)
        {
            List<Personas> artists = new List<Personas>();
            for(int i = 0; i < e.Nombre_Artistas.Count(); i++)
            {
                string[] name_data = e.Nombre_Artistas[i].Split(' ');
                List<string> name_andlastname = name_data.ToList<string>();
                if (name_andlastname.Count() == 1)
                {
                    Personas persona = new Personas(name_andlastname[0], "", e.Genero_Artistas[i], "Cantante", e.Edad_Artistas[i], new List<Usuario>());
                    personas.Add(persona);
                    artists.Add(persona);
                }
                else
                {
                    Personas persona = new Personas(name_andlastname[0], name_andlastname[1], e.Genero_Artistas[i], "Cantante", e.Edad_Artistas[i], new List<Usuario>());
                    personas.Add(persona);
                    artists.Add(persona);
                }
            }
            OnSaveData(appform, new EventArgs());
            return artists;
        }

        private List<Personas> OnAddPersonasVideo(object sender, Eventos.AddVideoUserDataEventArgs e)
        {
            List<Personas> staff = new List<Personas>();
            for (int i = 0; i < e.Nombre_Director.Count(); i++)
            {
                string[] name_data = e.Nombre_Director[i].Split(' ');
                List<string> name_andlastname = name_data.ToList<string>();
                if (name_andlastname.Count() == 1)
                {
                    Personas persona = new Personas(name_andlastname[0], "", e.Genero_Director[i], "Director", e.Edad_Director[i], new List<Usuario>());
                    personas.Add(persona);
                    staff.Add(persona);
                }
                else
                {
                    Personas persona = new Personas(name_andlastname[0], name_andlastname[1], e.Genero_Director[i], "Director", e.Edad_Director[i], new List<Usuario>());
                    personas.Add(persona);
                    staff.Add(persona);
                }
            }
            for (int i = 0; i < e.Nombre_Actor.Count(); i++)
            {
                string[] name_data = e.Nombre_Actor[i].Split(' ');
                List<string> name_andlastname = name_data.ToList<string>();
                if (name_andlastname.Count() == 1)
                {
                    Personas persona = new Personas(name_andlastname[0], "", e.Genero_Actor[i], "Actor", e.Edad_Actor[i], new List<Usuario>());
                    personas.Add(persona);
                    staff.Add(persona);
                }
                else
                {
                    Personas persona = new Personas(name_andlastname[0], name_andlastname[1], e.Genero_Actor[i], "Actor", e.Edad_Actor[i], new List<Usuario>());
                    personas.Add(persona);
                    staff.Add(persona);
                }
            }
            OnSaveData(appform, new EventArgs());

            return staff;
        }
        private void InicioPersona()
        {
            string path_personas = @System.IO.Directory.GetCurrentDirectory() + "\\Personas.bin";
            if (File.Exists(path_personas))
            {

                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Personas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {

                    int p = (int)formatter2.Deserialize(stream2);

                    for (int i = 0; i < p; i++)
                    {

                        Personas obj = (Personas)formatter2.Deserialize(stream2);
                        personas.Add(obj);

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    stream2.Close();
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("Personas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, personas.Count());
                    for (int i = 0; i < personas.Count(); i++)
                    {
                        formatter.Serialize(stream, personas[i]);

                    }
                    stream.Close();
                }

            }
        }

        public bool OnCanFollowPerson(object sender, FollowEventArgs e)
        {
            foreach (Personas data in personas)
            {
                string[] lista_nombre = e.user_following.Split(' ');
                if (lista_nombre[0] == data.Nombre && lista_nombre[1] == data.Apellido)
                {
                    foreach (Usuario data2 in data.Seguidores)
                    {
                        if (data2.Nickname == e.user_new_follower)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void OnFollowPerson(object sender, FollowEventArgs e)
        {
            foreach (Personas data in personas)
            {
                string[] lista_nombre = e.user_following.Split(' ');
                if (lista_nombre[0] == data.Nombre && lista_nombre[1] == data.Apellido)
                {
                    List<Usuario> users = GetUsers(this, new EventArgs());
                    foreach (Usuario data2 in users)
                    {
                        if (data2.Nickname == e.user_new_follower)
                        {
                            data.Seguidores.Add(data2);
                            OnSearchedPersonInfo(appform, new LoginEventArgs() { Nickname = data.Nombre + " " + data.Apellido });
                            OnSaveData(appform, new EventArgs());
                        }
                    }
                }
            }
        }

        public void OnGeneralPeopleSearch(object source, SearchDataEventArgs e)
        {
            foreach(Personas data in personas)
            {
                if(data.Nombre.ToUpper().Contains(e.palabra_clave.ToUpper()) || data.Apellido.ToUpper().Contains(e.palabra_clave.ToUpper()))
                {
                    e.nombre_buscado.Add(data.Nombre + " " + data.Apellido);
                }
            }
        }

        public void OnSearchedPersonInfo(object source, LoginEventArgs e)
        {
            foreach(Personas data in personas)
            {
                string[] lista_nombre = e.Nickname.Split(' ');
                if(lista_nombre[0] == data.Nombre && lista_nombre[1] == data.Apellido)
                {
                    List<string> nombres_canciones_subidas = new List<string>();
                    List<string> fotos_canciones_subidas = new List<string>();
                    List<string> nombres_videos_subidos = new List<string>();
                    List<string> fotos_videos_subidos = new List<string>();
                    List<Canciones> mis_canciones = GetMySongs(this, new GetMySongsandVideoEventArgs() { artista = data.Nombre });
                    List<Video> mis_videos = GetMyVideos(this, new GetMySongsandVideoEventArgs() { artista = data.Nombre });
                    foreach(Canciones data2 in mis_canciones)
                    {
                        nombres_canciones_subidas.Add(data2.Titulo);
                        fotos_canciones_subidas.Add(data2.Portada);
                    }
                    foreach (Video data2 in mis_videos)
                    {
                        nombres_videos_subidos.Add(data2.Titulo);
                        fotos_videos_subidos.Add(data2.Portada);
                    }
                    appform.ShowSearchedPersona(data.Nombre + " " + data.Apellido, data.Puesto_de_trabajo, data.Edad, data.Seguidores.Count(), fotos_canciones_subidas,
                        nombres_canciones_subidas, fotos_videos_subidos, nombres_videos_subidos);
                }
            }
        }
        public void OnSaveData(object source, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Personas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, personas.Count());
            for (int i = 0; i < personas.Count(); i++)
            {
                formatter.Serialize(stream, personas[i]);
            }
            stream.Close();
        }
    }
}
