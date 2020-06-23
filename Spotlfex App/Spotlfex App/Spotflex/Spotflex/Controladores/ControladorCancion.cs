using Spotflex.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Spotflex.Controladores
{
    [Serializable()]
    class ControladorCancion
    {
        List<Canciones> lista_canciones = new List<Canciones>();
        Form1 appform;
        ControladorPersona controlador;
        ControladorUsuario ctrl_usu;
        List<Canciones> cola_reproduccion_canciones = new List<Canciones>();

        public delegate Usuario GetUsuarioEventHandler(object source, LoginEventArgs e);
        public GetUsuarioEventHandler GetMusicUser;

        public ControladorCancion(Form appform, ControladorPersona controlador)
        {
            InicioCanciones();
            this.appform = appform as Form1;
            this.controlador = controlador as ControladorPersona;
            this.ctrl_usu = ctrl_usu as ControladorUsuario;
            this.appform.AddSongToData += OnAddSongToData;
            this.appform.GetDataSongs += OnGetDataSongs;
            this.appform.ShowInfoCancion += OnShowInfoCancion;
            this.appform.ReproducirCancion += OnReproducirCancion;
            this.appform.DownloadSong += OnDownloadSong;
            this.appform.RankedSong += OnRankedSong;
            this.appform.AddFavoriteSong += OnGetSong;
            this.appform.AddColaSong += OnGetSong;
            this.appform.PutColaCancion += OnAddtoCola;
            this.appform.RemoveSong += OnRemoveSong;
            this.appform.CommentAdded += OnCommentAdded;
            this.appform.GetUserComent += OnGetComentarios;
            this.appform.GetUserNickComent += OnGetUsuariosComentan;
            this.appform.GetUserPhotoComent += OnGetFotoUsuariosComentan;
            this.appform.GeneralFindSong += OnGeneralSongSearch;
            this.appform.OrSearchMusic += OnOrSongSearch;
            this.appform.AndSearchMusic += OnAndSongSearch;
            this.appform.SaveData += OnSaveData;
            this.controlador.GetMySongs += OnGetMySongs;
            this.appform.GetAllSongs += OnGetAllSongs;
            this.appform.GetRankingSongs += OnGetRankingSongs;
            this.appform.GetSong += OnGetSong;
            this.appform.OnChangingAllData += OnChangingAllData;
            this.appform.ChangedPhoto += OnChangedPhotoComent;
            this.appform.CheckWin += OnCheckWin;
            this.appform.RandomSong += OnRandomSong;
            this.appform.GetHint += OnGetPista;
        }

        private Canciones OnAddSongToData(object source, AddSongUserDataEventArgs e) {
            Canciones cancion = new Canciones(e.Duracion, e.Titulo, e.Fecha_Inclusion, e.Size, e.Estudio,
                e.Song_Path, e.Fecha_Publicacion, e.Descripcion, e.Portada_Path, 0,new List<Usuario>(),
                new List<Usuario>(), new List<string>(), new List<int>(), e.Generos, new List<Usuario>(), e.Letra, e.Album, e.Staff);
            lista_canciones.Add(cancion);
            OnSaveData(appform, new EventArgs());
            return cancion;
        }
        private void InicioCanciones()
        {
            string path_canciones = @System.IO.Directory.GetCurrentDirectory() + "\\Canciones.bin";
            if (File.Exists(path_canciones))
            {

                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Canciones.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {

                    int p = (int)formatter2.Deserialize(stream2);

                    for (int i = 0; i < p; i++)
                    {

                        Canciones obj = (Canciones)formatter2.Deserialize(stream2);
                        lista_canciones.Add(obj);

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
                    Stream stream = new FileStream("Canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, lista_canciones.Count());
                    for (int i = 0; i < lista_canciones.Count(); i++)
                    {
                        formatter.Serialize(stream, lista_canciones[i]);

                    }
                    stream.Close();
                }
            }
        }
        public IEnumerable<Canciones> OnGetRankingSongs(object source, AddMultimediaEventArgs e)
        {
            List<Canciones> can = lista_canciones;
            IEnumerable<Canciones> can2 = can.OrderBy(x => x.Get_Mean_Tier());

            return can2.Reverse();
            
        }
        public void OnRemoveSong(object source, AddMultimediaEventArgs e)
        {
            List<Canciones> remover = new List<Canciones>();
            foreach(Canciones item in lista_canciones)
            {
                if(e.Cancion.Titulo == item.Titulo)
                {
                    remover.Add(item);
                }
            }
            foreach (Canciones item in remover)
            {
                lista_canciones.Remove(item);
            }
            OnSaveData(appform, new EventArgs());
        }

        public void OnGetDataSongs(object source, GetMultimediaDataEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                e.name_songs.Add(data.Titulo);
                e.path_songs.Add(data.Portada);
            }
        }

        public void OnShowInfoCancion(object source, AddMultimediaEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    List<string> cantantes = new List<string>();
                    foreach(Personas staff in data.Personas_cancion)
                    {
                        cantantes.Add(staff.Nombre + " " + staff.Apellido);
                    }
                    appform.Informacion_Cancion(data.Titulo, cantantes, data.Genero, data.Album, data.Duracion,
                        data.Estudio, data.Portada, data.Get_Mean_Tier(), data.Numero_reproducciones, data.Descripcion, (data.Size)/1000000, data.Fecha_publicacion);
                }
            }
        }

        public string OnReproducirCancion(object source, AddMultimediaEventArgs e)
        {
            cola_reproduccion_canciones.Clear();
            foreach(Canciones data in lista_canciones)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    cola_reproduccion_canciones.Add(data);
                    data.Numero_reproducciones++;
                    OnShowInfoCancion(appform, new AddMultimediaEventArgs() { name_multimedia_file = data.Titulo });
                    OnSaveData(appform, new EventArgs());
                    return data.Carpeta_archivo;
                }
            }
            return "";
        }

        public void OnDownloadSong(object source, AddMultimediaEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    data.Descargar_Cancion();
                }
            }
        }
      
        public void OnRankedSong(object source, AddMultimediaEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    int verificador = 1;
                    int index = 0;
                    int index_start = 0;
                    foreach(Usuario data2 in data.Usuarios_califican)
                    {
                        if(data2.Nickname == e.user)
                        {
                            verificador = 0;
                            index = index_start;
                        }
                        index_start++;
                    }
                    if (verificador == 1) {
                        data.Ranked(e.rank);
                        Usuario user_califica = GetMusicUser(appform, new LoginEventArgs() { Nickname = e.user });
                        data.Usuarios_califican.Add(user_califica);
                    }
                    else
                    {
                        data.Ranking[index] = e.rank;
                    }
                    OnShowInfoCancion(appform, new AddMultimediaEventArgs() { name_multimedia_file = data.Titulo }); 
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public void OnOrSongSearch(object source, DetailSearchEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                int verificador = 0;
                foreach (string data2 in e.nombres_claves)
                {
                    if (data.Descripcion.ToUpper().Contains(data2.ToUpper()) && data2 != "")
                    {
                        verificador = 1;
                    }
                }
                foreach (string data2 in e.personas_claves)
                {
                    foreach (Personas data3 in data.Personas_cancion)
                    {
                        if ((data3.Nombre.ToUpper().Contains(data2.ToUpper()) || data3.Apellido.ToUpper().Contains(data2.ToUpper())) && data2 != "")
                        {
                            verificador = 1;
                        }
                    }
                }
                foreach (Personas data2 in data.Personas_cancion)
                {
                    if (e.edad_condition == 0)
                    {
                        if (e.edad_clave == data2.Edad && e.edad_clave != -1)
                        {
                            verificador = 1;
                        }
                    }
                    else if (e.edad_condition == 1)
                    {
                        if (e.edad_clave <= data2.Edad && e.edad_clave != -1)
                        {
                            verificador = 1;
                        }
                    }
                    else
                    {
                        if (e.edad_clave >= data2.Edad && e.edad_clave != -1)
                        {
                            verificador = 1;
                        }
                    }
                }
                foreach (Personas data2 in data.Personas_cancion)
                {
                    if (data2.Sexo == e.genero_clave && e.genero_clave != "")
                    {
                        verificador = 1;
                    }
                }
                if (e.duration_condition == 0)
                {
                    if (e.duration == data.Duracion && e.duration != -1)
                    {
                        verificador = 1;
                    }
                }
                else if (e.duration_condition == 1 && e.duration != -1)
                {
                    if (e.duration <= data.Duracion)
                    {
                        verificador = 1;
                    }
                }
                else
                {
                    if (e.duration >= data.Duracion && e.duration != -1)
                    {
                        verificador = 1;
                    }
                }
                if (e.ranking_condition == 0)
                {
                    if (e.ranking == data.Get_Mean_Tier() && e.ranking != -1)
                    {
                        verificador = 1;
                    }
                }
                else if (e.ranking_condition == 1 && e.ranking != -1)
                {
                    if (e.ranking <= data.Get_Mean_Tier())
                    {
                        verificador = 1;
                    }
                }
                else
                {
                    if (e.ranking >= data.Get_Mean_Tier() && e.ranking != -1)
                    {
                        verificador = 1;
                    }
                }
                foreach (string data2 in e.categorias_clave)
                {
                    foreach (string data3 in data.Genero)
                    {
                        if (data3.ToUpper().Contains(data2.ToUpper()) && data2 != "")
                        {
                            verificador = 1;
                        }
                    }
                }
                if (verificador == 1)
                {
                    e.titulos_encontrados.Add(data.Titulo);
                    e.fotos_encontradas.Add(data.Portada);
                }

            }
        }

        public void OnAndSongSearch(object sender, DetailSearchEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                int verificador = 1;
                foreach (string data2 in e.nombres_claves)
                {
                    if (!data.Descripcion.ToUpper().Contains(data2.ToUpper()) && data2 != "")
                    {
                        verificador = 0;
                    }
                }
                foreach (string data2 in e.personas_claves)
                {
                    foreach (Personas data3 in data.Personas_cancion)
                    {
                        if (!(data3.Nombre.ToUpper().Contains(data2.ToUpper()) || data3.Apellido.ToUpper().Contains(data2.ToUpper())) && data2 != "")
                        {
                            verificador = 0;
                        }
                    }
                }
                int ver_edad = 0;
                foreach (Personas data2 in data.Personas_cancion)
                {
                    if (e.edad_condition == 0)
                    {
                        if (e.edad_clave == data2.Edad)
                        {
                            ver_edad = 1;
                        }
                    }
                    else if (e.edad_condition == 1)
                    {
                        if (e.edad_clave <= data2.Edad)
                        {
                            ver_edad = 1;
                        }
                    }
                    else
                    {
                        if (e.edad_clave >= data2.Edad )
                        {
                            ver_edad = 1;
                        }
                    }
                }
                if (ver_edad == 0 && e.edad_clave != -1)
                {
                    verificador = 0;
                }
                int verificador2 = 0;
                foreach (Personas data2 in data.Personas_cancion)
                {
                    if (data2.Sexo == e.genero_clave)
                    {
                        verificador2 = 1;
                    }
                }
                if (verificador2 == 0 && e.genero_clave != "")
                {
                    verificador = 0;
                }
                verificador2 = 0;
                if (e.duration_condition == 0)
                {
                    if (e.duration == data.Duracion)
                    {
                        verificador2 = 1;
                    }
                }
                else if (e.duration_condition == 1)
                {
                    if (e.duration <= data.Duracion)
                    {
                        verificador2 = 1;
                    }
                }
                else
                {
                    if (e.duration >= data.Duracion )
                    {
                        verificador2 = 1;
                    }
                }
                if(verificador2 == 0 && e.duration != -1)
                {
                    verificador = 0;
                }
                verificador2 = 0;
                if (e.ranking_condition == 0)
                {
                    if (e.ranking == data.Get_Mean_Tier())
                    {
                        verificador2 = 1;
                    }
                }
                else if (e.ranking_condition == 1)
                {
                    if (e.ranking <= data.Get_Mean_Tier())
                    {
                        verificador2 = 1;
                    }
                }
                else
                {
                    if (e.ranking >= data.Get_Mean_Tier())
                    {
                        verificador2 = 1;
                    }
                }
                if (verificador2 == 0 && e.ranking != -1)
                {
                    verificador = 0;
                }
                foreach (string data2 in e.categorias_clave)
                {
                    foreach (string data3 in data.Genero)
                    {
                        if (!(data3.ToUpper().Contains(data2.ToUpper())) && data3 != "")
                        {
                            verificador = 0;
                        }
                    }
                }
                if (verificador == 1)
                {
                    e.titulos_encontrados.Add(data.Titulo);
                    e.fotos_encontradas.Add(data.Portada);
                }

            }
        }

        public Canciones OnGetSong(object source, AddMultimediaEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    return data;
                }
            }
            return new Canciones(0, "", "", 0, "", "", "", "", "", 0, new List<Usuario>(), new List<Usuario>(), new List<string>(), new List<int>(), new List<string>(), new List<Usuario>(), "", "", new List<Personas>());
        }


        public void OnAddtoCola(object source, AddMultimediaEventArgs e)
        {
            cola_reproduccion_canciones.Add(e.Cancion);
            OnSaveData(appform, new EventArgs());
        }

        public void OnCommentAdded(object source, AddComentarioEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    data.Usuarios_comentan.Add(e.user);
                    data.Comentarios.Add(e.comentario);
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public List<string> OnGetUsuariosComentan(object source, AddComentarioEventArgs e)
        {
            List<string> usuarios_comentan = new List<string>();
            foreach (Canciones data in lista_canciones)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    for(int i = 0; i < data.Usuarios_comentan.Count(); i++)
                    {
                        usuarios_comentan.Add(data.Usuarios_comentan[i].Nickname);
                    }
                }
            }
            return usuarios_comentan;
        }

        public List<string> OnGetComentarios(object source, AddComentarioEventArgs e)
        {
            foreach (Canciones data in lista_canciones)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    return data.Comentarios;
                }
            }
            return new List<string>();
        }

        public List<string> OnGetFotoUsuariosComentan(object source, AddComentarioEventArgs e)
        {
            List<string> usuarios_comentan = new List<string>();
            foreach (Canciones data in lista_canciones)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    for (int i = 0; i < data.Usuarios_comentan.Count(); i++)
                    {
                        usuarios_comentan.Add(data.Usuarios_comentan[i].Fotoperfil);
                    }
                }
            }
            return usuarios_comentan;
        }

        public List<Canciones> OnGetMySongs(object source, GetMySongsandVideoEventArgs e)
        {
            List<Canciones> mysong = new List<Canciones>();
            foreach (Canciones data in lista_canciones)
            {
                foreach(Personas data2 in data.Personas_cancion)
                {
                    if (data2.Nombre == e.artista)
                    {
                        mysong.Add(data);
                    }
                }
            }
            return mysong;
        }
        public List<Canciones> OnGetAllSongs(object source, GetMultimediaDataEventArgs e)
        {
            return lista_canciones;
        }


        public void OnGeneralSongSearch(object source, SearchDataEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                if (data.Titulo.ToUpper().Contains(e.palabra_clave.ToUpper()))
                {
                    e.nombre_buscado.Add(data.Titulo);
                    e.fotos_buscadas.Add(data.Portada);
                }
            }
        }

        public void OnChangingAllData(object source, ChangeUserDataEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                foreach (Usuario data2 in data.Usuarios_comentan)
                {
                    if(data2.Nickname == e.OldNickname)
                    {
                        data2.Nickname = e.Nickname;
                    }
                }
                foreach (Usuario data2 in data.Usuarios_califican)
                {
                    if (data2.Nickname == e.OldNickname)
                    {
                        data2.Nickname = e.Nickname;
                    }
                }
            }
        }

        public void OnChangedPhotoComent(object source, ChangePhotoEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                foreach(Usuario data2 in data.Usuarios_comentan)
                {
                    if(data2.Nickname == e.Nickname)
                    {
                        data2.Fotoperfil = e.PhotoFile;
                    }
                }
            }
        }

        public bool OnCheckWin(object source, BonusGameEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                if (data.Carpeta_archivo == e.song_url && data.Titulo == e.name_song)
                {
                    return true;
                }
            }
            return false;
        }

        public string OnRandomSong(object source, EventArgs e)
        {
            Random rand = new Random();
            int can_rand = rand.Next(0, lista_canciones.Count());
            return lista_canciones[can_rand].Carpeta_archivo;
        }

        public string OnGetPista(object source, AddMultimediaEventArgs e)
        {
            foreach(Canciones data in lista_canciones)
            {
                if(data.Carpeta_archivo == e.name_multimedia_file)
                {
                    return data.Letra;
                }
            }
            return "";
        }

        public void OnSaveData(object source, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream2 = new FileStream("Canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream2, lista_canciones.Count());
            for (int i = 0; i < lista_canciones.Count(); i++)
            {
                formatter.Serialize(stream2, lista_canciones[i]);
            }
            stream2.Close();
        }


    }
}
