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
    class ControladorVideo
    {
        List<Video> Lista_video = new List<Video>();
        Form1 appform;
        List<Video> cola_reproduccion_Video = new List<Video>();
        ControladorPersona controlador;

        public delegate Usuario GetUsuarioEventHandler(object source, Eventos.LoginEventArgs e);
        public GetUsuarioEventHandler GetVideoUser;

        public ControladorVideo(Form appform, ControladorPersona controlador)
        {
            InicioVideo();
            this.appform = appform as Form1;
            this.controlador = controlador as ControladorPersona;
            this.appform.AddVidToData += OnAddVideoToData;
            this.appform.GetDataVideo += OnGetDataVideo;
            this.appform.SaveData += OnSaveData;
            this.appform.GeneralFindVideo += OnSearchGeneralVideo;
            this.appform.ReproducirVideo += OnReproducirVideo;
            this.appform.ShowInfoVideo += OnShowInfoVideo;
            this.controlador.GetMyVideos += OnGetMyVideos;
            this.appform.RemoveVideo += OnRemoveVideo;
            this.appform.OrSearchVideo += OnOrVideoSearch;
            this.appform.AndSearchVideo += OnAndVideoSearch;
            this.appform.RankedVideo += OnRankedVideo;
            this.appform.GetAllVideos += OnGetAllVideos;
            this.appform.AddFavoriteVideo += OnGetVideo;
            this.appform.GetUserNickComentVideo += OnGetUsuariosComentan;
            this.appform.GetUserPhotoComentVideo += OnGetFotoUsuariosComentan;
            this.appform.GetUserComentVideo += OnGetComentarios;
            this.appform.CommentAddedVideo += OnCommentAdded;
            this.appform.GetVideo += OnGetVideo;
            this.appform.GetRankingVideo += OnGetRankingVideo;
            this.appform.OnChangingAllData += OnChangingAllData;
            this.appform.ChangedPhoto += OnChangedPhotoComent;
        }

        private Video  OnAddVideoToData(object source, Eventos.AddVideoUserDataEventArgs e)
        {
            Video video = new Video(e.Duracion, e.Titulo, e.Fecha_Inclusion, e.Size, e.Estudio,
            e.Video_Path, e.Fecha_Publicacion, e.Descripcion, e.Portada_Path, 0, new List<Usuario>(), new List<Usuario>(),
            new List<string>(), new List<int>(), e.Generos, new List<Usuario>(), e.Calidad, e.Staff);

            Lista_video.Add(video);
            OnSaveData(appform, new EventArgs());
                
            return video;
        }

        private void InicioVideo()
        {
            string path_video = @System.IO.Directory.GetCurrentDirectory() + "\\Videos.bin";
            if (File.Exists(path_video))
            {

                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Videos.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {

                    int p = (int)formatter2.Deserialize(stream2);

                    for (int i = 0; i < p; i++)
                    {

                        Video obj = (Video)formatter2.Deserialize(stream2);
                        Lista_video.Add(obj);

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
                    Stream stream = new FileStream("Videos.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, Lista_video.Count());
                    for (int i = 0; i < Lista_video.Count(); i++)
                    {
                        formatter.Serialize(stream, Lista_video[i]);

                    }
                    stream.Close();
                }

            }


        }

        public void OnGetDataVideo(object source, Eventos.GetMultimediaDataEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                e.name_videos.Add(data.Titulo);
                e.path_videos.Add(data.Portada);
            }
        }
        public IEnumerable<Video> OnGetRankingVideo(object source, Eventos.GetMultimediaDataEventArgs e)
        {
            List<Video> vid = Lista_video;
            IEnumerable<Video> vid2  = vid.OrderBy(x => x.Get_Mean_Tier());
            return vid2.Reverse();

        }

        public List<Video> OnGetMyVideos(object source, Eventos.GetMySongsandVideoEventArgs e)
        {
            List<Video> myvideo = new List<Video>();
            foreach (Video data in Lista_video)
            {
                foreach (Personas data2 in data.Persona_video)
                {
                    if (data2.Nombre == e.artista)
                    {
                        myvideo.Add(data);
                    }
                }
            }
            return myvideo;
        }
        public List<Video> OnGetAllVideos(object source, Eventos.GetMultimediaDataEventArgs e)
        {
            return Lista_video;
        }

        public void OnSearchGeneralVideo(object source, Eventos.SearchDataEventArgs e)
        {
            foreach(Video data in Lista_video)
            {
                if (data.Titulo.ToUpper().Contains(e.palabra_clave.ToUpper()))
                {
                    e.nombre_buscado.Add(data.Titulo);
                    e.fotos_buscadas.Add(data.Portada);
                }
            }
        }

        public void OnOrVideoSearch(object source, Eventos.DetailSearchEventArgs e)
        {
            foreach (Video data in Lista_video)
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
                    foreach (Personas data3 in data.Persona_video)
                    {
                        if ((data3.Nombre.ToUpper().Contains(data2.ToUpper()) || data3.Apellido.ToUpper().Contains(data2.ToUpper())) && data2 != "")
                        {
                            verificador = 1;
                        }
                    }
                }
                foreach (Personas data2 in data.Persona_video)
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
                foreach (Personas data2 in data.Persona_video)
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
                else if (e.duration_condition == 1)
                {
                    if (e.duration <= data.Duracion && e.duration != -1)
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
                if (e.calidad_condition == 0)
                {
                    if (e.calidad == data.Calidad && e.calidad != -1)
                    {
                        verificador = 1;
                    }
                }
                else if (e.calidad_condition == 1)
                {
                    if (e.calidad <= data.Calidad && e.calidad != -1)
                    {
                        verificador = 1;
                    }
                }
                else
                {
                    if (e.calidad >= data.Calidad && e.calidad != -1)
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

        public void OnAndVideoSearch(object sender, Eventos.DetailSearchEventArgs e)
        {
            foreach (Video data in Lista_video)
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
                    foreach (Personas data3 in data.Persona_video)
                    {
                        if (!(data3.Nombre.ToUpper().Contains(data2.ToUpper()) || data3.Apellido.ToUpper().Contains(data2.ToUpper())) && data2 != "")
                        {
                            verificador = 0;
                        }
                    }
                }
                int ver_edad = 0;
                foreach (Personas data2 in data.Persona_video)
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
                        if (e.edad_clave >= data2.Edad)
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
                foreach (Personas data2 in data.Persona_video)
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
                    if (e.duration >= data.Duracion)
                    {
                        verificador2 = 1;
                    }
                }
                if (verificador2 == 0 && e.duration != -1)
                {
                    verificador = 0;
                }
                verificador2 = 0;
                if (e.calidad_condition == 0)
                {
                    if (e.calidad == data.Calidad)
                    {
                        verificador2 = 1;
                    }
                }
                else if (e.calidad_condition == 1)
                {
                    if (e.calidad <= data.Calidad)
                    {
                        verificador2 = 1;
                    }
                }
                else
                {
                    if (e.calidad >= data.Calidad)
                    {
                        verificador2 = 1;
                    }
                }
                if(verificador2 == 0 && e.calidad != -1)
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
                        if (!(data3.ToUpper().Contains(data2.ToUpper())) && data2 != "")
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
        public void OnSaveData(object source, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Videos.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Lista_video.Count());
            for (int i = 0; i < Lista_video.Count(); i++)
            {
                formatter.Serialize(stream, Lista_video[i]);
            }
            stream.Close();
        }

        public void OnShowInfoVideo(object source, Eventos.AddMultimediaEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    List<string> directores = new List<string>();
                    List<string> actores = new List<string>();
                    foreach (Personas staff in data.Persona_video)
                    {
                        if (staff.Puesto_de_trabajo == "Director")
                        {
                            directores.Add(staff.Nombre + " " + staff.Apellido);
                        }
                    }
                    foreach (Personas staff in data.Persona_video)
                    {
                        if (staff.Puesto_de_trabajo == "Actor")
                        {
                            actores.Add(staff.Nombre + " " + staff.Apellido);
                        }
                    }
                    appform.Informacion_video(data.Titulo, directores, actores,data.Genero, data.Duracion,
                        data.Estudio, data.Portada, data.Get_Mean_Tier(), data.Numero_reproducciones, data.Descripcion,data.Fecha_publicacion);
                }
            }
        }


        public string OnReproducirVideo(object source, Eventos.AddMultimediaEventArgs e)
        {
            cola_reproduccion_Video.Clear();
            foreach (Video data in Lista_video)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    cola_reproduccion_Video.Add(data);
                    data.Numero_reproducciones++;
                    OnShowInfoVideo(appform, new Eventos.AddMultimediaEventArgs() { name_multimedia_file = data.Titulo });
                    OnSaveData(appform, new EventArgs());
                    return data.Carpeta_archivo;
                }
            }
            return "";
        }
        public void OnRemoveVideo(object source, Eventos.AddMultimediaEventArgs e)
        {
            List<Video> remover = new List<Video>();
            foreach (Video item in Lista_video)
            {
                if (e.Video.Titulo == item.Titulo)
                {
                    remover.Add(item);
                }
            }
            foreach (Video item in remover)
            {
                Lista_video.Remove(item);
            }
            OnSaveData(appform, new EventArgs());
        }

        public void OnRankedVideo(object source, Eventos.AddMultimediaEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    int verificador = 1;
                    int index = 0;
                    int index_start = 0;
                    foreach (Usuario data2 in data.Usuarios_califican)
                    {
                        if (data2.Nickname == e.user)
                        {
                            verificador = 0;
                            index = index_start;
                        }
                        index_start++;
                    }
                    if (verificador == 1)
                    {
                        data.Ranked(e.rank);
                        Usuario user_califica = GetVideoUser(appform, new Eventos.LoginEventArgs() { Nickname = e.user });
                        data.Usuarios_califican.Add(user_califica);
                    }
                    else
                    {
                        data.Ranking[index] = e.rank;
                    }
                    OnShowInfoVideo(appform, new Eventos.AddMultimediaEventArgs() { name_multimedia_file = data.Titulo });
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public Video OnGetVideo(object source, Eventos.AddMultimediaEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                if (e.name_multimedia_file == data.Titulo)
                {
                    return data;
                }
            }
            return new Video(0, "", "", 0, "", "", "", "", "", 0, new List<Usuario>(), new List<Usuario>(), new List<string>(), new List<int>(), new List<string>(), new List<Usuario>(), 0, new List<Personas>());
        }


        public List<string> OnGetUsuariosComentan(object source, Eventos.AddComentarioEventArgs e)
        {
            List<string> usuarios_comentan = new List<string>();
            foreach (Video data in Lista_video)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    for (int i = 0; i < data.Usuarios_comentan.Count(); i++)
                    {
                        usuarios_comentan.Add(data.Usuarios_comentan[i].Nickname);
                    }
                }
            }
            return usuarios_comentan;
        }

        public List<string> OnGetFotoUsuariosComentan(object source, Eventos.AddComentarioEventArgs e)
        {
            List<string> usuarios_comentan = new List<string>();
            foreach (Video data in Lista_video)
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
        public List<string> OnGetComentarios(object source, Eventos.AddComentarioEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    return data.Comentarios;
                }
            }
            return new List<string>();
        }
        public void OnCommentAdded(object source, Eventos.AddComentarioEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                if (data.Titulo == e.Multimedia_Name)
                {
                    data.Usuarios_comentan.Add(e.user);
                    data.Comentarios.Add(e.comentario);
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public void OnChangedPhotoComent(object source, Eventos.ChangePhotoEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                foreach (Usuario data2 in data.Usuarios_comentan)
                {
                    if (data2.Nickname == e.Nickname)
                    {
                        data2.Fotoperfil = e.PhotoFile;
                    }
                }
            }
        }

        public void OnChangingAllData(object source, Eventos.ChangeUserDataEventArgs e)
        {
            foreach (Video data in Lista_video)
            {
                foreach (Usuario data2 in data.Usuarios_comentan)
                {
                    if (data2.Nickname == e.OldNickname)
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
    }
}
