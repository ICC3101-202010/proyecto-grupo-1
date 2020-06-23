using Spotflex.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Spotflex.Controladores
{
    [Serializable()]
    class ControladorUsuario
    {
        List<Usuario> usuarios = new List<Usuario>(); //Cada controlador conoce a todos sus objetos
        Form1 appform;
        ControladorPersona controlador;
        ControladorCancion control_cancion;
        ControladorVideo control_video;

        public ControladorUsuario(Form appform, ControladorPersona controlador, ControladorCancion control_cancion, ControladorVideo control_video)
        {
            InicioUsuario();
            this.appform = appform as Form1;
            this.controlador = controlador as ControladorPersona;
            this.control_cancion = control_cancion as ControladorCancion;
            this.control_video = control_video as ControladorVideo;
            this.appform.LoginButtonClicked += OnLoginButtonClicked; //Suscribiremos al controlador con su funcion respectiva al evento de login
            this.appform.RegisterButtonClicked += OnRegisterButtonClicked;
            this.appform.UserInfo += OnUserInfo;
            this.appform.UserCompleteInfo += OnUserCompleteInfo;
            this.appform.ChangedPhoto += OnPhotoChanged;
            this.appform.ChangeUserData += OnChangeUserData;
            this.appform.PrivateChanged += OnPrivateChanged;
            this.appform.PremiumChanged += OnPremiumChanged;
            this.appform.EraseUser += OnEraseUser;
            this.appform.CanAddSong += OnCanAddSong;
            this.appform.CanAddVideo += OnCanAddVideo;
            this.appform.AddUsuarioCancion += OnAddSongToMyList;
            this.appform.AddUsuarioVideo += OnAddVideoToMyList;
            this.appform.DeleteSong += OnDeleteSong;
            this.appform.DeleteVideo += OnDeleteVideo;
            this.appform.PutFavoriteSong += OnPutFavoriteSong;
            this.appform.CheckedFavorite += OnCheckFavorite;
            this.appform.UsuarioGet += OnGetUsuario;
            this.control_cancion.GetMusicUser += OnGetUsuario;
            this.control_video.GetVideoUser += OnGetUsuario;
            this.appform.GeneralFindUser += OnGeneralUserSearch;
            this.appform.SearchedUserInfo += OnSearchedUserInfo;
            this.appform.CanFollowUser += OnCanFollowUser;
            this.appform.FollowUser += OnFollowUser;
            this.appform.UnfollowUser += OnUnfollowUser;
            this.appform.SaveData += OnSaveData;
            this.controlador.GetUsers += OnGetPlatformUsers;
            this.appform.DetectPrivate += OnDetectPrivate;
            this.appform.DetectPremium += OnDetectPremium;
            this.appform.MyFavs += OnGetMyFavs;
            this.appform.MyRecomendaciones += OnGetMyRecomendaciones;
            this.appform.PutFavoriteVideo += OnPutFavoriteVideo;
            this.appform.RemoveSong += OnRemoveCancionFav;
            this.appform.RemoveVideo += OnRemoveVideoFav;
            this.appform.GetUserPlaylist += OnGetUserPlaylist;
            this.appform.ColaCancion += OnColaCancion;
            this.appform.ColaVideo += OnColaVideo;
            this.appform.GetColaCancion += OnGetColaCancion;
            this.appform.GetColaVideo += OnGetColaVideo;
            this.appform.DeleteFavoriteSong += OnDeleteFavoriteSong;
            this.appform.DeleteFavoriteVideo += OnDeleteFavoriteVideo;
            this.appform.Admin += OnCheckAdmin;
            this.appform.GetUsers += OnGetUsers;
            this.appform.CanPlay += OnCanPlay;
            this.appform.MyLives += OnMyLives;

        }

        public void InicioUsuario()
        {
            //des serializar
            string path_usuario = @System.IO.Directory.GetCurrentDirectory() + "\\Usuarios.bin";
            if (File.Exists(path_usuario))
            {

                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Usuarios.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {

                    int p = (int)formatter2.Deserialize(stream2);

                    for (int i = 0; i < p; i++)
                    {

                        Usuario obj = (Usuario)formatter2.Deserialize(stream2);
                        usuarios.Add(obj);

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
                    Stream stream9 = new FileStream("Usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream9, usuarios.Count());
                    for (int i = 0; i < usuarios.Count(); i++)
                    {
                        formatter.Serialize(stream9, usuarios[i]);

                    }
                    stream9.Close();

                }
            }
            else
            {
                usuarios.Add(new Usuario("Rafa", 21, true, true, "SirCuevas51", "SHREK", true, "", 3,
                    new List<string>(), new List<Personas>(), new List<Canciones>(), new List<Video>(), new List<Multimedia>(),
                    new List<Usuario>(), new List<Canciones>(), new List<Video>(), new List<Playlist>(), new List<Canciones>(),
                    new List<Video>()));
                usuarios.Add(new Usuario("Benja", 21, true, true, "dark", "lol", true, "", 3,
                    new List<string>(), new List<Personas>(), new List<Canciones>(), new List<Video>(), new List<Multimedia>(),
                    new List<Usuario>(), new List<Canciones>(), new List<Video>(), new List<Playlist>(), new List<Canciones>(),
                    new List<Video>()));
                //serializar
                Stream stream4 = new FileStream("Usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream4, usuarios.Count());
                for (int i = 0; i < usuarios.Count(); i++)
                {
                    formatter.Serialize(stream4, usuarios[i]);

                }
                stream4.Close();
            }
        }

        //Metodos relacionados a los eventos
        
        private bool OnLoginButtonClicked(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname && data.Contraseña == e.Password)
                {
                    return true;
                }
            }
            return false;
        }
        private bool OnDetectPrivate(object sender, LoginEventArgs e)
        {
            foreach(Usuario user in usuarios)
            {
                if(user.Nickname == e.Nickname)
                {
                    return user.User_type;
                }
            }
            return false;
        }
        private bool OnDetectPremium(object sender, LoginEventArgs e)
        {
            foreach (Usuario user in usuarios)
            {
                if (user.Nickname == e.Nickname)
                {
                    return user.Premium;
                }
            }
            return false;
        }


        public void OnDeleteSong(object source, LoginEventArgs e)//borra una cancion
        {
            foreach (Usuario us in usuarios)
            {
                if (us.Nickname == e.Nickname)
                {
                    appform.MisCanciones(us.get_Lista_Canciones_Subidas());

                }


            }

        }
        public void OnDeleteVideo(object source, LoginEventArgs e)//borra una cancion
        {
            foreach (Usuario us in usuarios)
            {
                if (us.Nickname == e.Nickname)
                {
                    appform.MisVideos(us.get_Lista_Videos_Subidos());

                }


            }

        }
        public List<Canciones> OnGetColaCancion(object source,LoginEventArgs e)
        {
            foreach(Usuario item in usuarios)
            {
                if(e.Nickname == item.Nickname)
                {
                    List<Canciones> pivote = item.Cola_cancion.GetRange(0, item.Cola_cancion.Count);
                    item.Cola_cancion.RemoveRange(0,item.Cola_cancion.Count);
                    return pivote;
                }
            }
            return null;
        }
        public List<Video> OnGetColaVideo(object source, LoginEventArgs e)
        {
            foreach (Usuario item in usuarios)
            {
                if (e.Nickname == item.Nickname)
                {
                    List<Video> pivote = item.Cola_video.GetRange(0, item.Cola_video.Count);
                    item.Cola_video.RemoveRange(0, item.Cola_video.Count);
                    return pivote;
                }
            }
            return null;
        }

        private bool OnRegisterButtonClicked(object sender, RegisterEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (e.Nickname == data.Nickname)
                {
                    return false;
                }
            }
            usuarios.Add(new Usuario(e.Name, e.Edad, e.Private_User, e.Premium, e.Nickname, e.Password, false, "", 3,
                new List<string>(), new List<Personas>(), new List<Canciones>(), new List<Video>(), new List<Multimedia>(),
                new List<Usuario>(), new List<Canciones>(), new List<Video>(), new List<Playlist>(), new List<Canciones>(),
                    new List<Video>()));
            OnSaveData(appform, new EventArgs());
            return true;
        }

        public void OnGetMyFavs(object sender, AddMultimediaEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if(e.user == data.Nickname)
                {
                    foreach(Canciones cancion in data.Favoritos_canciones)
                    {
                        e.can_favs.Add(cancion.Titulo);
                        e.can_foto_favs.Add(cancion.Portada);
                    }
                    foreach (Video video in data.Favoritos_videos)
                    {
                        e.vid_favs.Add(video.Titulo);
                        e.vid_foto_favs.Add(video.Portada);
                    }

                }
            }
        }

        private void OnUserInfo(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (e.Nickname == data.Nickname)
                {
                    appform.set_profile(data.Nickname, data.Fotoperfil);
                }
            }
        }

        private void OnUserCompleteInfo(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (e.Nickname == data.Nickname)
                {
                    appform.info_user(data.Nombre, data.Edad, data.User_type, data.Premium, data.Usuarios_seguidores.Count());
                }
            }
        }

        private void OnPhotoChanged(object sender, ChangePhotoEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (e.Nickname == data.Nickname)
                {
                    data.AgregarFotoPerfil(e.PhotoFile);
                    appform.set_profile(data.Nickname, data.Fotoperfil);
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public bool OnCheckAdmin(object source, LoginEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if(data.Nickname == e.Nickname)
                {
                    return data.Administrador;
                }
            }
            return false;
        }

        public bool OnChangeUserData(object sender, ChangeUserDataEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (e.OldNickname == data.Nickname)
                {
                    if (e.Nickname != "")
                    {
                        foreach (Usuario data2 in usuarios)
                        {
                            if (data2.Nickname == e.Nickname)
                            {
                                return false;
                            }
                        }
                        data.Cambiar_dato_string(2, e.Nickname);

                    }
                    if (e.Edad != 0)
                    {
                        data.Cambiar_dato_edad(e.Edad);
                    }
                    if (e.Password != "")
                    {
                        data.Cambiar_dato_string(3, e.Password);
                    }
                    if (e.Name != "")
                    {
                        data.Cambiar_dato_string(1, e.Name);
                    }
                    OnSaveData(appform, new EventArgs());
                }
            }
            return true;
        }

        public void OnPrivateChanged(object sender, RegisterEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    if (!e.Private_User == data.User_type)
                    {
                        data.Cambiar_dato_booleano(1);
                        OnSaveData(appform, new EventArgs());
                    }
                }
            }
        }

        public void OnPremiumChanged(object sender, RegisterEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    if (!e.Premium == data.Premium)
                    {
                        data.Cambiar_dato_booleano(2);
                        OnSaveData(appform, new EventArgs());
                    }
                }
            }
        }

        public void OnEraseUser(object sender, LoginEventArgs e)
        {
            for (int i = 0; i < usuarios.Count(); i++)
            {
                if (usuarios[i].Nickname == e.Nickname)
                {
                    usuarios.Remove(usuarios[i]);
                    appform.OnShowUsersBorrar();
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public bool OnCanAddSong(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    if (!data.Premium && data.Canciones_agregadas.Count() >= 5)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool OnCanAddVideo(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    if (!data.Premium && data.Videos_agregados.Count() >= 5)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void OnAddSongToMyList(object sender, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user)
                {
                    data.Add_Song_To_My_List(e.Cancion);
                    OnSaveData(appform, new EventArgs());
                }
            }
        }

        public void OnAddVideoToMyList(object sender, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user)
                {
                    data.Add_Video_To_My_List(e.Video);
                    OnSaveData(appform, new EventArgs());
                }
            }
        }



        public void OnPutFavoriteSong(object sender, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user)
                {
                    int verificador = 1;
                    foreach(Canciones can in data.Favoritos_canciones)
                    {
                        if(can.Titulo == e.Cancion.Titulo)
                        {
                            verificador = 0;
                        }
                    }
                    if (verificador == 1)
                    {
                        data.Favoritos_canciones.Add(e.Cancion);
                        OnSaveData(appform, new EventArgs());
                    }
                }
            }
        }
        private List<Playlist> OnGetUserPlaylist(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    return data.Playlist_agregadas;
                }
            }
            return null;
        }

        public bool OnCheckFavorite(object sender, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user)
                {
                    foreach (Canciones data2 in data.Favoritos_canciones)
                    {
                        if (data2.Titulo == e.name_multimedia_file)
                        {
                            return true;
                        }
                    }
                    foreach (Video data2 in data.Favoritos_videos)
                    {
                        if (data2.Titulo == e.name_multimedia_file)
                        {
                            return true;
                        }
                    }
                }

            }
            return false;

        }

        public void OnPutFavoriteVideo(object sender, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user)
                {
                    int verificador = 1;
                    foreach (Video vid in data.Favoritos_videos)
                    {
                        if (vid.Titulo == e.Video.Titulo)
                        {
                            verificador = 0;
                        }
                    }
                    if (verificador == 1)
                    {
                        data.Favoritos_videos.Add(e.Video);
                        OnSaveData(appform, new EventArgs());
                    }
                }
            }
        }

        public Usuario OnGetUsuario(object sender, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    return data;
                }
            }
            return new Usuario("", 0, false, false, "", "", false, "", 0, new List<string>(), new List<Personas>(), new List<Canciones>(), new List<Video>()
                , new List<Multimedia>(), new List<Usuario>(), new List<Canciones>(), new List<Video>(), new List<Playlist>(), new List<Canciones>(),
                    new List<Video>());
        }

        public void OnGetUsers(object sender, MyUsersEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                e.user_name.Add(data.Nickname);
                e.user_photo.Add(data.Fotoperfil);
            }
        }

        public void OnSearchedUserInfo(object source, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    List<string> nombres_canciones_subidas = new List<string>();
                    List<string> fotos_canciones_subidas = new List<string>();
                    List<string> nombre_videos_subidos = new List<string>();
                    List<string> fotos_videos_subidos = new List<string>();
                    foreach (Canciones data2 in data.Canciones_agregadas)
                    {
                        nombres_canciones_subidas.Add(data2.Titulo);
                        fotos_canciones_subidas.Add(data2.Portada);
                    }
                    foreach (Video data2 in data.Videos_agregados)
                    {
                        nombre_videos_subidos.Add(data2.Titulo);
                        fotos_canciones_subidas.Add(data2.Portada);
                    }
                    appform.ShowSearchedUserInfo(data.Nickname, data.Nombre, data.Edad, data.User_type, data.Premium,
                        nombres_canciones_subidas, fotos_canciones_subidas, nombre_videos_subidos, fotos_videos_subidos,
                        data.Usuarios_seguidores.Count(), data.Fotoperfil);
                }
            }
        }

        public List<Usuario> OnGetPlatformUsers(object sender, EventArgs e)
        {
            return usuarios;
        }

        public void OnGeneralUserSearch(object source, SearchDataEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname.ToUpper().Contains(e.palabra_clave.ToUpper()))
                {
                    e.nombre_buscado.Add(data.Nickname);
                    e.fotos_buscadas.Add(data.Fotoperfil);
                    e.priv_buscadas.Add(data.User_type);
                }
            }
        }

        public bool OnCanFollowUser(object sender, FollowEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if(data.Nickname == e.user_following)
                {
                    foreach(Usuario data2 in data.Usuarios_seguidores)
                    {
                        if(data2.Nickname == e.user_new_follower)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void OnFollowUser(object sender, FollowEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if(data.Nickname == e.user_following)
                {
                    foreach (Usuario data2 in usuarios)
                    {
                        if (data2.Nickname == e.user_new_follower)
                        {
                            data.Usuarios_seguidores.Add(data2);
                            OnSearchedUserInfo(appform, new LoginEventArgs() { Nickname = data.Nickname });
                            OnSaveData(appform, new EventArgs());
                        }
                    }
                }
            }
        }

        public void OnUnfollowUser(object sender, FollowEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user_following)
                {
                    foreach (Usuario data2 in usuarios)
                    {
                        if (data2.Nickname == e.user_new_follower)
                        {
                            data.Usuarios_seguidores.Remove(data2);
                            OnSearchedUserInfo(appform, new LoginEventArgs() { Nickname = data.Nickname });
                            OnSaveData(appform, new EventArgs());
                        }
                    }
                }
            }
        }

        public void OnSaveData(object source, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream6 = new FileStream("Usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream6, usuarios.Count());
            for (int i = 0; i < usuarios.Count(); i++)
            {
                formatter.Serialize(stream6, usuarios[i]);
            }
            stream6.Close();
        }

        public void OnRemoveCancionFav(object source, AddMultimediaEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                for(int i = 0; i < data.Favoritos_canciones.Count(); i++)
                {
                    if(data.Favoritos_canciones[i].Titulo == e.Cancion.Titulo)
                    {
                        data.Favoritos_canciones.Remove(data.Favoritos_canciones[i]);
                        OnSaveData(appform, new EventArgs());
                    }
                }
                for (int i = 0; i < data.Canciones_agregadas.Count(); i++)
                {
                    if (data.Canciones_agregadas[i].Titulo == e.Cancion.Titulo)
                    {
                        data.Canciones_agregadas.Remove(data.Canciones_agregadas[i]);
                        OnSaveData(appform, new EventArgs());
                    }
                }
            }
        }

        public void OnRemoveVideoFav(object source, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                for (int i = 0; i < data.Favoritos_videos.Count(); i++)
                {
                    if (data.Favoritos_videos[i].Titulo == e.Video.Titulo)
                    {
                        data.Favoritos_videos.Remove(data.Favoritos_videos[i]);
                        OnSaveData(appform, new EventArgs());
                    }
                }
                for (int i = 0; i < data.Videos_agregados.Count(); i++)
                {
                    if (data.Videos_agregados[i].Titulo == e.Video.Titulo)
                    {
                        data.Videos_agregados.Remove(data.Videos_agregados[i]);
                        OnSaveData(appform, new EventArgs());
                    }
                }
            }
        }

        public void OnColaCancion(object source, AddMultimediaEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if(data.Nickname == e.user)
                {
                    data.Cola_cancion.Add(e.Cancion);
                }
            }
        }

        public void OnDeleteFavoriteSong(object source, AddMultimediaEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if (data.Favoritos_canciones.Contains(e.Cancion))
                {
                    data.Favoritos_canciones.Remove(e.Cancion);
                }
            }
        }

        public void OnDeleteFavoriteVideo(object source, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Favoritos_videos.Contains(e.Video))
                {
                    data.Favoritos_videos.Remove(e.Video);
                }
            }
        }
        public void OnColaVideo(object source, AddMultimediaEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.user)
                {
                    data.Cola_video.Add(e.Video);
                }
            }
        }

        public bool OnCanPlay(object source, LoginEventArgs e)
        {
            foreach(Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    if (data.Contador > 0)
                    {
                        data.Contador--;
                        appform.Show_Lives(data.Contador);
                        return true;
                    }
                }
            }
            return false;
        }

        public void OnMyLives(object source, LoginEventArgs e)
        {
            foreach (Usuario data in usuarios)
            {
                if (data.Nickname == e.Nickname)
                {
                    appform.Show_Lives(data.Contador);
                }
            }
        }

        public void OnGetMyRecomendaciones(object sender, AddMultimediaEventArgs e) // falta modificar esto para la utilidad
        {
            foreach (Usuario data in usuarios)
            {
                if (e.user == data.Nickname)
                {
                    foreach (Canciones cancion in data.Favoritos_canciones)
                    {
                        e.can_Reco.Add(cancion);
                        e.can_foto_favs.Add(cancion.Portada);
                    }
                    foreach (Video video in data.Favoritos_videos)
                    {
                        e.vid_Reco.Add(video);
                        e.vid_foto_favs.Add(video.Portada);
                    }

                }
            }
        }


    }

}
