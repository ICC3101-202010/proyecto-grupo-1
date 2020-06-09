using Spotflex.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using WMPLib;
using Spotflex.Properties;
using Org.BouncyCastle.Pkix;
using System.Windows.Forms.VisualStyles;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Org.BouncyCastle.Asn1.Cms;

namespace Spotflex
{
    public partial class Form1 : Form
    {
        bool private_opt = false; //Este declara por default que al crear usuario la cuenta es publica
        bool premium_opt = false; //Esta declara por default que al crear usuario la cuenta es free
        bool clicked_private = false;
        bool clicked_premium = false;
        string user_enter;
        string photo_enter;
        List<string> name_artists = new List<string>();
        List<int> age_artist = new List<int>();
        List<string> gender_artist = new List<string>();
        List<string> name_director = new List<string>();
        List<int> age_director = new List<int>();
        List<string> gender_director = new List<string>();
        List<string> name_actor = new List<string>();
        List<int> age_actor = new List<int>();
        List<string> gender_actor = new List<string>();
        List<string> nicknames_actuales = new List<string>();
        List<string> nicknames_photos_actuales = new List<string>();
        bool reproduciendo;
        string multimedia_playing;

        List<PictureBox> lista_fotos_comentarios_a_mostrar = new List<PictureBox>();
        List<Label> lista_labels_comentarios_a_mostrar = new List<Label>();
        List<PictureBox> lista_fotos_resultados_busquedas = new List<PictureBox>();
        List<Label> lista_labels_resultado_busqeuda = new List<Label>();
        List<Label> lista_labels_secciones = new List<Label>();
        List<PictureBox> lista_fotos_cosas_subidas = new List<PictureBox>();
        List<Label> lista_labels_cosas_subidas = new List<Label>();
        List<PictureBox> lista_fotos_biblioteca = new List<PictureBox>();
        List<Label> lista_labels_biblioteca = new List<Label>();
        List<PictureBox> lista_fotos_artistas = new List<PictureBox>();
        List<Label> lista_labels_artistas = new List<Label>();
        List<PictureBox> lista_fotos_encontradas_especifica = new List<PictureBox>();
        List<Label> lista_titulos_encontradas_especifica = new List<Label>();
        List<PictureBox> lista_fotos_encontradas_favorita = new List<PictureBox>();
        List<Label> lista_titulos_encontradas_favorita = new List<Label>();
        List<PictureBox> lista_usuarios_actuales_fotos = new List<PictureBox>();// estan en el uml, si se borran, sacarlos de ahi
        List<Label> lista_usuarios_actuales_labels = new List<Label>();// estan en el uml, si se borran, sacarlos de ahi

        public delegate bool LoginEventHandler(object source, LoginEventArgs args); //Delegate del evento para inicar sesion
        public event LoginEventHandler LoginButtonClicked;  //Creo el evento
        public event LoginEventHandler CanAddSong;
        public event LoginEventHandler CanAddVideo;
        public event LoginEventHandler DetectPrivate;
        public event LoginEventHandler Admin;

        public event EventHandler<LoginEventArgs> DeleteSong;
        public event EventHandler<LoginEventArgs> DeleteVideo;

        public event EventHandler<LoginEventArgs> UserInfo;
        public event EventHandler<LoginEventArgs> UserCompleteInfo;
        public event EventHandler<LoginEventArgs> EraseUser;
        public event EventHandler<LoginEventArgs> SearchedUserInfo;
        public event EventHandler<LoginEventArgs> SearchedPersonInfo;

        public delegate Usuario GetUsuarioHandler(object source, LoginEventArgs args);
        public event GetUsuarioHandler UsuarioGet;

        public delegate List<Canciones> GetColaCancionesHandler(object source, LoginEventArgs args);
        public event GetColaCancionesHandler GetColaCancion;
        public delegate List<Video> GetColaVideosHandler(object source, LoginEventArgs args);
        public event GetColaVideosHandler GetColaVideo;

        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterButtonClicked;
        public event EventHandler<RegisterEventArgs> PremiumChanged;
        public event EventHandler<RegisterEventArgs> PrivateChanged;

        public delegate void ChangePhotoEventHandler(object source, ChangePhotoEventArgs args);
        public event ChangePhotoEventHandler ChangedPhoto;

        public delegate bool ChangeUserDataEventHandler(object source, ChangeUserDataEventArgs args);
        public event ChangeUserDataEventHandler ChangeUserData;

        public delegate Canciones AddSongUserDataEventHandler(object source, AddSongUserDataEventArgs args);
        public event AddSongUserDataEventHandler AddSongToData;

        public delegate Video AddVideoUserDataEventHandler(object source, AddVideoUserDataEventArgs args);
        public event AddVideoUserDataEventHandler AddVidToData;

        public delegate List<Personas> AddSongPersonaEventHandler(object source, AddSongUserDataEventArgs args);
        public event AddSongPersonaEventHandler AddPersonasCancion;

        public delegate List<Personas> AddVideoPersonaEventHandler(object source, AddVideoUserDataEventArgs args);
        public event AddVideoPersonaEventHandler AddPersonasVideo;

        public delegate void AddMultimediaEventHandler(object source, AddMultimediaEventArgs args);
        public event AddMultimediaEventHandler AddUsuarioCancion;
        public event AddMultimediaEventHandler AddUsuarioVideo;
        public event AddMultimediaEventHandler ShowInfoCancion;
        public event AddMultimediaEventHandler ShowInfoVideo;
        public event AddMultimediaEventHandler DownloadSong;
        public event AddMultimediaEventHandler RemoveSong;
        public event AddMultimediaEventHandler RemoveVideo;
        public event AddMultimediaEventHandler RankedSong;
        public event AddMultimediaEventHandler RankedVideo;
        public event AddMultimediaEventHandler PutFavoriteSong;
        public event AddMultimediaEventHandler PutColaCancion;
        public event AddMultimediaEventHandler DeleteFavoriteSong;
        public event AddMultimediaEventHandler DeleteFavoriteVideo;


        public delegate bool CheckFavoriteEventHandler(object source, AddMultimediaEventArgs e);
        public event CheckFavoriteEventHandler CheckedFavorite;

        public delegate Canciones AddFavoriteSongEventHandler(object source, AddMultimediaEventArgs e);
        public event AddFavoriteSongEventHandler AddFavoriteSong;
        public event AddFavoriteSongEventHandler AddColaSong;
        public event EventHandler<AddMultimediaEventArgs> MyFavs;
        public event EventHandler<AddMultimediaEventArgs> MyRecomendaciones;

        public delegate Video AddFavoriteVideoEventHandler(object source, AddMultimediaEventArgs e);
        public event AddFavoriteVideoEventHandler AddFavoriteVideo;
        public event AddMultimediaEventHandler PutFavoriteVideo;


        public delegate string ReproducirEventHandler(object source, AddMultimediaEventArgs args);
        public event ReproducirEventHandler ReproducirCancion;
        public event ReproducirEventHandler ReproducirVideo;

        public delegate void GetMultimediaInfoEventHandler(object source, GetMultimediaDataEventArgs args);
        public event GetMultimediaInfoEventHandler GetDataVideo;
        public event GetMultimediaInfoEventHandler GetDataSongs;

        public delegate Canciones GetCancionEventHandler(object source, AddMultimediaEventArgs args);
        public event GetCancionEventHandler GetSong;

        public delegate Video GetVideoEventHandler(object source, AddMultimediaEventArgs args);
        public event GetVideoEventHandler GetVideo;


        public delegate void AddComentarioEventHandler(object source, AddComentarioEventArgs args);
        public event AddComentarioEventHandler CommentAdded;
        public event AddComentarioEventHandler CommentAddedVideo;

        public delegate List<string> GetComentarioEventHandler(object source, AddComentarioEventArgs args);
        public event GetComentarioEventHandler GetUserComent;
        public event GetComentarioEventHandler GetUserComentVideo;
        public event GetComentarioEventHandler GetUserPhotoComent;
        public event GetComentarioEventHandler GetUserNickComent;
        public event GetComentarioEventHandler GetUserNickComentVideo;
        public event GetComentarioEventHandler GetUserPhotoComentVideo;

        public delegate void SearchDataEventHandler(object source, SearchDataEventArgs args);
        public event SearchDataEventHandler GeneralFindVideo;
        public event SearchDataEventHandler GeneralFindSong;
        public event SearchDataEventHandler GeneralFindUser;
        public event SearchDataEventHandler GeneralFindPerson;
        public event SearchDataEventHandler GeneralFindPlaylist;

        public delegate bool FollowEventHandler(object source, FollowEventArgs args);
        public event FollowEventHandler CanFollowUser;
        public event EventHandler<FollowEventArgs> FollowUser;
        public event EventHandler<FollowEventArgs> UnfollowUser;
        public event FollowEventHandler CanFollowPerson;
        public event EventHandler<FollowEventArgs> FollowPerson;
        public event EventHandler<FollowEventArgs> UnfollowPerson;

        public delegate void DetailSearchEventHandler(object source, DetailSearchEventArgs args);
        public event DetailSearchEventHandler OrSearchMusic;
        public event DetailSearchEventHandler OrSearchVideo;
        public event DetailSearchEventHandler AndSearchMusic;
        public event DetailSearchEventHandler AndSearchVideo;

        public delegate List<Canciones> GetMySongsEventHandler(object source, GetMultimediaDataEventArgs args);
        public event GetMySongsEventHandler GetMySongs;
        public event GetMySongsEventHandler GetAllSongs;

        public event EventHandler SaveData;

        public delegate IEnumerable<Canciones> RankingSongEventHandler(object source, AddMultimediaEventArgs args);
        public event RankingSongEventHandler GetRankingSongs;


        public delegate List<Video> GetMyVideosEventHandler(object source, GetMultimediaDataEventArgs args);
        public event GetMyVideosEventHandler GetAllVideos;
        public delegate IEnumerable<Video> GetMyVideos2EventHandler(object source, GetMultimediaDataEventArgs args);
        public event GetMyVideos2EventHandler GetRankingVideo;


        public delegate void AddPlaylistEventHandler(object source,AddPlaylistEventArgs args);
        public event AddPlaylistEventHandler GeneratePlaylist;
        public event AddPlaylistEventHandler Delete_Playlist;

        public delegate List<Playlist> AddPlaylistEventHandler2(object source, AddPlaylistEventArgs args);
        public event AddPlaylistEventHandler2 get_Playlist;

        public delegate Playlist AddPlaylisPlaytEventHandler(object source, AddPlaylistEventArgs args);
        public event AddPlaylisPlaytEventHandler UserPlaylists;
        public delegate List<Playlist> GetUserPlaylistEventHandler(object source, LoginEventArgs args);
        public event GetUserPlaylistEventHandler GetUserPlaylist;

        public delegate void AddColaEventHandler(object source, AddMultimediaEventArgs args);
        public event AddColaEventHandler ColaCancion;
        public event AddColaEventHandler ColaVideo;

        public delegate void ChangingAllDataEventHandler(object source, ChangeUserDataEventArgs args);
        public ChangingAllDataEventHandler OnChangingAllData;

        public delegate void GetUsersEventHandler(object source, MyUsersEventArgs e);
        public GetUsersEventHandler GetUsers;


        public Form1()
        {
            InitializeComponent();
            PasswordText.PasswordChar = '*';
            picture_buscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_playlist.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Favoritos.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Back1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_backtoconfig.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_add_music.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_add_video.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_add_portada_cancion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_add_song_to_data.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_back_create_music.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxAtras_nuevovid.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAgregarElVIdeo_enNuevoVId.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto_NuevoVid.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_foto_cancion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_atras_cancion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_vistas_cancion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_calificacion_cancion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_reproducir_cancion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_download.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_1star_Canciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_2star_Canciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_3star_Canciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_4star_Canciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_5star_Canciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_see_ranking.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_recomendaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            panel_playlist_mostrar.BackColor = Color.FromArgb(100, 88, 44, 55);
            Nombre_Playlist_de_Canciones.BackColor = Color.FromArgb(10, 88, 44, 55);
            Nombre_Playlist_de_Videos.BackColor = Color.FromArgb(10, 88, 44, 55);
            Add_Cancion_Playlist.BackColor = Color.FromArgb(10, 88, 44, 55);
            Add_Video_Playlist.BackColor = Color.FromArgb(10, 88, 44, 55);
            label2.BackColor = Color.FromArgb(10, 88, 44, 55);
            Volver_a_Playlist.BackColor = Color.FromArgb(10, 88, 44, 55);
            panel4.BackColor = Color.FromArgb(10, 88, 44, 55);
            panel5.BackColor = Color.FromArgb(10, 88, 44, 55);
            Volver_de_Borrar_VidYCan.BackColor = Color.FromArgb(10, 88, 44, 55);
            //label_ranking_canciones.BackColor = Color.FromArgb(70, 88, 44, 55);
            Volver_Ranking_video_y_canciones.BackColor = Color.FromArgb(10, 88, 44, 55);
            panel_Ranking_de_Canciones.BackColor = Color.FromArgb(60, 88, 44, 55);
            pictureBox10.BackColor = Color.FromArgb(10, 88, 44, 55);

            


        }


        #region forms
        private void button1_Click(object sender, EventArgs e) //Este boton ira al panel de inicio de sesion titulo -> inicio
        {
            panel_crear_sesion.Visible = false;
            panel_iniciar_sesion.Visible = true;
            this.NicknameText.Focus();
        }

        bool checker25 = false;
        private void LoginUserClick(object sender, EventArgs e) //Boton que inicia sesion
        {
            string username = NicknameText.Text;
            string password = PasswordText.Text;
            FotoPerfil.BackgroundImage = Properties.Resources.foto_perfil_base;
            OnLoginButtonClicked(username, password); //Se dispara el evento, los controladores que lo escuchen haran algo
            string path_canciones = @System.IO.Directory.GetCurrentDirectory() + "\\ReproductionTime.bin";
            FotoPerfil.ImageLocation = photo_enter;
            if (File.Exists(path_canciones))
            {
                bool truer = false;
                List<double> times = new List<double>();
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("ReproductionTime.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

                for (int i = 0; i < 2; i++)
                {
                    double obj = (double)formatter2.Deserialize(stream2);


                    times.Add(obj);

                }
                for (int i = 0; i < 3; i++)
                {
                    string obj2 = (string)formatter2.Deserialize(stream2);
                    if (obj2 != "")
                    {
                        if (i == 0 && user_enter == obj2)
                        {
                            truer = true;
                        }
                        if (i == 1 && times.Count ==2 && truer == true)
                        {
                            ReproductorCancion.currentPlaylist = ReproductorCancion.newPlaylist("", "");//ingresar nombre de la cola
                            ReproductorCancion.currentPlaylist.appendItem(ReproductorCancion.newMedia(obj2));
                            ReproductorCancion.Ctlcontrols.currentPosition = times[0];
                        }
                        if (i == 2 && times.Count == 2 && truer == true)
                        {
                            ReproductorVideo.currentPlaylist = ReproductorVideo.newPlaylist("", "");//ingresar nombre de la col
                            ReproductorVideo.currentPlaylist.appendItem(ReproductorVideo.newMedia(obj2));
                            ReproductorVideo.Ctlcontrols.currentPosition = times[1];
                        }
                    }
                }
                stream2.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e) //Este boton ira del menu de inicio de sesion al titulo
        {
            NicknameText.ResetText();
            PasswordText.ResetText();
            MensajeAcceso.Visible = false;
            panel_iniciar_sesion.Visible = false;
            panel_crear_sesion.Visible = false;
        }

        private void button_regresar_Click(object sender, EventArgs e)//Este boton regresa de crear sesion al titulo
        {
            error_clave.Visible = false;
            error_nickname.Visible = false;
            error_nombre.Visible = false;
            error_plan_sesion.Visible = false;
            error_plan_usuario.Visible = false;
            error_edad.Visible = false;
            label_error_registro.Visible = false;
            textBox_Ingrese_Nombre.ResetText();
            textBox_Ingrese_Edad.ResetText();
            textBox_IngreseNick.ResetText();
            textBox_IngreseClave.ResetText();
            clicked_premium = false;
            clicked_private = false;
            panel_iniciar_sesion.Visible = false;
            panel_crear_sesion.Visible = false;
            panel_datos_usuario.Visible = false;
        }

        private void button_crear_sesion_Click(object sender, EventArgs e)
        {
            panel_crear_sesion.Visible = true;
            panel_iniciar_sesion.Visible = true;   //Se supone que una capa solo aparece si la anterior esta, es como una linked list
            panel_datos_usuario.Visible = false;
        }

        private void button_publico_Click(object sender, EventArgs e)
        {
            private_opt = false;
            clicked_private = true;
        }

        private void button_privado_Click(object sender, EventArgs e)
        {
            private_opt = true;
            clicked_private = true;
        }

        private void button_Gratuito_Click(object sender, EventArgs e)
        {
            premium_opt = false;
            clicked_premium = true;
        }

        private void button_Premium_Click(object sender, EventArgs e)
        {
            premium_opt = true;
            clicked_premium = true;
        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            error_nombre.Visible = false;
            error_edad.Visible = false;
            error_nickname.Visible = false;
            error_clave.Visible = false;
            error_plan_sesion.Visible = false;
            error_plan_usuario.Visible = false;
            bool verificador = true;
            string nombre_creando = textBox_Ingrese_Nombre.Text;
            int edad_creada = 0;
            int.TryParse(textBox_Ingrese_Edad.Text, out edad_creada);
            string nick_creando = textBox_IngreseNick.Text;
            string pass_creando = textBox_IngreseClave.Text;
            if (nombre_creando == "")
            {
                verificador = false;
                error_nombre.Visible = true;
            }
            if (edad_creada == 0)
            {
                verificador = false;
                error_edad.Visible = true;
            }
            if (!clicked_private)
            {
                verificador = false;
                error_plan_usuario.Visible = true;
            }
            if (!clicked_premium)
            {
                verificador = false;
                error_plan_sesion.Visible = true;
            }
            if (nick_creando == "")
            {
                verificador = false;
                error_nickname.Visible = true;
            }
            if (pass_creando == "")
            {
                verificador = false;
                error_clave.Visible = true;
            }
            if (!verificador)
            {
                label_error_registro.ForeColor = Color.Red;
                label_error_registro.Text = "Hay casillas vacias o hay elementos de un formato incorrecto, intentelo de nuevo";
                label_error_registro.Visible = true;
            }
            else
            {
                label_error_registro.Visible = false;
                OnRegistredButtonClicked(nombre_creando, edad_creada, nick_creando, pass_creando, premium_opt, private_opt);

            }
        }

        private void FotoPerfil_Click(object sender, EventArgs e) //Metodo para cambiar foto de perfil
        {
            string path = "";
            OpenFileDialog find_path = new OpenFileDialog();
            find_path.Filter = "Image File (*.jpg; *.jpeg; *.bmp;) |*.jpg; *.jpeg; *.bmp; |(*.png; *.jpeg; *.bmp;) |*.png; *.jpeg; *.bmp; ";
            if (find_path.ShowDialog() == DialogResult.OK)
            {
                path = find_path.FileName;
            }
            string username = label_NombreUsuario.Text;
            OnPhotoChanged(username, path);

        }

        private void pictureBox_Back1_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = false;
            textBox_cambiarNick.ResetText();
            textBox_cambiar_clave.ResetText();
            textBox_cambiar_edad.ResetText();
            textBox_cambiar_nombre.ResetText();
        }

        private void label_ajuste_usuario_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_playlist.Visible = false;
            panel_playlist_mostrar.Visible = false;
            panel_reproductor_Video.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_favoritos.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel_comentarios_cancion.Visible = false;
            BorrarVidYCan.Visible = true;
        }

        private void button_guardar_cambios_Click(object sender, EventArgs e) {
            panel_informacion.Visible = false;
            string user_change = textBox_cambiarNick.Text;
            string pass_change = textBox_cambiar_clave.Text;
            int edad_change = 0;
            int.TryParse(textBox_cambiar_edad.Text, out edad_change);
            string name_change = textBox_cambiar_nombre.Text;
            if (edad_change == 0 && textBox_cambiar_edad.Text != "")
            {
                label_error_config.Visible = true;
            }
            else
            {
                OnChangeUserData(user_change, pass_change, name_change, edad_change);
            }
        }

        private void button_cambiar_publico_Click(object sender, EventArgs e)
        {
            bool new_private = false;
            OnChangePrivate(new_private);
            MessageBox.Show("Ahora es un usuario publico", "CAMBIO DE PRIVACIDAD", MessageBoxButtons.OK);
        }

        private void button_cambiarPrivado_Click(object sender, EventArgs e)
        {
            bool new_private = true;
            OnChangePrivate(new_private);
            MessageBox.Show("Ahora es un usuario privado", "CAMBIO DE PRIVACIDAD", MessageBoxButtons.OK);
        }

        private void button_cambiar_free_Click(object sender, EventArgs e)
        {
            bool new_premium = false;
            OnChangePremium(new_premium);
            MessageBox.Show("Ahora es un usuario gratuito", "CAMBIO DE PLAN", MessageBoxButtons.OK);
        }

        private void button_cmabiar_premium_Click(object sender, EventArgs e)
        {
            bool new_premium = true;
            OnChangePremium(new_premium);
            MessageBox.Show("Ahora es un usuario premium, esperemos que disfrute el servicio", "CAMBIO DE PLAN", MessageBoxButtons.OK);
        }

        private void label_cerrar_sesion_Click(object sender, EventArgs e)
        {
            textBox_Buscar.ResetText();
            panel_crear_sesion.Visible = false;
            panel_datos_usuario.Visible = false;
            panel_buscador.Visible = false;
            panel_galeria.Visible = false;
            panel_galeria_canciones.Visible = false;
            panel_galeria_videos.Visible = false;
            panel_informacion.Visible = false;
            panel_ajustes.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_info_artista.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel3.Visible = false;
            panel_info_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_informacion.Visible = false;
            panel_ajustes.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            Mis_Playlist_Eliminar.Visible = false;
            panel_Ranking_de_Canciones.Visible = false;
            panel_Mostrar_Ranking_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panelRecomendaciones.Visible = false;
            panel_eliminar_usuario.Visible = false;
        }

        private void label_borrar_usuario_Click(object sender, EventArgs e)
        {
            bool check_admin = Admin(this, new LoginEventArgs() { Nickname = user_enter });
            if (!check_admin)
            {
                const string message = "Estas seguro que quieres Borrar el usuario?";
                const string caption = "Action";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnEraseUser(user_enter);
                    panel_ajustes.Visible = false;
                    panel_buscador.Visible = false;
                    panel_crear_sesion.Visible = false;
                    panel_datos_usuario.Visible = false;
                    panel_galeria.Visible = false;
                    panel_galeria_videos.Visible = false;
                    panel_galeria_canciones.Visible = false;
                    panel_info.Visible = false;
                    panel_informacion.Visible = false;
                    panel_iniciar_sesion.Visible = false;
                    panel_secc_cancion.Visible = false;
                    panel_secc_video.Visible = false;
                    panel_datos_add_cancion.Visible = false;
                }

            }
            else
            {
                panel_Ranking_de_Canciones.Visible = true;
                panel_de_rankings.Visible = true;
                panel_Eliminar_Playlist.Visible = true;
                panelComentarios_Video.Visible = true;
                panel_favoritos.Visible = true;
                ReproducirPlaylist.Visible = true;
                panel_resultado_busqueda_avanzada.Visible = true;
                panel_playlist.Visible = true;
                panel_busqueda_avanzada.Visible = true;
                panelReproducirVideo.Visible = true;
                panel_info_artista.Visible = true;
                panel_usuario_buscado.Visible = true;
                panel_resultado_busqueda_general.Visible = true;
                panel_comentarios_cancion.Visible = true;
                panel3.Visible = true;
                panel_info_cancion.Visible = true;
                panel_De_Agregar_Video.Visible = true;
                panel_datos_add_cancion.Visible = true;
                panel_informacion.Visible = true;
                panel_ajustes.Visible = true;
                panelComentarios_Video.Visible = true;
                panel_Eliminar_Playlist.Visible = true;
                Mis_Playlist_Eliminar.Visible = true;
                panel_Ranking_de_Canciones.Visible = true;
                panel_Mostrar_Ranking_Canciones.Visible = true;
                panel_de_rankings.Visible = true;
                panelRecomendaciones.Visible = true;
                panel_eliminar_usuario.Visible = true;
                OnShowUsersBorrar();
            }
        }

        private void label_ver_info_Click(object sender, EventArgs e)
        {
            OnUserCompleteInfo(user_enter);
            panel_informacion.Visible = true;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_title_add_cancion.Visible = false;
        }

        private void pictureBox_backtoconfig_Click(object sender, EventArgs e)
        {
            panel_informacion.Visible = false;
        }


        private void pictureBox_add_portada_cancion_Click(object sender, EventArgs e)
        {

            OpenFileDialog find_path = new OpenFileDialog();
            find_path.Filter = "Image File (*.jpg; *.jpeg; *.bmp;) |*.jpg; *.jpeg; *.bmp; |(*.png; *.jpeg; *.bmp;) |*.png; *.jpeg; *.bmp; ";
            if (find_path.ShowDialog() == DialogResult.OK)
            {
                pictureBox_add_portada_cancion.ImageLocation = find_path.FileName;
            }
        }

        private void button_examinar_letra_Click(object sender, EventArgs e)
        {
            OpenFileDialog find_path = new OpenFileDialog();
            find_path.Filter = "Text File (*.txt;) |*.txt;";
            if (find_path.ShowDialog() == DialogResult.OK)
            {
                textBox_add_letra_cancion.Text = find_path.FileName;
            }
        }

        private void button_examinar_directorio_Click(object sender, EventArgs e)
        {
            OpenFileDialog find_path = new OpenFileDialog();
            find_path.Filter = "Audio File (*.mp3; *.wav; *.mkv; *.midi;) |*.mp3; *.wav; *.mkv; *.midi;";
            if (find_path.ShowDialog() == DialogResult.OK)
            {
                textBox_add_directorio_cancion.Text = find_path.FileName;
            }
        }

        private void pictureBox_add_music_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel_fijar_add_cancion.Visible = false;

        }

        private void pictureBox_back_create_music_Click(object sender, EventArgs e)
        {
            name_artists.Clear();
            gender_artist.Clear();
            age_artist.Clear();
            textBox_add_directorio_cancion.ResetText();
            textBox_add_album_artist.ResetText();
            textBox_add_edad_artista.ResetText();
            textBox_add_estudio_cancion.ResetText();
            textBox_add_letra_cancion.ResetText();
            textBox_add_nombre_artista_cancion.ResetText();
            textBox_add_titulo_cancion.ResetText();
            textBox_add_generos_cancion.ResetText();
            richTextBox_add_descripcion_cancion.ResetText();
            pictureBox_add_portada_cancion.ResetText();
            dateTimePicker_add_fecha_publicacion_cancion.ResetText();
            panel_datos_add_cancion.Visible = false;
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            label_error_add_artista.Visible = false;
            label_error_add_cancion.Visible = false;
        }

        private void button_add_more_artists_Click(object sender, EventArgs e)
        {
            try
            {
                int d;
                if (textBox_add_edad_artista.Text == "")
                {
                    d = 0;
                }
                else
                {
                    d = int.Parse(textBox_add_edad_artista.Text);
                }
                name_artists.Add(textBox_add_nombre_artista_cancion.Text);
                age_artist.Add(d);
                string sex = "";
                if (checkBox_sexo_hombre.Checked)
                {
                    sex = "H";
                }
                if (checkBox_sexo_mujer.Checked)
                {
                    sex = "M";
                }
                gender_artist.Add(sex);
                label_error_add_artista.ForeColor = Color.Green;
                label_error_add_artista.Text = "Se agrego correctamente";
                label_error_add_artista.Visible = true;
                textBox_add_nombre_artista_cancion.ResetText();
                textBox_add_edad_artista.ResetText();
                checkBox_sexo_hombre.Checked = false;
                checkBox_sexo_mujer.Checked = false;
                SaveData(this, new EventArgs());
            }
            catch
            {
                label_error_add_artista.ForeColor = Color.Red;
                label_error_add_artista.Text = "Hay un dato mal ingresado";
                label_error_add_artista.Visible = true;
            }

        }

        private void checkBox_sexo_hombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sexo_mujer.Checked)
            {
                checkBox_sexo_mujer.Checked = false;
            }
        }

        private void checkBox_sexo_mujer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sexo_hombre.Checked)
            {
                checkBox_sexo_hombre.Checked = false;
            }
        }

        private void pictureBox_add_song_to_data_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(textBox_add_directorio_cancion.Text))
                {
                    int d;
                    if (textBox_add_edad_artista.Text == "")
                    {
                        d = 0;
                    }
                    else
                    {
                        d = int.Parse(textBox_add_edad_artista.Text);
                    }
                    name_artists.Add(textBox_add_nombre_artista_cancion.Text);
                    age_artist.Add(d);
                    string sex = "";
                    if (checkBox_sexo_hombre.Checked)
                    {
                        sex = "H";
                    }
                    if (checkBox_sexo_mujer.Checked)
                    {
                        sex = "M";
                    }
                    gender_artist.Add(sex);
                    label_error_add_artista.Visible = false;
                    string title_song = textBox_add_titulo_cancion.Text;
                    string album_song = textBox_add_album_artist.Text;
                    string estudio_song = textBox_add_estudio_cancion.Text;
                    string fecha_publicacion_song = dateTimePicker_add_fecha_publicacion_cancion.Text;
                    string descripcion_song = richTextBox_add_descripcion_cancion.Text;
                    string photo_song = pictureBox_add_portada_cancion.ImageLocation;

                    string letra_song = "";
                    if (File.Exists(textBox_add_letra_cancion.Text))
                    {
                        letra_song = File.ReadAllText(textBox_add_letra_cancion.Text);
                    }
                    else
                    {
                        letra_song = "";
                    }
                    string directory_song = textBox_add_directorio_cancion.Text;
                    string workingDirectory = Environment.CurrentDirectory;
                    string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\CancionesSubidas";
                    string archivo = @Path.GetFileName(directory_song);
                    string carpeta = Path.GetDirectoryName(directory_song);

                    if (!Directory.Exists(subdir))
                    {
                        Directory.CreateDirectory(subdir);
                    }

                    string sourceFile = System.IO.Path.Combine(carpeta, archivo);
                    string destFile = System.IO.Path.Combine(subdir, archivo);
                    System.IO.File.Copy(sourceFile, destFile, true);
                    directory_song = subdir +"\\" + Path.GetFileName(directory_song);

                    List<string> genero_cancion = textBox_add_generos_cancion.Text.Split(',').ToList();
                    var player = new WindowsMediaPlayer();
                    var clip = player.newMedia(textBox_add_directorio_cancion.Text);
                    int DURACION = Convert.ToInt32(TimeSpan.FromSeconds(clip.duration).TotalSeconds);
                    FileInfo info = new FileInfo(@directory_song);
                    long size = info.Length;
                    if (CanAddSong != null)
                    {
                        bool result = CanAddSong(this, new LoginEventArgs() { Nickname = user_enter });
                        if (result == false)
                        {
                            label_error_add_cancion.ForeColor = Color.Red;
                            label_error_add_cancion.Text = "No puede ingresar mas canciones\nal sistema, cambiese a premium";
                            label_error_add_cancion.Visible = true;
                        }
                        else if (textBox_add_titulo_cancion.Text == "")
                        {
                            textBox_add_titulo_cancion.Text = "Se debe ingresar un titulo a la cancion";
                        }
                        else if (textBox_add_nombre_artista_cancion.Text == "")
                        {
                            textBox_add_nombre_artista_cancion.Text = "Se debe ingresar el nombre del artista";
                        }
                        else if (textBox_add_edad_artista.Text == "")
                        {
                            textBox_add_edad_artista.Text = "Se debe ingresar la edad del artista";
                        }
                        else if (textBox_add_album_artist.Text == "")
                        {
                            textBox_add_album_artist.Text = "Se debe ingresar el nombre del album";
                        }
                        else if (textBox_add_estudio_cancion.Text == "")
                        {
                            textBox_add_estudio_cancion.Text = "Se debe ingresar el estudio de la cancion";
                        }
                        else if (textBox_add_generos_cancion.Text == "")
                        {
                            textBox_add_generos_cancion.Text = "Se debe ingresar generos a la cancion";
                        }
                        else if (richTextBox_add_descripcion_cancion.Text == "")
                        {
                            richTextBox_add_descripcion_cancion.Text = "Se debe ingresar una descripcion";
                        }
                        else
                        {
                            if(AddSongToData != null && AddPersonasCancion != null && AddUsuarioCancion != null)
                            {
                                DateTime localDate = DateTime.Now;
                                string INCLUSION = localDate.ToString();
                                List<Personas> staff = AddPersonasCancion(this, new AddSongUserDataEventArgs() { Nombre_Artistas = name_artists, Genero_Artistas = gender_artist, Edad_Artistas = age_artist });
                                Canciones cancion = AddSongToData(this, new AddSongUserDataEventArgs() { Album = album_song, Descripcion = descripcion_song, 
                                    Estudio = estudio_song, Fecha_Inclusion = INCLUSION, Fecha_Publicacion = fecha_publicacion_song,
                                    Genero_Artistas = gender_artist, Letra = letra_song, Portada_Path = photo_song,
                                    Song_Path = directory_song, Titulo = title_song, Duracion = DURACION, Staff = staff, 
                                    Generos = genero_cancion, Size = size});
                                AddUsuarioCancion(this, new AddMultimediaEventArgs(){ Cancion = cancion, user = user_enter});
                                SaveData(this, new EventArgs());
                                name_artists.Clear();
                                gender_artist.Clear();
                                age_artist.Clear();
                                textBox_add_directorio_cancion.ResetText();
                                textBox_add_album_artist.ResetText();
                                textBox_add_edad_artista.ResetText();
                                textBox_add_estudio_cancion.ResetText();
                                textBox_add_letra_cancion.ResetText();
                                textBox_add_nombre_artista_cancion.ResetText();
                                textBox_add_titulo_cancion.ResetText();
                                richTextBox_add_descripcion_cancion.ResetText();
                                dateTimePicker_add_fecha_publicacion_cancion.ResetText();
                                pictureBox_add_portada_cancion.ImageLocation = "";
                                label_error_add_artista.Visible = false;
                                label_error_add_cancion.Visible = false;
                                panel_datos_add_cancion.Visible = false;
                                panel_ajustes.Visible = false;
                                panel_informacion.Visible = false;
                                MostrarInformacionMultimedia();

                            }
                        }
                    }

                }
                else
                {
                    label_error_add_cancion.ForeColor = Color.Red;
                    label_error_add_cancion.Text = "Hay un archivo ingresado invalido";
                    label_error_add_cancion.Visible = true;
                }
            }
            catch
            {
                label_error_add_artista.ForeColor = Color.Red;
                label_error_add_artista.Text = "Hay un dato mal ingresado";
                label_error_add_artista.Visible = true;
            }
        }
        List<string> borrarVid = new List<string>();
        List<string> borrarCan = new List<string>();

        private void label_Playlist_Usuario_Click(object sender, EventArgs e)
        {
            panel_playlist_mostrar.Visible = true;
            panel_playlist.Visible = true;
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            label_size_cancion.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_info_artista.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_playlist.Visible = true;
            List<Video> AllVideos = GetAllVideos(this, new GetMultimediaDataEventArgs());
            List<Canciones> AllCanciones = GetAllSongs(this, new GetMultimediaDataEventArgs());

            for(int i = 0; i < borrarVid.Count; i++)
            {
                Check_Videos_agregar_playlist.Items.Remove(borrarVid[i]);
            }
            for(int i = 0; i < borrarCan.Count; i++)
            {
                Check_Canciones_agregar_playlist.Items.Remove(borrarCan[i]);
            }
            borrarVid.Clear();
            borrarCan.Clear();

            Check_Canciones_agregar_playlist.Refresh();
            Check_Videos_agregar_playlist.Refresh();
            foreach (Video vid in AllVideos)
            {
                Check_Videos_agregar_playlist.Items.Add(vid.Titulo);
                borrarVid.Add(vid.Titulo);
            }
            foreach(Canciones can in AllCanciones)
            {
                Check_Canciones_agregar_playlist.Items.Add(can.Titulo);
                borrarCan.Add(can.Titulo);
            }           
            MisCancionesYVideos();
        }

        #region nuevo video
        private void pictureBox_add_video_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panel_fijar_info_cancion.Visible = false;
            pictureBox_reproducir_cancion.Visible = false;
            pictureBox8.Visible = false;
            pictureBox_download.Visible = false;

        }
        #endregion


        private void btnExaminar_nuevovid_Click(object sender, EventArgs e)
        {
            OpenFileDialog find_path = new OpenFileDialog();
            find_path.Filter = "Video File (*.mp4; *.mkv; *.flv;) |*.mp4; *.mkv; *.flv;";
            if (find_path.ShowDialog() == DialogResult.OK)
            {
                textBoxDirecorio_nuevovid.Text = find_path.FileName;
            }
        }

        private void pictureBox_NuevoVid_Click(object sender, EventArgs e)
        {
            OpenFileDialog find_path = new OpenFileDialog();
            find_path.Filter = "Image File (*.jpg; *.jpeg; *.bmp;) |*.jpg; *.jpeg; *.bmp; |(*.png; *.jpeg; *.bmp;) |*.png; *.jpeg; *.bmp; ";
            if (find_path.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto_NuevoVid.ImageLocation = find_path.FileName;
            }
        }

        private void pictureboxAtras_nuevovid_Click(object sender, EventArgs e)
        {
            textBoxnombreDirector_nuevovid.Clear();
            textBoxEdadDirector_nuevovid.Clear();
            textBoxNombreActor_nuevovid.Clear();
            textBoxEdadActor_nuevovid.Clear();
            textBoxtitulo_nuevovid.ResetText();
            textBoxEstudio_nuevovid.ResetText();
            textBox_add_edad_artista.ResetText();
            textBoxGenero_nuevovid.ResetText();
            richTextBoxDescripcion_Nuevovid.ResetText();
            textBoxDirecorio_nuevovid.ResetText();
            pictureBoxFoto_NuevoVid.ResetText();
            dateTimePickerNuevoVid.ResetText();
            panelAgregarunVid.Visible = false;
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            label_error_video_director.Visible = false;
            label_error_add_video.Visible = false;
            label_error_add_actor.Visible = false;
        }

        private void btnAñadirOtro_direcvid_Click(object sender, EventArgs e)
        {
            try
            {
                int d;
                if (textBoxEdadDirector_nuevovid.Text == "")
                {
                    d = 0;
                }
                else
                {
                    d = int.Parse(textBoxEdadDirector_nuevovid.Text);
                }
                name_director.Add(textBoxnombreDirector_nuevovid.Text);
                age_director.Add(d);
                string sex = "";
                if (checkbtnHdirec_vid.Checked)
                {
                    sex = "H";
                }
                if (checkBoxM_direcvid.Checked)
                {
                    sex = "M";
                }
                gender_director.Add(sex);
                label_error_video_director.ForeColor = Color.Green;
                label_error_video_director.Text = "Se agrego correctamente";
                label_error_video_director.Visible = true;
                textBoxnombreDirector_nuevovid.ResetText();
                textBoxEdadDirector_nuevovid.ResetText();
                checkbtnHdirec_vid.Checked = false;
                checkBoxM_direcvid.Checked = false;
                SaveData(this, new EventArgs());
            }
            catch
            {
                label_error_video_director.Visible = true;
                label_error_video_director.ForeColor = Color.Red;
                label_error_video_director.Text = "Hay un dato mal ingresado";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int d;
                if (textBoxEdadActor_nuevovid.Text == "")
                {
                    d = 0;
                }
                else
                {
                    d = int.Parse(textBoxEdadActor_nuevovid.Text);
                }
                name_actor.Add(textBoxEdadActor_nuevovid.Text);
                age_actor.Add(d);
                string sex = "";
                if (checkBoxHActor_nuevovid.Checked)
                {
                    sex = "H";
                }
                if (checkBoxMActores_nuevovid.Checked)
                {
                    sex = "M";
                }
                gender_actor.Add(sex);
                label_error_add_actor.Visible = true;
                label_error_add_actor.ForeColor = Color.Green;
                label_error_add_actor.Text = "Se agrego correctmanete";
                textBoxNombreActor_nuevovid.ResetText();
                textBoxEdadActor_nuevovid.ResetText();
                checkbtnHdirec_vid.Checked = false;
                checkBoxM_direcvid.Checked = false;
                SaveData(this, new EventArgs());
            }
            catch
            {
                label_error_add_actor.Visible = true;
                label_error_add_actor.ForeColor = Color.Red;
                label_error_add_actor.Text = "Hay un dato mal ingresado";
            }
        }

        private void pictureBoxAgregarElVIdeo_enNuevoVId_Click(object sender, EventArgs e)
        {
            int err = 0;
            try
            {
                if (File.Exists(textBoxDirecorio_nuevovid.Text))
                {
                    int d;
                    if (textBoxEdadDirector_nuevovid.Text == "")
                    {
                        d = 0;
                    }
                    else
                    {
                        d = int.Parse(textBoxEdadDirector_nuevovid.Text);
                    }
                    name_director.Add(textBoxnombreDirector_nuevovid.Text);
                    age_director.Add(d);
                    string sex = "";
                    if (checkbtnHdirec_vid.Checked)
                    {
                        sex = "H";
                    }
                    if (checkBoxM_direcvid.Checked)
                    {
                        sex = "M";
                    }
                    gender_director.Add(sex);
                    label_error_video_director.Visible = false;
                    err = 1;

                    if (textBoxEdadActor_nuevovid.Text == "")
                    {
                        d = 0;
                    }
                    else
                    {
                        d = int.Parse(textBoxEdadActor_nuevovid.Text);
                    }
                    name_actor.Add(textBoxNombreActor_nuevovid.Text);
                    age_actor.Add(d);
                    if (checkBoxHActor_nuevovid.Checked)
                    {
                        sex = "H";
                    }
                    if (checkBoxMActores_nuevovid.Checked)
                    {
                        sex = "M";
                    }
                    gender_actor.Add(sex);
                    label_error_add_actor.Visible = false;
                    string title_song = textBoxtitulo_nuevovid.Text;
                    string estudio_song = textBoxEstudio_nuevovid.Text;
                    string fecha_publicacion_song = dateTimePickerNuevoVid.Text;
                    string descripcion_song = richTextBoxDescripcion_Nuevovid.Text;
                    string photo_song = pictureBoxFoto_NuevoVid.ImageLocation;
                    string directory_song = textBoxDirecorio_nuevovid.Text;
                    string workingDirectory = Environment.CurrentDirectory;
                    string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\VideosSubidas";
                    string archivo = @Path.GetFileName(directory_song);
                    string carpeta = Path.GetDirectoryName(directory_song);
                    if (!Directory.Exists(subdir))
                    {
                        Directory.CreateDirectory(subdir);
                    }
                    string sourceFile = System.IO.Path.Combine(carpeta, archivo);
                    string destFile = System.IO.Path.Combine(subdir, archivo);
                    System.IO.File.Copy(sourceFile, destFile, true);
                    directory_song = subdir + "\\" + Path.GetFileName(directory_song);
                    var player = new WindowsMediaPlayer();
                    var clip = player.newMedia(textBoxDirecorio_nuevovid.Text);
                    int DURACION = Convert.ToInt32(TimeSpan.FromSeconds(clip.duration).TotalSeconds);
                    List<string> genero_video = textBoxGenero_nuevovid.Text.Split(',').ToList();
                    int calidad = clip.imageSourceHeight;
                    FileInfo info = new FileInfo(@directory_song);
                    long size = info.Length;
                    if (CanAddVideo != null)
                    {
                        bool result = CanAddVideo(this, new LoginEventArgs() { Nickname = user_enter });
                        if (result == false)
                        {
                            label_error_add_video.ForeColor = Color.Red;
                            label_error_add_video.Text = "No puede ingresar mas canciones\nal sistema, cambiese a premium";
                            label_error_add_video.Visible = true;
                        }
                        else if (textBoxtitulo_nuevovid.Text == "")
                        {
                            textBoxtitulo_nuevovid.Text = "Se debe ingresar un titulo al Video";
                        }
                        else if (textBoxnombreDirector_nuevovid.Text == "")
                        {
                            textBoxnombreDirector_nuevovid.Text = "Se debe ingresar el nombre del director";
                        }
                        else if (textBoxEdadDirector_nuevovid.Text == "")
                        {
                            textBoxEdadDirector_nuevovid.Text = "Se debe ingresar la edad del director";
                        }
                        else if (textBoxNombreActor_nuevovid.Text == "")
                        {
                            textBoxNombreActor_nuevovid.Text = "Se debe ingresar el nombre de un actor";
                        }
                        else if (textBoxEdadActor_nuevovid.Text == "")
                        {
                            textBoxEdadActor_nuevovid.Text = "Se debe ingresar la edad de un actor";
                        }
                        else if (textBoxEstudio_nuevovid.Text == "")
                        {
                            textBoxEstudio_nuevovid.Text = "Se debe ingresar el estudio de el video";
                        }
                        else if (textBoxGenero_nuevovid.Text == "")
                        {
                            textBoxGenero_nuevovid.Text = "Se debe ingresar un genero al video";
                        }
                        else if (richTextBoxDescripcion_Nuevovid.Text == "")
                        {
                            richTextBoxDescripcion_Nuevovid.Text = "Se debe ingresar una descripcion a el video";
                        }
                        else
                        {
                            if (AddVidToData != null && AddPersonasVideo != null && AddUsuarioVideo != null)
                            {
                                DateTime localDate = DateTime.Now;
                                string INCLUSION = localDate.ToString();
                                List<Personas> staff = AddPersonasVideo(this, new AddVideoUserDataEventArgs()
                                {
                                    Nombre_Director = name_director,
                                    Genero_Director = gender_director,
                                    Edad_Director = age_director,
                                    Nombre_Actor = name_actor,
                                    Genero_Actor = gender_actor,
                                    Edad_Actor = age_director
                                }
                                );
                                Video video = AddVidToData(this, new AddVideoUserDataEventArgs()
                                {
                                    Descripcion = descripcion_song,
                                    Estudio = estudio_song,
                                    Fecha_Inclusion = INCLUSION,
                                    Fecha_Publicacion = fecha_publicacion_song,
                                    Genero_Director = gender_director,
                                    Portada_Path = photo_song,
                                    Video_Path = directory_song,
                                    Titulo = title_song,
                                    Duracion = DURACION,
                                    Staff = staff,
                                    Generos = genero_video,
                                    Calidad = calidad,
                                    Size = size
                                }) ;
                                AddUsuarioVideo(this, new AddMultimediaEventArgs() { Video = video, user = user_enter });
                                textBoxnombreDirector_nuevovid.Clear();
                                textBoxEdadDirector_nuevovid.Clear();
                                textBoxNombreActor_nuevovid.Clear();
                                textBoxEdadActor_nuevovid.Clear();
                                textBoxtitulo_nuevovid.ResetText();
                                textBoxEstudio_nuevovid.ResetText();
                                textBox_add_edad_artista.ResetText();
                                textBoxGenero_nuevovid.ResetText();
                                richTextBoxDescripcion_Nuevovid.ResetText();
                                textBoxDirecorio_nuevovid.ResetText();
                                pictureBoxFoto_NuevoVid.ResetText();
                                dateTimePickerNuevoVid.ResetText();
                                pictureBox_add_video.ImageLocation = "";
                                gender_actor.Clear();
                                name_actor.Clear();
                                age_actor.Clear();
                                gender_director.Clear();
                                name_director.Clear();
                                age_director.Clear();
                                SaveData(this, new EventArgs());
                                MostrarInformacionMultimedia();
                                label_error_add_video.Visible = false;
                                label_error_add_actor.Visible = false;
                                label_error_video_director.Visible = false;
                                panelAgregarunVid.Visible = false;
                                panel_datos_add_cancion.Visible = false;
                                panel_ajustes.Visible = false;
                                panel_informacion.Visible = false;
                            }
                        }
                    }

                }
                else
                {
                    label_error_add_video.Visible = true;
                }
            }
            catch
            {
                if (err == 0)
                {
                    label_error_video_director.Visible = true;
                }
                else
                {
                    label_error_video_director.Visible = false;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarInformacionMultimedia();


        }
        List<PictureBox> pictures_Galeria_Canciones = new List<PictureBox>();
        List<PictureBox> pictures_Galeria_Video = new List<PictureBox>();
        List<Label> label_Galeria_Canciones = new List<Label>();
        List<Label> label_Galeria_Video = new List<Label>();
        public void MostrarInformacionMultimedia()
        {

            for (int i = 0; i < lista_fotos_biblioteca.Count(); i++)
            {
                panel_galeria_canciones.Controls.Remove(lista_fotos_biblioteca[i]);
            }
            for (int i = 0; i < lista_labels_biblioteca.Count(); i++)
            {
                panel_galeria_canciones.Controls.Remove(lista_labels_biblioteca[i]);
            }

            lista_fotos_biblioteca.Clear();
            lista_labels_biblioteca.Clear();
            int cancion_pos_x = 50;
            int cancion_pos_y = 70;
            int video_pos_x = 50;
            int video_pos_y = 70;
            List<string> nombre_canciones = new List<string>();
            List<string> path_canciones = new List<string>();
            List<string> nombre_videos = new List<string>();
            List<string> path_videos = new List<string>();
            GetDataSongs(this, new GetMultimediaDataEventArgs() { name_songs = nombre_canciones, path_songs = path_canciones });
            GetDataVideo(this, new GetMultimediaDataEventArgs() { name_videos = nombre_videos, path_videos = path_videos });
            for (int i = 0; i < nombre_canciones.Count(); i++)
            {
                PictureBox pict = add_multimedia_image(cancion_pos_x, cancion_pos_y - 30, nombre_canciones[i], path_canciones[i]);
                pict.BackColor = Color.FromArgb(150, 88, 44, 55);
                panel_galeria_canciones.Controls.Add(pict);
                pictures_Galeria_Canciones.Add(pict);
                lista_fotos_biblioteca.Add(pict);
                pict.Click += new System.EventHandler(this.OnSongClick);
                Label l = add_multimedia_label(cancion_pos_x, cancion_pos_y + 115, nombre_canciones[i]);
                l.BackColor = Color.FromArgb(10, 88, 44, 55);
                label_Galeria_Canciones.Add(l);
                panel_galeria_canciones.Controls.Add(l);
                lista_labels_biblioteca.Add(l);
                cancion_pos_x += 170;
            }
            for (int i = 0; i < nombre_videos.Count(); i++)
            {
                PictureBox pict = add_multimedia_image(video_pos_x, video_pos_y, nombre_videos[i], path_videos[i]);
                pict.BackColor = Color.FromArgb(150, 88, 44, 55);
                lista_fotos_biblioteca.Add(pict);
                pictures_Galeria_Video.Add(pict);
                panel_galeria_videos.Controls.Add(pict);

                pict.Click += new System.EventHandler(this.OnVideoClick);
                Label l = add_multimedia_label(video_pos_x, video_pos_y + 145, nombre_videos[i]);
                l.BackColor = Color.FromArgb(10, 88, 44, 55);
                label_Galeria_Video.Add(l);
                panel_galeria_videos.Controls.Add(l);
                lista_labels_biblioteca.Add(l);
                video_pos_x += 170;
            }
        }

        List<Canciones> c = new List<Canciones>();
        List<PictureBox> pictu = new List<PictureBox>();
        List<Label> lab = new List<Label>();
        public void MisCanciones(List<Canciones> can)
        {
            for (int i = 0; i < pictu.Count(); i++)
            {
                panel4.Controls.Remove(pictu[i]);
            }
            for (int i = 0; i < lab.Count(); i++)
            {
                panel4.Controls.Remove(lab[i]);
            }
            pictu.Clear();
            lab.Clear();
            c.Clear();
            int cancion_pos_x = 50;
            int cancion_pos_y = 70;
            List<string> nombre_canciones = new List<string>();
            List<string> path_canciones = new List<string>();
            List<string> nombre_videos = new List<string>();
            List<string> path_videos = new List<string>();
            GetDataSongs(this, new GetMultimediaDataEventArgs() { name_songs = nombre_canciones, path_songs = path_canciones });
            GetDataVideo(this, new GetMultimediaDataEventArgs() { name_videos = nombre_videos, path_videos = path_videos });
            panel4.Refresh();
            for (int i = 0; i < nombre_canciones.Count(); i++)
            {
                for (int j = 0; j < can.Count; j++)
                {
                    if (can[j].Titulo == nombre_canciones[i])
                    {
                        PictureBox pict = add_multimedia_image(cancion_pos_x, cancion_pos_y - 30, nombre_canciones[i], path_canciones[i]);
                        pict.Name = can[j].Titulo;
                        pictu.Add(pict);
                        panel4.Controls.Add(pict);
                        pict.Click += new System.EventHandler(this.OnDeleteClick);
                        c.Add(can[j]);
                        Label l = add_multimedia_label(cancion_pos_x, cancion_pos_y + 115, nombre_canciones[i]);
                        lab.Add(l);
                        l.Name = can[j].Titulo;
                        panel4.Controls.Add(l);
                        cancion_pos_x += 170;
                    }

                }
            }
        }
        List<Video> c2 = new List<Video>();
        List<PictureBox> pictu2 = new List<PictureBox>();
        List<Label> lab2 = new List<Label>();
        public void MisVideos(List<Video> vid)
        {
            for (int i = 0; i < pictu2.Count(); i++)
            {
                panel5.Controls.Remove(pictu2[i]);
            }
            for (int i = 0; i < lab2.Count(); i++)
            {
                panel5.Controls.Remove(lab2[i]);
            }
            pictu2.Clear();
            lab2.Clear();
            c2.Clear();
            int cancion_pos_x = 50;
            int cancion_pos_y = 70;
            List<string> nombre_canciones = new List<string>();
            List<string> path_canciones = new List<string>();
            List<string> nombre_videos = new List<string>();
            List<string> path_videos = new List<string>();
            GetDataSongs(this, new GetMultimediaDataEventArgs() { name_songs = nombre_canciones, path_songs = path_canciones });
            GetDataVideo(this, new GetMultimediaDataEventArgs() { name_videos = nombre_videos, path_videos = path_videos });
            panel4.Refresh();
            for (int i = 0; i < nombre_videos.Count(); i++)
            {
                for (int j = 0; j < vid.Count; j++)
                {
                    if (vid[j].Titulo == nombre_videos[i])
                    {
                        PictureBox pict = add_multimedia_image(cancion_pos_x, cancion_pos_y - 30, nombre_videos[i], path_videos[i]);
                        pict.Name = vid[j].Titulo;
                        pictu2.Add(pict);
                        panel5.Controls.Add(pict);
                        pict.Click += new System.EventHandler(this.OnDeleteClick2);
                        c2.Add(vid[j]);
                        Label l = add_multimedia_label(cancion_pos_x, cancion_pos_y + 115, nombre_videos[i]);
                        lab2.Add(l);
                        l.Name = vid[j].Titulo;
                        panel5.Controls.Add(l);
                        cancion_pos_x += 170;
                    }

                }

            }
        }
        private void MisCancionesYVideos()
        {
            yPV = -130;
            panel_playlist_mostrar.Controls.Clear();
            if (get_Playlist != null)
            {
                List<Playlist> play = get_Playlist(this, new AddPlaylistEventArgs());

                List<Playlist> usaPlay = GetUserPlaylist(this, new LoginEventArgs() { Nickname = user_enter });
                List<string> usaPlayNames = new List<string>();

                foreach (Playlist playing in usaPlay)
                {
                    usaPlayNames.Add(playing.Name);
                }
                foreach (Playlist item in play)
                {
                     
                    if (item.Mostrar_Videos() != null && item.Priv == false ||  item.Priv == true && usaPlayNames.Contains(item.Name) == true && item.Mostrar_Videos() != null)
                    {
                        int x = 60;
                        yPV += 175;
                        string path = item.Foto;
                        PictureBox pict = new PictureBox();
                        bool test = true;
                        if (path == "")
                        {
                            pict.Image = Properties.Resources.totoro;
                            test = false;
                        }

                        
                        List<string> mylist = new List<string>();

                        foreach (Video videos in item.Mostrar_Videos())
                        {
                            mylist.Add(videos.Titulo);
                        }
                        pict.Name = item.Name;
                        if(test == true)
                        {
                            pict.ImageLocation = path;
                        }                       
                        pict.Width = 140;
                        pict.Height = 140;
                        pict.SizeMode = PictureBoxSizeMode.StretchImage;
                        pict.BackColor = Color.Black;
                        pict.Location = new Point(x, yPV);
                        panel_playlist_mostrar.Controls.Add(pict);
                        Label l = new Label();
                        l.Text = item.Name;
                        l.Location = new Point(x + 50, yPV + 140);
                        panel_playlist_mostrar.Controls.Add(l);
                        List<Video> AllVideos = GetAllVideos(this, new GetMultimediaDataEventArgs());
                        List<Video> MyVideosPlay = new List<Video>();
                        foreach (Video vid in AllVideos)
                        {
                            foreach (string item2 in mylist)
                            {
                                if (vid.Titulo == item2)
                                {
                                    MyVideosPlay.Add(vid);
                                }
                            }
                        }
                        pict.Click += new System.EventHandler(this.OnVideoPlay);
                    }
                    else if (item.Mostrar_Canciones() != null && item.Priv == false || (item.Priv == true && usaPlayNames.Contains(item.Name) == true && item.Mostrar_Canciones() != null))
                    {
                        int x = 60;
                        yPV += 175;
                        bool test = true;
                        string path = item.Foto;
                        PictureBox pict = new PictureBox();
                        if (path == "")
                        {
                            pict.Image = Properties.Resources.CPlaylist;
                            test = false;
                        }

                        
                        List<string> mylist = new List<string>();

                        foreach (Canciones canciones in item.Mostrar_Canciones())
                        {
                            mylist.Add(canciones.Titulo);
                        }


                        pict.Name = item.Name;
                        if(test == true)
                        {
                            pict.ImageLocation = path;
                        }                      
                        pict.Width = 140;
                        pict.Height = 140;
                        pict.SizeMode = PictureBoxSizeMode.StretchImage;
                        pict.BackColor = Color.Black;
                        pict.Location = new Point(x, yPV);
                        panel_playlist_mostrar.Controls.Add(pict);
                        Label l = new Label();
                        l.Text = item.Name;
                        l.Location = new Point(x + 50, yPV + 140);
                        panel_playlist_mostrar.Controls.Add(l);
                        List<Canciones> AllCanciones = GetAllSongs(this, new GetMultimediaDataEventArgs());
                        List<Canciones> MySongsPlay = new List<Canciones>();
                        foreach (Canciones vid in AllCanciones)
                        {
                            foreach (string item2 in mylist)
                            {
                                if (vid.Titulo == item2)
                                {
                                    MySongsPlay.Add(vid);
                                }
                            }
                        }
                        pict.Click += new System.EventHandler(this.OnCancionPlay);
                    }

                }
            }
        }

        private void OnDeleteClick2(object sender, EventArgs e)
        {
            const string message = "Seguro que quieres borrar este Video?";
            const string caption = "Action";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PictureBox currentable = (PictureBox)sender;
                string a = " ";
                string b = " ";
                foreach (PictureBox item in pictu2)
                {
                    if (currentable.Name == item.Name)
                    {
                        panel5.Controls.Remove(item);
                        a = item.Name;
                        //panel_galeria_canciones.Controls.Remove(item);
                    }
                }
                foreach (Label item2 in lab2)
                {
                    if (currentable.Name == item2.Name)
                    {
                        panel5.Controls.Remove(item2);
                        b = item2.Name;

                    }
                }
                foreach (PictureBox item in pictures_Galeria_Video)
                {
                    if ("pictureBox_" + currentable.Name == item.Name)
                    {
                        panel_galeria_videos.Controls.Remove(item);
                    }
                }
                foreach (Label item2 in label_Galeria_Video)
                {
                    if ("label_" + currentable.Name == item2.Name)
                    {
                        panel_galeria_videos.Controls.Remove(item2);

                    }
                }
                Video d = null;
                foreach (Video item400 in c2)
                {
                    if (item400.Titulo == a)
                    {
                        d = item400;
                    }
                }
                OnRemoveVideo(d);

                MostrarInformacionMultimedia();
            }

        }

        public void OnRemoveSong(Canciones titulo)
        {
            if(RemoveSong != null)
            {
                RemoveSong(this, new AddMultimediaEventArgs() { Cancion = titulo});//arreglar
                DeleteFavoriteSong(this, new AddMultimediaEventArgs() {Cancion = titulo });
            }
        }
        public void OnRemoveVideo(Video titulo)
        {
            if (RemoveVideo != null)
            {
                RemoveVideo(this, new AddMultimediaEventArgs() { Video = titulo });//arreglar
                DeleteFavoriteVideo(this, new AddMultimediaEventArgs() { Video = titulo });
            }
        }
        public void OnDeleteClick(object sender, EventArgs e)
        {
            const string message = "Seguro que quieres borrar esta Cancion?";
            const string caption = "Action";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PictureBox currentable = (PictureBox)sender;
                string a = " ";
                string b = " ";
                foreach (PictureBox item in pictu)
                {
                    if (currentable.Name == item.Name)
                    {
                        panel4.Controls.Remove(item);
                        a = item.Name;
                        //panel_galeria_canciones.Controls.Remove(item);
                    }
                }
                foreach (Label item2 in lab)
                {
                    if (currentable.Name == item2.Name)
                    {
                        panel4.Controls.Remove(item2);
                        b = item2.Name;

                    }
                }
                foreach (PictureBox item in pictures_Galeria_Canciones)
                {
                    if ("pictureBox_" + currentable.Name == item.Name)
                    {
                        panel_galeria_canciones.Controls.Remove(item);
                    }
                }
                foreach (Label item2 in label_Galeria_Canciones)
                {
                    if ("label_buscado_" + currentable.Name == item2.Name)
                    {
                        panel_galeria_canciones.Controls.Remove(item2);

                    }
                }
                Canciones d = null;
                foreach (Canciones item400 in c)
                {
                    if (item400.Titulo == a)
                    {
                        d = item400;
                    }
                }
                OnRemoveSong(d);

                MostrarInformacionMultimedia();
            }

        }

       

        private void panel_fijar_add_cancion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_secc_cancion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_atras_cancion_Click(object sender, EventArgs e)
        {
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel_reproductor_cancion.Visible = false;
            pictureBox_reproducir_cancion.Visible = false;
            pictureBox_download.Visible = false;
            label_size_cancion.Visible = false;
            label_mensaje_cancion_descargada.Visible = false;
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            pictureBox_1star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_2star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_3star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_4star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_5star_Canciones.Image = Properties.Resources.nostar;
        }

        private void radioButton_favoritos_cancion_CheckedChanged(object sender, EventArgs e)
        {
            OnSongFavorite(user_enter, label_info_nombre_cancion.Text);
            SaveData(this, new EventArgs());
        }

        private void button_add_cancion_cola_Click(object sender, EventArgs e)
        {
            if (AddColaSong != null && PutColaCancion != null)
            {
                Canciones cancion = AddColaSong(this, new AddMultimediaEventArgs() { name_multimedia_file = label_info_nombre_cancion.Text });
                PutColaCancion(this, new AddMultimediaEventArgs() { Cancion = cancion });
            }
        }

        private void pictureBox_reproducir_cancion_Click(object sender, EventArgs e)
        {
            ReproductorVideo.Ctlcontrols.pause();
            Reproductor_de_Playlist.Ctlcontrols.pause();
            panel_reproductor_cancion.Visible = true;
            string name_song = label_info_nombre_cancion.Text;

            
            List<Canciones> p = GetColaCancion(this, new LoginEventArgs() { Nickname = user_enter });

                if (p!= null)
                {
                    //PictureBox currentable = (PictureBox)sender;
                    string url_cancion = ReproducirCancion(this, new AddMultimediaEventArgs() { name_multimedia_file = name_song });

                    multimedia_playing = name_song;
                    reproduciendo = true;

                    ReproductorCancion.currentPlaylist = ReproductorCancion.newPlaylist("", "");//ingresar nombre de la cola
                    ReproductorCancion.currentPlaylist.appendItem(ReproductorCancion.newMedia(url_cancion));
                    for (int i = 0; i < p.Count; i++)
                    {
                        ReproductorCancion.currentPlaylist.appendItem(ReproductorCancion.newMedia(p[i].Carpeta_archivo));
                    }
                    ReproductorCancion.Ctlcontrols.play();
                }
                else if (name_song != multimedia_playing)
                {
                    string url_cancion = ReproducirCancion(this, new AddMultimediaEventArgs() { name_multimedia_file = name_song });
                    ReproductorCancion.URL = url_cancion;
                    multimedia_playing = name_song;
                    reproduciendo = true;
                }
        }


        private void pictureBox_salir_Click(object sender, EventArgs e)
        {
            panel_reproductor_cancion.Visible = false;
        }

        private void pictureBox_download_Click(object sender, EventArgs e)
        {
            if (DownloadSong != null)
            {
                try
                {
                    DownloadSong(this, new AddMultimediaEventArgs() { name_multimedia_file = label_info_nombre_cancion.Text });
                    label_mensaje_cancion_descargada.ForeColor = Color.Green;
                    label_mensaje_cancion_descargada.Text = "Se ha descargado la cancion";
                }
                catch
                {
                    label_mensaje_cancion_descargada.ForeColor = Color.Red;
                    label_mensaje_cancion_descargada.Text = "No se pudo descargar";
                }
                label_mensaje_cancion_descargada.Visible = true;
            }
        }

        private void pictureBox_1star_Canciones_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(1);
        }

        private void pictureBox_2star_Canciones_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(2);
        }

        private void pictureBox_3star_Canciones_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(3);
        }

        private void pictureBox_4star_Canciones_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(4);
        }

        private void pictureBox_5star_Canciones_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(5);
        }

        private void NicknameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.PasswordText.Focus();
            }
        }
        private void OnDeleteSong()
        {
            if (DeleteSong != null)
            {
                DeleteSong(this, new LoginEventArgs() { Nickname = user_enter });
            }
        }
        private void OnDeleteVideo()
        {
            if (DeleteVideo != null)
            {
                DeleteVideo(this, new LoginEventArgs() { Nickname = user_enter });
            }
        }

        private void BorrarVidYCan_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            pictureBox_reproducir_cancion.Visible = false;
            pictureBox_download.Visible = false;
            label_size_cancion.Visible = false;
            label_size_cancion.Visible = true;
            panel4.Refresh();
            panel5.Refresh();
            OnDeleteSong();
            OnDeleteVideo();


        }

        private void radioButton_add_favorito_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_add_favorito.Checked)
            {
                OnSongFavorite(user_enter, label_info_nombre_cancion.Text);
            }
            SaveData(this, new EventArgs());
        }

        private void button_add_coment_cancion_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel_comentarios_cancion.Visible = true;
            label_subtitulo_comentarios_Cancion.Text = "Comentarios de la Cancion " + label_info_nombre_cancion.Text;
            OnShowComentariosSong();

        }

        private void pictureBox_atras_comentarios_cancion_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel_comentarios_cancion.Visible = false;
            for (int i = 0; i < lista_labels_comentarios_a_mostrar.Count(); i++)
            {
                lista_labels_comentarios_a_mostrar.Remove(lista_labels_comentarios_a_mostrar[i]);
                lista_fotos_comentarios_a_mostrar.Remove(lista_fotos_comentarios_a_mostrar[i]);
            }

        }

        private void button_comentar_cancion_Click(object sender, EventArgs e)
        {
            string comentario = richTextBox_caja_de_comentarios.Text;
            if (CommentAdded != null && comentario != "")
            {
                Usuario usuario = UsuarioGet(this, new LoginEventArgs() { Nickname = user_enter });
                CommentAdded(this, new AddComentarioEventArgs() { user = usuario, comentario = comentario, Multimedia_Name = label_info_nombre_cancion.Text });
                OnShowComentariosSong();
                richTextBox_caja_de_comentarios.ResetText();
            }
        }

        private void picture_buscar_Click(object sender, EventArgs e)
        {
            textBox_Buscar.Focus();
            string buscado = textBox_Buscar.Text;
            for (int i = 0; i < lista_fotos_resultados_busquedas.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_fotos_resultados_busquedas[i]);
            }
            for (int i = 0; i < lista_labels_resultado_busqeuda.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_resultado_busqeuda[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_fotos_resultados_busquedas.Clear();
            lista_labels_resultado_busqeuda.Clear();
            lista_labels_secciones.Clear();
            label_resultados_busquedas_general.Text = "Resultados de busqueda de: ";
            panel_info_cancion.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_info_artista.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            Mis_Playlist_Eliminar.Visible = false;
            panel_Ranking_de_Canciones.Visible = false;
            panel_Mostrar_Ranking_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panelRecomendaciones.Visible = false;
            OnBusquedaGeneral(buscado);
        }
        #endregion

        #region on button
        //Metodos de los Botones, deben ser privados, solo el form tiene acceso a ellos
        private void OnLoginButtonClicked(string username, string password)
        {
            if (LoginButtonClicked != null)//ver si hay controladores suscritos al evento
            {
                bool result = LoginButtonClicked(this, new LoginEventArgs() { Nickname = username, Password = password}); //Como queremos ver si se puede iniciar sesion o no ponemos bool
                if (!result) //No se puede iniciar sesion ya que no existen usuarios con las caracteristicas dichas
                {
                    MensajeAcceso.Visible = true;
                }
                else
                {
                    user_enter = NicknameText.Text;
                    NicknameText.ResetText();
                    PasswordText.ResetText();
                    MensajeAcceso.Visible = false;
                    panel_crear_sesion.Visible = true;
                    panel_datos_usuario.Visible = true;
                    panel_buscador.Visible = true;
                    panel_galeria.Visible = true;
                    panel_galeria_canciones.Visible = true;
                    panel_galeria_videos.Visible = true;
                    panel_secc_cancion.Visible = true;
                    panel_secc_video.Visible = true;
                    OnUserInfo(username);
                    photo_enter = FotoPerfil.ImageLocation;
                    MostrarInformacionMultimedia();
                }
            }

        }

        private void OnRegistredButtonClicked(string name, int edad, string user, string password, bool premium, bool private_user)
        {
            if (RegisterButtonClicked != null)
            {
                bool result = RegisterButtonClicked(this, new RegisterEventArgs() { Nickname = user, Password = password, Edad = edad, Name = name, Premium = premium, Private_User = private_user });
                if (!result)
                {
                    label_error_registro.ForeColor = Color.Red;
                    label_error_registro.Text = "Esta cuenta ya existe, escriba otro nombre de Usuario";
                    label_error_registro.Visible = true;
                }
                else
                {
                    label_error_registro.Visible = true;
                    error_clave.Visible = false;
                    error_nickname.Visible = false;
                    error_nombre.Visible = false;
                    error_plan_sesion.Visible = false;
                    error_plan_usuario.Visible = false;
                    error_edad.Visible = false;
                    textBox_Ingrese_Nombre.ResetText();
                    textBox_Ingrese_Edad.ResetText();
                    textBox_IngreseNick.ResetText();
                    textBox_IngreseClave.ResetText();
                    clicked_premium = false;
                    clicked_private = false;
                    label_error_registro.ForeColor = Color.Green;
                    label_error_registro.Text = "Sesion creada con exito :D";
                }
            }

        }

        public void OnChangeUserData(string user_change, string pass_change, string name_change, int edad_change)
        {
            if (ChangeUserData != null)
            {
                bool result = ChangeUserData(this, new ChangeUserDataEventArgs() { Nickname = user_change, Edad = edad_change, Name = name_change, Password = pass_change, OldNickname = user_enter});
                if (!result)
                {
                    label_error_config.Visible = true;
                }
                else
                {
                    label_error_config.Visible = false;
                    if (user_change != "")
                    {
                        OnChangingAllData(this, new ChangeUserDataEventArgs { Nickname = user_change, OldNickname = user_enter });
                        user_enter = user_change;
                    }
                }
                textBox_cambiarNick.ResetText();
                textBox_cambiar_clave.ResetText();
                textBox_cambiar_edad.ResetText();
                textBox_cambiar_nombre.ResetText();
                OnUserInfo(user_change);
            }
        }

        public void OnShowUsersBorrar()
        {
            for(int i = 0; i < lista_usuarios_actuales_fotos.Count(); i++)
            {
                panel_eliminar_usuario.Controls.Remove(lista_usuarios_actuales_fotos[i]);
            }
            for(int i = 0; i < lista_usuarios_actuales_labels.Count(); i++)
            {
                panel_eliminar_usuario.Controls.Remove(lista_usuarios_actuales_labels[i]);
            }
            lista_usuarios_actuales_fotos.Clear();
            lista_usuarios_actuales_labels.Clear();
            nicknames_actuales.Clear();
            nicknames_photos_actuales.Clear();
            GetUsers(this, new MyUsersEventArgs() { user_name = nicknames_actuales, user_photo = nicknames_photos_actuales });
            int pos_x = 50;
            int pos_y = 110;
            for(int i = 0; i < nicknames_actuales.Count(); i++)
            {
                PictureBox pict = add_buscado_image(pos_x, pos_y, nicknames_actuales[i], nicknames_photos_actuales[i]);
                lista_usuarios_actuales_fotos.Add(pict);
                panel_eliminar_usuario.Controls.Add(pict);
                Label l = add_name_busqueda_label(pos_x + 50, pos_y, nicknames_actuales[i]);
                l.Click += new System.EventHandler(this.OnUserBorrarClick);
                lista_usuarios_actuales_labels.Add(l);
                panel_eliminar_usuario.Controls.Add(l);
                pos_y += 50;
            }

        }

        public void OnUserBorrarClick(object source, EventArgs e)
        {
            const string message = "Estas Seguro que quieres Borrar el Usuario?";
            const string caption = "Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Label currentable = (Label)source;
                OnEraseUser(currentable.Name.Remove(0, 14));
                if (currentable.Name.Remove(0, 14) == user_enter)
                {
                    label_cerrar_sesion_Click(this, new EventArgs());
                }
            }

        }
        private void OnChangePrivate(bool new_Data)
        {
            if (PrivateChanged != null)
            {
                PrivateChanged(this, new RegisterEventArgs() { Private_User = new_Data, Nickname = user_enter});
            }
        }

        private void OnChangePremium(bool new_Data)
        {
            if (PremiumChanged != null)
            {
                PremiumChanged(this, new RegisterEventArgs() { Premium = new_Data, Nickname = user_enter});
            }
        }

        private void OnEraseUser(string user)
        {
            if (EraseUser != null)
            {
                EraseUser(this, new LoginEventArgs() { Nickname = user });
            }
        }
        //Metodos de Informacion con Eventos
        public void OnUserInfo(string Username)
        {
            if (UserInfo != null)
            {
                UserInfo(this, new LoginEventArgs() { Nickname = Username });
            }
        }

        private void OnUserCompleteInfo(string user)
        {
            if (UserCompleteInfo != null)
            {
                UserCompleteInfo(this, new LoginEventArgs() { Nickname = user });
            }
        }

        public void OnPhotoChanged(string username, string path)
        {
            if (ChangedPhoto != null)
            {
                ChangedPhoto(this, new ChangePhotoEventArgs() { Nickname = username, PhotoFile = path, OldPhotoFile = photo_enter });
                photo_enter = path;
                OnUserInfo(username);
            }
        }

        public void OnSongClick(object sender, EventArgs e)
        {
            pictureBox_reproducir_cancion.Visible = true;
            panel2.Visible = true;
            pictureBox_download.Visible = true;
            label_size_cancion.Visible = true;
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            pictureBox_reproducir_cancion.Visible = true;
            pictureBox_download.Visible = true;
            label_size_cancion.Visible = true;
            pictureBox_1star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_2star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_3star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_4star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_5star_Canciones.Image = Properties.Resources.nostar;
            PictureBox currentable = (PictureBox)sender;
            string name_cancion = currentable.Name.Remove(0, 11);
            ShowInfoCancion(this, new AddMultimediaEventArgs() { name_multimedia_file = name_cancion });
            radioButton_add_favorito.Checked = CheckedFavorite(this, new AddMultimediaEventArgs() { name_multimedia_file = name_cancion, user = user_enter });
            if (reproduciendo && multimedia_playing == name_cancion)
            {
                panel_reproductor_cancion.Visible = true;
            }
        }

        public void OnVideoClick(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            panelReproducirVideo.Visible = true;
            pictureBox_reproducir_cancion.Visible = true;
            pictureBox_download.Visible = true;
            label_size_cancion.Visible = true;
            if(checker25 == false)
            {
                panel_reproductor_Video.Visible = false;
            }
            panel7.Visible = true;

            pictureBoxEstrellaVideo1.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo2.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo3.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo4.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo5.Image = Properties.Resources.nostar;

            PictureBox currentable = (PictureBox)sender;
            string name_Video = currentable.Name.Remove(0, 11);
            ShowInfoVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = name_Video });
            radioButtonFavoritoNuevoVideo.Checked = CheckedFavorite(this, new AddMultimediaEventArgs() { name_multimedia_file = name_Video, user = user_enter });
            if (reproduciendo && multimedia_playing == name_Video)
            {
                panel_reproductor_Video.Visible = true;
            }
        }


        public void OnMultimediaRanked(int n)
        {
            List<PictureBox> star_ranked = new List<PictureBox>() { pictureBox_1star_Canciones, pictureBox_2star_Canciones, pictureBox_3star_Canciones, pictureBox_4star_Canciones, pictureBox_5star_Canciones };
            List<PictureBox> star_ranked2 = new List<PictureBox>() { pictureBoxEstrellaVideo1, pictureBoxEstrellaVideo2, pictureBoxEstrellaVideo3, pictureBoxEstrellaVideo4, pictureBoxEstrellaVideo5};
            for (int i = 0; i < 5; i++)
            {
                if (i < n)
                {
                    star_ranked[i].Image = Properties.Resources.star;
                }
                else
                {
                    star_ranked[i].Image = Properties.Resources.nostar;
                }
                label_calificacion.Text = "Se ha calificado correctamente";
            }
            for (int i = 0; i < 5; i++)
            {
                if (i < n)
                {
                    star_ranked2[i].Image = Properties.Resources.star;
                }
                else
                {
                    star_ranked2[i].Image = Properties.Resources.nostar;
                }
                lblCalificacion_ReproducirVideo.Text = "Se ha calificado correctamente";
            }
            if (!panelReproducirVideo.Visible)
            {
                if (RankedSong != null)
                {
                    RankedSong(this, new AddMultimediaEventArgs() { name_multimedia_file = label_info_nombre_cancion.Text, rank = n, user = user_enter });
                }
            }
            else
            {
                if (RankedVideo != null)
                {
                    RankedVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = lblTituloDelVideoAReproducir.Text, rank = n, user = user_enter });
                }
            }
        }

        public void OnSongFavorite(string user, string title)
        {
            if (AddFavoriteSong != null && PutFavoriteSong != null)
            {
                Canciones favorita = AddFavoriteSong(this, new AddMultimediaEventArgs() { name_multimedia_file = title });
                PutFavoriteSong(this, new AddMultimediaEventArgs() { Cancion = favorita, user = user_enter });
            }
        }

        public void OnShowComentariosSong()
        {
            for(int i = 0; i< lista_fotos_comentarios_a_mostrar.Count(); i++)
            {
                panel_comentarios_cancion.Controls.Remove(lista_fotos_comentarios_a_mostrar[i]);
            }
            for (int i = 0; i < lista_labels_comentarios_a_mostrar.Count(); i++)
            {
                panel_comentarios_cancion.Controls.Remove(lista_labels_comentarios_a_mostrar[i]);
            }
            lista_labels_comentarios_a_mostrar.Clear();
            lista_fotos_comentarios_a_mostrar.Clear();
            int comentarios_pos_x = 50;
            int comentarios_pos_y = 240;
            List<string> nickname_usu = GetUserNickComent(this, new AddComentarioEventArgs() { Multimedia_Name = label_info_nombre_cancion.Text });
            List<string> path_foto_perfil_usu = GetUserPhotoComent(this, new AddComentarioEventArgs() { Multimedia_Name = label_info_nombre_cancion.Text });
            List<string> comment_usu = GetUserComent(this, new AddComentarioEventArgs() { Multimedia_Name = label_info_nombre_cancion.Text });
            for (int i = 0; i < nickname_usu.Count(); i++)
            {
                PictureBox pict = add_coment_image(comentarios_pos_x, comentarios_pos_y, nickname_usu[i], path_foto_perfil_usu[i]);
                lista_fotos_comentarios_a_mostrar.Add(pict);
                panel_comentarios_cancion.Controls.Add(pict);
                Label l = add_coment_label(comentarios_pos_x + 80, comentarios_pos_y, nickname_usu[i], comment_usu[i]);
                lista_labels_comentarios_a_mostrar.Add(l);
                panel_comentarios_cancion.Controls.Add(l);
                comentarios_pos_y += 60;
            }
        }

        public void OnBusquedaGeneral(string buscado)
        {
            label_resultados_busquedas_general.Text += " " + buscado;
            List<string> nombre_canciones_buscadas = new List<string>();
            List<string> fotos_canciones_buscadas = new List<string>();
            List<string> nombre_videos_buscados = new List<string>();
            List<string> fotos_videos_buscados = new List<string>();
            List<string> nombre_usuarios_buscados = new List<string>();
            List<string> fotos_usuarios_buscados = new List<string>();
            List<bool> privacidad_usuarios_buscadas = new List<bool>();
            List<string> nombre_personas_buscadas = new List<string>();
            List<string> nombre_playlists_buscadas = new List<string>();
            List<bool> privacidad_playlists_buscadas = new List<bool>();
            GeneralFindPerson(this, new SearchDataEventArgs() { palabra_clave = buscado, nombre_buscado = nombre_personas_buscadas });
            GeneralFindUser(this, new SearchDataEventArgs() { palabra_clave = buscado, nombre_buscado = nombre_usuarios_buscados, fotos_buscadas = fotos_usuarios_buscados, priv_buscadas = privacidad_usuarios_buscadas });
            GeneralFindSong(this, new SearchDataEventArgs() { palabra_clave = buscado, nombre_buscado = nombre_canciones_buscadas, fotos_buscadas = fotos_canciones_buscadas });
            GeneralFindVideo(this, new SearchDataEventArgs() { palabra_clave = buscado, nombre_buscado = nombre_videos_buscados, fotos_buscadas = fotos_videos_buscados });
            GeneralFindPlaylist(this, new SearchDataEventArgs() { palabra_clave = buscado, nombre_buscado = nombre_playlists_buscadas, priv_buscadas = privacidad_playlists_buscadas });
            Informacion_Busqueda_General(nombre_canciones_buscadas, fotos_canciones_buscadas, nombre_videos_buscados, fotos_videos_buscados,
                nombre_playlists_buscadas, privacidad_playlists_buscadas, nombre_usuarios_buscados, fotos_usuarios_buscados, privacidad_usuarios_buscadas,
                nombre_personas_buscadas);
        }

        public void OnBusquedaOr(List<string> palabras_clave, List<string> personas_clave, int edad_clave, int condicion_edad, string sexo_clave,
            int duracion_clave, int condicion_duracion, int calidad_clave, int condicion_calidad, List<string> generos_clave, decimal calificacion_ranking,
            int calificacion_condicion)
        {
            List<string> nombres_canciones_encontradas = new List<string>();
            List<string> fotos_canciones_encontradas = new List<string>();
            OrSearchMusic(this, new DetailSearchEventArgs()
            {
                calidad = calidad_clave,
                calidad_condition = condicion_calidad,
                duration = duracion_clave,
                duration_condition = condicion_duracion,
                edad_clave = edad_clave,
                edad_condition = condicion_edad,
                genero_clave = sexo_clave,
                nombres_claves = palabras_clave,
                categorias_clave = generos_clave,
                personas_claves = personas_clave,
                fotos_encontradas = fotos_canciones_encontradas,
                titulos_encontrados = nombres_canciones_encontradas,
                ranking = calificacion_ranking,
                ranking_condition = calificacion_condicion
            });
            List<string> nombres_videos_encontrados = new List<string>();
            List<string> fotos_videos_encontradas = new List<string>();
            OrSearchVideo(this, new DetailSearchEventArgs()
            {
                calidad = calidad_clave,
                calidad_condition = condicion_calidad,
                duration = duracion_clave,
                duration_condition = condicion_duracion,
                edad_clave = edad_clave,
                edad_condition = condicion_edad,
                genero_clave = sexo_clave,
                nombres_claves = palabras_clave,
                categorias_clave = generos_clave,
                personas_claves = personas_clave,
                fotos_encontradas = fotos_videos_encontradas,
                titulos_encontrados = nombres_videos_encontrados,
                ranking = calificacion_ranking,
                ranking_condition = calificacion_condicion
            });
            Informacion_Busqueda_Especifica(nombres_canciones_encontradas, fotos_canciones_encontradas, nombres_videos_encontrados,
                fotos_videos_encontradas);
        }

        public void OnBusquedaAnd(List<string> palabras_clave, List<string> personas_clave, int edad_clave, int condicion_edad, string sexo_clave,
            int duracion_clave, int condicion_duracion, int calidad_clave, int condicion_calidad, List<string> generos_clave, decimal calificacion_ranking,
            int calificacion_condicion)
        {
            List<string> nombres_canciones_encontradas = new List<string>();
            List<string> fotos_canciones_encontradas = new List<string>();
            AndSearchMusic(this, new DetailSearchEventArgs()
            {
                calidad = calidad_clave,
                calidad_condition = condicion_calidad,
                duration = duracion_clave,
                duration_condition = condicion_duracion,
                edad_clave = edad_clave,
                edad_condition = condicion_edad,
                genero_clave = sexo_clave,
                nombres_claves = palabras_clave,
                categorias_clave = generos_clave,
                personas_claves = personas_clave,
                fotos_encontradas = fotos_canciones_encontradas,
                titulos_encontrados = nombres_canciones_encontradas,
                ranking = calificacion_ranking,
                ranking_condition = calificacion_condicion
            });
            List<string> nombres_videos_encontrados = new List<string>();
            List<string> fotos_videos_encontradas = new List<string>();
            AndSearchVideo(this, new DetailSearchEventArgs()
            {
                calidad = calidad_clave,
                calidad_condition = condicion_calidad,
                duration = duracion_clave,
                duration_condition = condicion_duracion,
                edad_clave = edad_clave,
                edad_condition = condicion_edad,
                genero_clave = sexo_clave,
                nombres_claves = palabras_clave,
                categorias_clave = generos_clave,
                personas_claves = personas_clave,
                fotos_encontradas = fotos_videos_encontradas,
                titulos_encontrados = nombres_videos_encontrados,
                ranking = calificacion_ranking,
                ranking_condition = calificacion_condicion
            });
            Informacion_Busqueda_Especifica(nombres_canciones_encontradas, fotos_canciones_encontradas, nombres_videos_encontrados,
                fotos_videos_encontradas);
        }

        public void OnGetFavorites()
        {
            List<string> titulos_canciones_favoritas = new List<string>();
            List<string> fotos_canciones_favoritas = new List<string>();
            List<string> titulos_videos_favoritas = new List<string>();
            List<string> fotos_videos_favoritas = new List<string>();
            MyFavs(this, new AddMultimediaEventArgs()
            {
                user = user_enter,
                can_favs = titulos_canciones_favoritas,
                can_foto_favs = fotos_canciones_favoritas,
                vid_favs = titulos_videos_favoritas,
                vid_foto_favs = fotos_videos_favoritas
            });
            ShowMyFavorites(titulos_canciones_favoritas, fotos_canciones_favoritas, titulos_videos_favoritas, fotos_videos_favoritas);
            
        }

        #endregion


        #region output
        //Outputs
        public void set_profile(string username, string pathfile)
        {
            label_NombreUsuario.Text = username;
            if (pathfile != "")
            {

                FotoPerfil.BackgroundImage = Image.FromFile(pathfile);

            }
            FotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void info_user(string username, int edad, bool priv, bool prem, int seguidores)
        {
            label_info_Nombre.Text = "Nombre: " + username;
            label_infoEdad.Text = "Edad: " + edad;
            if (priv)
            {
                label_infoPrivate.Text = "Privacidad: Usuario Privado";
            }
            else
            {
                label_infoPrivate.Text = "Privacidad: Usuario Publico";
            }
            if (prem)
            {
                label_info_tipo_usuario.Text = "Tipo de Usuario: Usuario Premium";
            }
            else
            {
                label_info_tipo_usuario.Text = "Tipo de Usuario: Usuario Gratuito";
            }
            label_infoSeguidores.Text = "Seguidores: " + seguidores;

        }

        public void Informacion_Cancion(string nombre, List<string> artistas, List<string> generos, string album,
            int duracion, string estudio, string photo_path, decimal ranking, int visitas, string descripcion, long size,string fecha)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            label_info_nombre_cancion.Text = nombre;
            label_cancion_Artistas.Text = "Fecha de inclusion: "+fecha+"\nArtistas:\n";
            label_cancion_Artistas.Width = 200;
            foreach(string data in artistas)
            {
                label_cancion_Artistas.Text += data + "\n";
            }
            label_info_genero_cancion.Text = "Generos: ";
            foreach(string data in generos)
            {
                label_info_genero_cancion.Text += data + ",";
            }
            label_info_genero_cancion.Text.Remove(label_info_genero_cancion.Text.Length - 1);
            label_info_cancion_duracion.Text = "Duracion: " + Convert.ToInt32((duracion / 3600)) + ":";
            if ((duracion / 60) < 10)
            {
                label_info_cancion_duracion.Text += "0" + Convert.ToInt32((duracion / 60)) + ":";
            }
            else
            {
                label_info_cancion_duracion.Text += Convert.ToInt32((duracion / 60)) + ":";
            }
            if (duracion % 60 < 10)
            {
                label_info_cancion_duracion.Text += "0" + (duracion % 60);
            }
            else
            {
                label_info_cancion_duracion.Text += (duracion % 60);
            }
            decimal rank_red = Math.Round(Convert.ToDecimal(ranking), 2);
            label_info_cancion_estudio.Text = "Estudio: " + estudio;
            label_cancion_info_album.Text = "Album:" + album;
            pictureBox_foto_cancion.ImageLocation = photo_path;
            label_calificacion_cancion.Text = "Nota: " + rank_red + "/5";
            label_visitas_cancion.Text = "Visitas: " + visitas;
            label_cancion_descripcion.Text = "Descripcion:\n" + descripcion;
            label_size_cancion.Text = "Tamaño:\n" + size + " MB";
        }

        public void Informacion_video(string nombre, List<string> directores, List<string> actores, List<string> generos,
    int duracion, string estudio, string photo_path, decimal ranking, int visitas, string descripcion, string fecha)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            lblTituloDelVideoAReproducir.Text = nombre;
            lblDirectores_ReproducirVideo.Text ="Fecha de ingreso: "+fecha +"\nDirectores:";
            lblDirectores_ReproducirVideo.Width = 200;
            foreach (string data in directores)
            {
                lblDirectores_ReproducirVideo.Text += data + "\n";
            }
            lblActores_reproducirvideo.Text = "Actores:";
            lblActores_reproducirvideo.Width = 200;
            foreach (string data in actores)
            {
                lblActores_reproducirvideo.Text += data + "\n";
            }
            lblGeneroReproducirVideo.Text = "Generos: ";
            foreach (string data in generos)
            {
                lblGeneroReproducirVideo.Text += data + ",";
            }


            lblDuracionReproducirvideo.Text = "Duracion: " + Convert.ToInt32((duracion / 3600)) + ":";
            if ((duracion / 60) < 10)
            {
                lblDuracionReproducirvideo.Text += "0" + Convert.ToInt32((duracion / 60)) + ":";
            }
            else
            {
                lblDuracionReproducirvideo.Text += Convert.ToInt32((duracion / 60)) + ":";
            }
            if (duracion % 60 < 10)
            {
                lblDuracionReproducirvideo.Text += "0" + (duracion % 60);
            }
            else
            {
                lblDuracionReproducirvideo.Text += (duracion % 60);
            }
            decimal rank_red = Math.Round(Convert.ToDecimal(ranking),2);
            lblEstudioReproducirVideo.Text = "Estudio: " + estudio;
            pictureBox_Portada_VideoAlReproducir.ImageLocation = photo_path;
            lblNotaReproducirvideo.Text = "Nota: " + rank_red + "/5";
            lblVisitasReproducirVideo.Text = "Visitas: " + visitas;
            lblDescripcionReproducirVideo.Text = "Descripcion:\n" + descripcion;
        }




        public void Informacion_Busqueda_General(List<string> name_song, List<string> foto_song, List<string> name_video, List<string> foto_video,
            List<string> name_playlists, List<bool> priv_playlist, List<string> name_users, List<string> foto_users, List<bool> priv_users,
            List<string> name_persona)
        {
            int pos_x = 50;
            int pos_y = 110;
            for (int i = 0; i < lista_fotos_resultados_busquedas.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_fotos_resultados_busquedas[i]);
            }
            for (int i = 0; i < lista_labels_resultado_busqeuda.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_resultado_busqeuda[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_labels_resultado_busqeuda.Clear();
            lista_fotos_resultados_busquedas.Clear();
            lista_labels_secciones.Clear();
            if (name_song.Count() > 0)
            {
                Label song_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Canciones");
                panel_resultado_busqueda_general.Controls.Add(song_seccion);
                lista_labels_secciones.Add(song_seccion);
                pos_y += 45;
                for (int i = 0; i < name_song.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_song[i], foto_song[i]);
                    panel_resultado_busqueda_general.Controls.Add(pict);
                    lista_fotos_resultados_busquedas.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_song[i]);
                    lista_labels_resultado_busqeuda.Add(l);
                    l.Click += new System.EventHandler(this.OnSongClickedBySearch);
                    panel_resultado_busqueda_general.Controls.Add(l);
                    pos_y += 50;
                }
            }
            if (name_video.Count() > 0)
            {
                Label video_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Videos");
                panel_resultado_busqueda_general.Controls.Add(video_seccion);
                lista_labels_secciones.Add(video_seccion);
                pos_y += 45;
                for (int i = 0; i < name_video.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_video[i], foto_video[i]);
                    panel_resultado_busqueda_general.Controls.Add(pict);
                    lista_fotos_resultados_busquedas.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_video[i]);
                    lista_labels_resultado_busqeuda.Add(l);
                    l.Click += new System.EventHandler(this.OnVideoClickedBySearch);
                    panel_resultado_busqueda_general.Controls.Add(l);
                    pos_y += 50;
                }
            }
            if (name_playlists.Count() > 0)
            {
                Label playlist_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Playlists");
                panel_resultado_busqueda_general.Controls.Add(playlist_seccion);
                lista_labels_secciones.Add(playlist_seccion);
                pos_y += 45;
                for (int i = 0; i < name_playlists.Count(); i++)
                {
                    Label l = add_name_busqueda_label(pos_x, pos_y, name_playlists[i]);
                    lista_labels_resultado_busqeuda.Add(l);
                    l.Click += new System.EventHandler(this.OnPlaylistClickedBySearch);
                    panel_resultado_busqueda_general.Controls.Add(l);
                    pos_y += 50;
                }
            }
            if (name_users.Count() > 0)
            {
                Label usuario_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Usuarios");
                panel_resultado_busqueda_general.Controls.Add(usuario_seccion);
                lista_labels_secciones.Add(usuario_seccion);
                pos_y += 45;
                for (int i = 0; i < name_users.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_users[i], foto_users[i]);
                    lista_fotos_resultados_busquedas.Add(pict);
                    panel_resultado_busqueda_general.Controls.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_users[i]);
                    l.Click += new System.EventHandler(this.OnUserClicked);
                    lista_labels_resultado_busqeuda.Add(l);
                    panel_resultado_busqueda_general.Controls.Add(l);
                    pos_y += 50;
                }
            }
            if (name_persona.Count() > 0)
            {
                Label personas_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Personas");
                panel_resultado_busqueda_general.Controls.Add(personas_seccion);
                lista_labels_secciones.Add(personas_seccion);
                pos_y += 45;
                for (int i = 0; i < name_persona.Count(); i++)
                {
                    Label l = add_name_busqueda_label(pos_x, pos_y, name_persona[i]);
                    l.Click += new System.EventHandler(this.OnArtistClicked);
                    lista_labels_resultado_busqeuda.Add(l);
                    panel_resultado_busqueda_general.Controls.Add(l);
                    pos_y += 50;
                }
            }
        }

        public void OnPlaylistClickedBySearch(object sender, EventArgs e)
        {
            const string message = "Deseas reproducir esta playlist?";
            const string caption = "Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                panel_playlist_mostrar.Visible = true;
                panel_playlist.Visible = true;
                panel_resultado_busqueda_avanzada.Visible = true;
                ReproductorVideo.Ctlcontrols.pause();
                ReproductorCancion.Ctlcontrols.pause();                
                ReproducirPlaylist.Visible = true;
                panel_playlist_mostrar.Visible = true;
                panel_playlist.Visible = true;
                panel_ajustes.Visible = true;
                panel_informacion.Visible = true;
                panel_title_add_cancion.Visible = true;
                panel_datos_add_cancion.Visible = true;
                panel_fijar_add_cancion.Visible = true;
                panel_De_Agregar_Video.Visible = true;
                panelAgregarunVid.Visible = true;
                panel_info_cancion.Visible = true;
                panel_fijar_info_cancion.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel_resultado_busqueda_avanzada.Visible = false;
                panel_resultado_busqueda_general.Visible = false;
                panel_comentarios_cancion.Visible = false;
                Label currentable = (Label)sender;
                string name = currentable.Name.Remove(0, 14);
                Playlist p = UserPlaylists(this, new AddPlaylistEventArgs() { names = name });
                Reproductor_de_Playlist.currentPlaylist = Reproductor_de_Playlist.newPlaylist(p.Name, "");
                for (int i = 0; i < p.Playlist_canciones1.Count; i++)
                {
                    Reproductor_de_Playlist.currentPlaylist.appendItem(Reproductor_de_Playlist.newMedia(p.Playlist_canciones1[i].Carpeta_archivo));
                }
                ////play
                Reproductor_de_Playlist.Ctlcontrols.play();
            }
        }

        public void Informacion_Busqueda_Especifica(List<string> name_canciones, List<string> fotos_canciones, List<string> name_videos,
            List<string> fotos_videos)
        {
            panel_playlist_mostrar.Visible = true;
            panel_playlist.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_playlist.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_info_artista.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel3.Visible = true;
            panel_info_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_informacion.Visible = true;
            panel_ajustes.Visible = true;
            panelComentarios_Video.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            Mis_Playlist_Eliminar.Visible = false;
            panel_Ranking_de_Canciones.Visible = false;
            panel_Mostrar_Ranking_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panelRecomendaciones.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = true;
            for (int i = 0; i < lista_fotos_encontradas_especifica.Count(); i++)
            {
                panel_resultado_busqueda_avanzada.Controls.Remove(lista_fotos_encontradas_especifica[i]);
            }
            for (int i = 0; i < lista_titulos_encontradas_especifica.Count(); i++)
            {
                panel_resultado_busqueda_avanzada.Controls.Remove(lista_titulos_encontradas_especifica[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_resultado_busqueda_avanzada.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_fotos_encontradas_especifica.Clear();
            lista_titulos_encontradas_especifica.Clear();
            lista_labels_secciones.Clear();
            int pos_x = 50;
            int pos_y = 110;
            if (name_canciones.Count() > 0)
            {
                Label song_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Canciones");
                panel_resultado_busqueda_avanzada.Controls.Add(song_seccion);
                lista_labels_secciones.Add(song_seccion);
                pos_y += 45;
                for (int i = 0; i < name_canciones.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_canciones[i], fotos_canciones[i]);
                    panel_resultado_busqueda_avanzada.Controls.Add(pict);
                    lista_fotos_encontradas_especifica.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_canciones[i]);
                    lista_titulos_encontradas_especifica.Add(l);
                    l.Click += new System.EventHandler(this.OnSongClickedBySearch);
                    panel_resultado_busqueda_avanzada.Controls.Add(l);
                    pos_y += 50;
                }
            }
            if (name_videos.Count() > 0)
            {
                Label video_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Videos");
                panel_resultado_busqueda_avanzada.Controls.Add(video_seccion);
                lista_labels_secciones.Add(video_seccion);
                pos_y += 45;
                for (int i = 0; i < name_videos.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_videos[i], fotos_videos[i]);
                    panel_resultado_busqueda_avanzada.Controls.Add(pict);
                    lista_fotos_encontradas_especifica.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_videos[i]);
                    lista_titulos_encontradas_especifica.Add(l);
                    l.Click += new System.EventHandler(this.OnVideoClickedBySearch);
                    panel_resultado_busqueda_avanzada.Controls.Add(l);
                    pos_y += 50;
                }
            }
        }

        public void ShowMyFavorites(List<string> name_canciones, List<string> fotos_canciones, List<string> name_videos,
            List<string> fotos_videos)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            ReproducirPlaylist.Visible = true;
            panel_playlist_mostrar.Visible = true;
            panel_playlist.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            panel_favoritos.Visible = true;
            panelComentarios_Video.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panel_de_rankings.Visible = false;
            for (int i = 0; i < lista_fotos_encontradas_favorita.Count(); i++)
            {
                panel_favoritos.Controls.Remove(lista_fotos_encontradas_favorita[i]);
            }
            for (int i = 0; i < lista_titulos_encontradas_favorita.Count(); i++)
            {
                panel_favoritos.Controls.Remove(lista_titulos_encontradas_favorita[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_favoritos.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_fotos_encontradas_favorita.Clear();
            lista_titulos_encontradas_favorita.Clear();
            lista_labels_secciones.Clear();
            int pos_x = 50;
            int pos_y = 110;
            if (name_canciones.Count() > 0)
            {
                Label song_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Canciones");
                panel_favoritos.Controls.Add(song_seccion);
                lista_labels_secciones.Add(song_seccion);
                pos_y += 45;
                for (int i = 0; i < name_canciones.Count(); i++)
                {
                    if (name_canciones[i] != "")
                    {
                        PictureBox pict = add_buscado_image(pos_x, pos_y, name_canciones[i], fotos_canciones[i]);
                        panel_favoritos.Controls.Add(pict);
                        lista_fotos_encontradas_favorita.Add(pict);
                        Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_canciones[i]);
                        lista_titulos_encontradas_favorita.Add(l);
                        l.Click += new System.EventHandler(this.OnSongClickedBySearch);
                        panel_favoritos.Controls.Add(l);
                        pos_y += 50;
                    }
                }
            }
            if (name_videos.Count() > 0)
            {
                Label video_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Videos");
                panel_favoritos.Controls.Add(video_seccion);
                lista_labels_secciones.Add(video_seccion);
                pos_y += 45;
                for (int i = 0; i < name_videos.Count(); i++)
                {
                    if (name_videos[i] != "")
                    {
                        PictureBox pict = add_buscado_image(pos_x, pos_y, name_videos[i], fotos_videos[i]);
                        panel_favoritos.Controls.Add(pict);
                        lista_fotos_encontradas_favorita.Add(pict);
                        Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_videos[i]);
                        lista_titulos_encontradas_favorita.Add(l);
                        l.Click += new System.EventHandler(this.OnVideoClickedBySearch);
                        panel_favoritos.Controls.Add(l);
                        pos_y += 50;
                    }
                }
            }
        }

        public void OnSongClickedBySearch(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            pictureBox_reproducir_cancion.Visible = true;
            pictureBox_download.Visible = true;
            label_size_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel_usuario_buscado.Visible = false;

            pictureBox_1star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_2star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_3star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_4star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_5star_Canciones.Image = Properties.Resources.nostar;

            Label currentable = (Label)sender;
            string name_cancion = currentable.Name.Remove(0, 14);
            ShowInfoCancion(this, new AddMultimediaEventArgs() { name_multimedia_file = name_cancion });
            radioButton_add_favorito.Checked = CheckedFavorite(this, new AddMultimediaEventArgs() { name_multimedia_file = name_cancion, user = user_enter });
            if (reproduciendo && multimedia_playing == name_cancion)
            {
                panel_reproductor_cancion.Visible = true;
            }
        }

        public void OnUserClicked(object sender, EventArgs e)
        {
            panel_usuario_buscado.Visible = true;
            Label currentable = (Label)sender;
            string name_usuario = currentable.Name.Remove(0, 14);
            SearchedUserInfo(this, new LoginEventArgs() { Nickname = name_usuario });
        }

        public void OnArtistClicked(object sender, EventArgs e)
        {
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            Label currentable = (Label)sender;
            string name_artista = currentable.Name.Remove(0, 14);
            SearchedPersonInfo(this, new LoginEventArgs() { Nickname = name_artista });
        }

        public void ShowSearchedUserInfo(string nickname, string name, int edad, bool type, bool premium, List<string> nombre_canciones_subidas, 
            List<string> fotos_canciones_subidas, List<string> nombre_videos_subidos, List<string> fotos_videos_subidos, int seguidores, string foto)
        {
            for (int i = 0; i < lista_fotos_resultados_busquedas.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_fotos_resultados_busquedas[i]);
            }
            for (int i = 0; i < lista_labels_resultado_busqeuda.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_resultado_busqeuda[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_fotos_resultados_busquedas.Clear();
            lista_labels_resultado_busqeuda.Clear();
            lista_labels_secciones.Clear();
            bool result_seguir = CanFollowUser(this, new FollowEventArgs() { user_new_follower = user_enter, user_following = nickname });
            if (!result_seguir)
            {
                button_seguir_usuario.Text = "Seguido";
            }
            else
            {
                button_seguir_usuario.Text = "Seguir";
            }
            for (int i = 0; i < lista_fotos_cosas_subidas.Count(); i++)
            {
                panel_usuario_buscado.Controls.Remove(lista_fotos_cosas_subidas[i]);
            }
            for (int i = 0; i < lista_labels_cosas_subidas.Count(); i++)
            {
                panel_usuario_buscado.Controls.Remove(lista_labels_cosas_subidas[i]);
            }
            lista_fotos_cosas_subidas.Clear();
            lista_labels_cosas_subidas.Clear();
            label_nickname_usuario.Text = nickname;
            label_seguidores.Text = "Seguidores: " + seguidores;
            label_info_usuario.Text = "Informacion del Usuario:\n";
            pictureBox_foto_perfil_usuario_buscado.ImageLocation = foto;
            pictureBox_foto_perfil_usuario_buscado.SizeMode = PictureBoxSizeMode.StretchImage;
            if (type && nickname != user_enter)
            {
                label_info_usuario.Text += "No se puede mostrar esta informacion\nporque es privada";
                label_archivos_subidos_por_usuario.Visible = false;
            }
            else
            {
                label_archivos_subidos_por_usuario.Visible = true;
                label_info_usuario.Text += "Nombre: " + name + "\nEdad: " + edad;
                if (premium)
                {
                    label_info_usuario.Text += "\nUsuario Premium";
                }
                else
                {
                    label_info_usuario.Text += "\nUsuario Free";
                }
                int pos_x = 80;
                int pos_y = 350;
                
                for (int i = 0; i < nombre_canciones_subidas.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, nombre_canciones_subidas[i], nombre_canciones_subidas[i]);
                    panel_usuario_buscado.Controls.Add(pict);
                    lista_fotos_cosas_subidas.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, nombre_canciones_subidas[i]);
                    lista_labels_cosas_subidas.Add(l);
                    l.Click += new System.EventHandler(this.OnSongClickedBySearch);
                    panel_usuario_buscado.Controls.Add(l);
                    pos_y += 50;
                }
                for (int i = 0; i < nombre_videos_subidos.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, nombre_videos_subidos[i], nombre_videos_subidos[i]);
                    panel_usuario_buscado.Controls.Add(pict);
                    lista_fotos_cosas_subidas.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, nombre_videos_subidos[i]);
                    l.Click += new System.EventHandler(this.OnVideoClickedBySearch);
                    lista_labels_resultado_busqeuda.Add(l);
                    panel_usuario_buscado.Controls.Add(l);
                    pos_y += 50;
                }
            }
        }

        public void ShowSearchedPersona(string nombre, string trabajo, int edad, int seguidores, List<string> fotos_canciones_trabajos, 
            List<string> nombre_canciones_trabajos, List<string> fotos_videos_trabajos, List<string> nombre_videos_trabajos)
        {
            for (int i = 0; i < lista_fotos_resultados_busquedas.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_fotos_resultados_busquedas[i]);
            }
            for (int i = 0; i < lista_labels_resultado_busqeuda.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_resultado_busqeuda[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_secciones[i]);
            }
            label_info_nombre_artista.Text = nombre;
            label_info_ocupacion_artista.Text = "Ocupacion: " + trabajo;
            label_info_edad_Artista.Text = "Edad: " + edad;
            label_info_artista_seguidores.Text = "Seguidores: " + seguidores;
            for(int i = 0; i < lista_fotos_artistas.Count(); i++)
            {
                panel_info_artista.Controls.Remove(lista_fotos_artistas[i]);
            }
            for (int i = 0; i < lista_labels_artistas.Count(); i++)
            {
                panel_info_artista.Controls.Remove(lista_labels_artistas[i]);
            }
            lista_fotos_artistas.Clear();
            lista_labels_artistas.Clear();
            bool result_seguir = CanFollowPerson(this, new FollowEventArgs() { user_new_follower = user_enter, user_following = nombre });
            if (!result_seguir)
            {
                button_seguir_artista.Text = "Seguido";
            }
            else
            {
                button_seguir_artista.Text = "Seguir";
            }
            int pos_x = 90;
            int pos_y = 315;
            for (int i = 0; i < nombre_canciones_trabajos.Count(); i++)
            {
                PictureBox pict = add_buscado_image(pos_x, pos_y, nombre_canciones_trabajos[i], fotos_canciones_trabajos[i]);
                panel_info_artista.Controls.Add(pict);
                lista_fotos_artistas.Add(pict);
                Label l = add_name_busqueda_label(pos_x + 50, pos_y, nombre_canciones_trabajos[i]);
                lista_labels_artistas.Add(l);
                l.Click += new System.EventHandler(this.OnSongClickedBySearch);
                panel_info_artista.Controls.Add(l);
                pos_y += 50;
            }
            for (int i = 0; i < nombre_videos_trabajos.Count(); i++)
            {
                PictureBox pict = add_buscado_image(pos_x, pos_y, nombre_videos_trabajos[i], fotos_videos_trabajos[i]);
                panel_info_artista.Controls.Add(pict);
                lista_fotos_artistas.Add(pict);
                Label l = add_name_busqueda_label(pos_x + 50, pos_y, nombre_videos_trabajos[i]);
                lista_labels_artistas.Add(l);
                panel_info_artista.Controls.Add(l);
                pos_y += 50;
            }
        }


        #endregion

        #region create_items
        Label add_multimedia_label(int x, int y, string nombre)
        {
            Label label_multimedia = new Label();
            label_multimedia.Name = "label_" + nombre;
            label_multimedia.Text = nombre;
            label_multimedia.ForeColor = Color.Black;
            label_multimedia.Width = 140;
            label_multimedia.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            label_multimedia.Location = new Point(x, y);
            return label_multimedia;
        }

        Label add_coment_label(int x, int y, string user, string comentario)
        {
            Label label_coment = new Label();
            label_coment.Text = user + ":\n" + comentario;
            label_coment.ForeColor = Color.Black;
            label_coment.Width = 300;
            label_coment.Height = 40;
            label_coment.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            label_coment.Location = new Point(x, y);
            return label_coment;
        }

        Label add_seccion_busqueda_label(int x, int y, string seccion)
        {
            Label label_subtitle = new Label();
            label_subtitle.Text = seccion;
            if (seccion.Contains("os"))
            {
                label_subtitle.Text += " encontrados";
            }
            else
            {
                label_subtitle.Text += " encontradas";
            }
            label_subtitle.ForeColor = Color.Black;
            label_subtitle.Width = 300;
            label_subtitle.Height = 30;
            label_subtitle.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            label_subtitle.Location = new Point(x, y);
            return label_subtitle;
        }

        Label add_name_busqueda_label(int x, int y, string titulo)
        {
            Label label_buscado = new Label(); 
            label_buscado.Name = "label_buscado_" + titulo;
            label_buscado.Text = titulo;
            label_buscado.ForeColor = Color.Black;
            label_buscado.Width = 300;
            label_buscado.Height = 45;
            label_buscado.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            label_buscado.Location = new Point(x, y);
            return label_buscado;
        }

        PictureBox add_multimedia_image(int x, int y, string nombre, string path)
        {
            PictureBox picture_multimedia = new PictureBox();

            picture_multimedia.Name = "pictureBox_" + nombre;
            picture_multimedia.ImageLocation = path;

            if(y == 40 && (path == "" || path == null))
            {
                picture_multimedia.Image = Properties.Resources.icon_cancion;
            }
            else if(y == 70 && (path == "" || path == null))
            {
                picture_multimedia.Image = Properties.Resources.video_icon;
            }
            picture_multimedia.Width = 140;
            picture_multimedia.Height = 140;
            picture_multimedia.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_multimedia.BackColor = Color.Black;
            picture_multimedia.Location = new Point(x, y);
            return picture_multimedia;
        }

        PictureBox add_coment_image(int x, int y, string user, string path)
        {
            PictureBox picture_comentario = new PictureBox();
            picture_comentario.ImageLocation = path;
            picture_comentario.Width = 40;
            picture_comentario.Height = 40;
            picture_comentario.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_comentario.BackColor = Color.Black;
            picture_comentario.Location = new Point(x, y);
            return picture_comentario;
        }

        PictureBox add_buscado_image(int x, int y, string titulo, string path)
        {
            panel3.Visible = true;
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            label_size_cancion.Visible = true;
            OnDeleteSong();
            PictureBox picture_buscado = new PictureBox();
            picture_buscado.Name = "pictureBox_Buscado_" + titulo;
            picture_buscado.ImageLocation = path;
            picture_buscado.Width = 40;
            picture_buscado.Height = 40;
            picture_buscado.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_buscado.BackColor = Color.Black;
            picture_buscado.Location = new Point(x, y);
            return picture_buscado;
        }


        #endregion

        private void pictureBox_atras_busqueda_general_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista_fotos_resultados_busquedas.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_fotos_resultados_busquedas[i]);
            }
            for (int i = 0; i < lista_labels_resultado_busqeuda.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_resultado_busqeuda[i]);
            }
            for(int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panel_resultado_busqueda_general.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_fotos_resultados_busquedas.Clear();
            lista_labels_resultado_busqeuda.Clear();
            lista_labels_secciones.Clear();
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel_ajustes.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e) //Back de Ir a otro usuario
        {
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel_reproductor_cancion.Visible = false;
            pictureBox_reproducir_cancion.Visible = false;
            pictureBox_download.Visible = false;
            label_size_cancion.Visible = false;
            label_mensaje_cancion_descargada.Visible = false;
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_comentarios_cancion.Visible = false;
        }

        private void button_seguir_usuario_Click(object sender, EventArgs e)
        {
            bool result = CanFollowUser(this, new FollowEventArgs() { user_new_follower = user_enter, user_following = label_nickname_usuario.Text });
            if (result)
            {
                FollowUser(this, new FollowEventArgs() { user_new_follower = user_enter, user_following = label_nickname_usuario.Text });
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Boton de Atras de artista al inicio
        {
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel_reproductor_cancion.Visible = false;
            pictureBox_reproducir_cancion.Visible = false;
            pictureBox_download.Visible = false;
            label_size_cancion.Visible = false;
            label_mensaje_cancion_descargada.Visible = false;
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_info_artista.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(1);
        }

        private void pictureBoxEstrellaVideo2_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(2);
        }

        private void pictureBoxEstrellaVideo3_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(3);
        }

        private void pictureBoxEstrellaVideo4_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(4);
        }

        private void pictureBoxEstrellaVideo5_Click(object sender, EventArgs e)
        {
            OnMultimediaRanked(5);
        }

        private void pictureBoxregresar_desde_reproducirvideo_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_info_artista.Visible = false;
            panelReproducirVideo.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel_reproductor_Video.Visible = false;
        }
        private void button_seguir_artista_Click(object sender, EventArgs e)
        {
            bool result = CanFollowPerson(this, new FollowEventArgs() { user_new_follower = user_enter, user_following = label_info_nombre_artista.Text });
            if (result)
            {
                FollowPerson(this, new FollowEventArgs() { user_new_follower = user_enter, user_following = label_info_nombre_artista.Text });
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) //Atras busqueda avanzada
        {
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_info_artista.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_busqueda_avanzada.Visible = false;
        }

        private void button_buscar_filtro_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panel_favoritos.Visible = false;
            panel_playlist.Visible = false;
            panel_playlist_mostrar.Visible = false;
            textBox_edad_personas_buscar.ResetText();
            textBox_genero_busqueda.ResetText();
            textBox_nombre_personas_buscar.ResetText();
            textBox_buscar_duracion.ResetText();
            textBox_palabras_clave_buscar.ResetText();
            textBox_buscar_Calidad.ResetText();
            checkBox_buscar_hombre.Checked = false;
            checkBox_buscar_mujer.Checked = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ReproductorCancion.Ctlcontrols.pause();
            Reproductor_de_Playlist.Ctlcontrols.pause();
            panel_reproductor_Video.Visible = true;
            string name_video = lblTituloDelVideoAReproducir.Text;
            List<Video> p = GetColaVideo(this, new LoginEventArgs() { Nickname = user_enter });
            if (p != null)
            {
                PictureBox currentable = (PictureBox)sender;
                string url_cancion = ReproducirVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = name_video });
                multimedia_playing = name_video;
                reproduciendo = true;
                ReproductorVideo.currentPlaylist = ReproductorVideo.newPlaylist("", "");//ingresar nombre de la cola
                ReproductorVideo.currentPlaylist.appendItem(ReproductorVideo.newMedia(url_cancion));
                for (int i = 0; i < p.Count; i++)
                {
                    ReproductorVideo.currentPlaylist.appendItem(ReproductorVideo.newMedia(p[i].Carpeta_archivo));

                }
                ReproductorVideo.Ctlcontrols.play();
            }
            else if (name_video != multimedia_playing)
            {
                string url_video = ReproducirVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = name_video });
                ReproductorVideo.URL = @url_video;
                multimedia_playing = name_video;
                reproduciendo = true;
            }
        }
        private void OnGeneratePlaylist(string name, List<Canciones> listSong, List<Video> listVideo,bool privado,string foto)
        {
            if (GeneratePlaylist !=  null)
            {
                GeneratePlaylist(this, new AddPlaylistEventArgs() {names = name,canciones = listSong,videos = listVideo,privado = privado,foto = foto });
            }
        }

        int yPV = -130;
        
        private void Add_Cancion_Playlist_Click(object sender, EventArgs e)
        {
            bool pivote = true;
            bool test = true;
            for (int i = 0; i < panel_playlist_mostrar.Controls.Count; i++)
            {
                if (panel_playlist_mostrar.Controls[i].Name == textBox_Nombre_playlist_canciones.Text)
                {
                    pivote = false;
                }
            }

            if (Check_Canciones_agregar_playlist.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna canción", "ERROR DE SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox_Nombre_playlist_canciones.Text == "")
            {
                MessageBox.Show("No se ha ingresado ningun nombre para la playlist", "ERROR DE NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pivote == false)
            {
                MessageBox.Show("El Nombre ingresado ya existe", "ERROR DE NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = 60;
                yPV += 175;
                List<string> mylist = new List<string>();

                foreach (string canciones in Check_Canciones_agregar_playlist.CheckedItems)
                {
                    mylist.Add(canciones);
                }

                PictureBox pict = new PictureBox();
                const string message = "Deseas agregar una foto a tu playlist?";
                const string caption = "Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                string path = "";
                if (result == DialogResult.Yes)
                {

                    OpenFileDialog find_path = new OpenFileDialog();
                    find_path.Filter = "Image File (*.jpg; *.jpeg; *.bmp;) |*.jpg; *.jpeg; *.bmp; |(*.png; *.jpeg; *.bmp;) |*.png; *.jpeg; *.bmp; ";
                    if (find_path.ShowDialog() == DialogResult.OK)
                    {
                        path = find_path.FileName;
                    }
                }
                else
                {                  
                    pict.Image = Properties.Resources.CPlaylist;
                    test = false;
                }
                pict.Name = textBox_Nombre_playlist_canciones.Text;
                if(test == true)
                {
                    pict.ImageLocation = path;
                }            
                pict.Width = 140;
                pict.Height = 140;
                pict.SizeMode = PictureBoxSizeMode.StretchImage;
                pict.BackColor = Color.Black;
                pict.Location = new Point(x, yPV);
                panel_playlist_mostrar.Controls.Add(pict);
                Label l = new Label();
                l.Text = textBox_Nombre_playlist_canciones.Text;
                l.Location = new Point(x+50, yPV+140);
                panel_playlist_mostrar.Controls.Add(l);
                List<Canciones> AllCanciones = GetAllSongs(this, new GetMultimediaDataEventArgs());
                List<Canciones> MySongsPlay = new List<Canciones>();
                foreach (Canciones vid in AllCanciones)
                {
                    foreach (string item in mylist)
                    {
                        if (vid.Titulo == item)
                        {
                            MySongsPlay.Add(vid);
                        }
                    }
                }
                bool p = DetectPrivate(this, new LoginEventArgs() { Nickname = user_enter });
                if (p == false)
                {
                    const string message2 = "Eres un Usuario publico, Quieres hacer tu playlist privada?";
                    const string caption2 = "Closing";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        p = true;
                    }
                    else
                    {
                        p = false;
                    }
                }
                Usuario usua = UsuarioGet(this, new LoginEventArgs() { Nickname = user_enter });
                Playlist playing = new Playlist(textBox_Nombre_playlist_canciones.Text, MySongsPlay, null, null, p, path);
                usua.Add_Playlist_To_My_List(playing);
                OnGeneratePlaylist(textBox_Nombre_playlist_canciones.Text, MySongsPlay, null, p,path);
                SaveData(this, new EventArgs());
                pict.Click += new System.EventHandler(this.OnCancionPlay);
            }
        }
        
        
        private void OnCancionPlay(object sender, EventArgs e)
        {
            ReproductorVideo.Ctlcontrols.pause();
            ReproductorCancion.Ctlcontrols.pause();
            panel_resultado_busqueda_avanzada.Visible = true;
            ReproducirPlaylist.Visible = true;
            PictureBox currentable = (PictureBox)sender;
            label2.Text = currentable.Name;
            Playlist p = UserPlaylists(this, new AddPlaylistEventArgs() { names = currentable.Name });
            Reproductor_de_Playlist.currentPlaylist = Reproductor_de_Playlist.newPlaylist(p.Name, "");
            for (int i = 0; i < p.Playlist_canciones1.Count; i++)
            {
                Reproductor_de_Playlist.currentPlaylist.appendItem(Reproductor_de_Playlist.newMedia(p.Playlist_canciones1[i].Carpeta_archivo));
            }
            Reproductor_de_Playlist.Ctlcontrols.play();
        }

        private void Add_Video_Playlist_Click(object sender, EventArgs e)
        {
            bool pivote = true;
            bool test = true;
            for(int i=0; i< panel_playlist_mostrar.Controls.Count;i++)
            {
                if(panel_playlist_mostrar.Controls[i].Name == textBox_Nombre_playlist_videos.Text)
                {
                    pivote = false;
                }
            }

            if (Check_Videos_agregar_playlist.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se a seleccionado ningun video", "ERROR DE SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Nombre_playlist_videos.Text == "" )
            {
                MessageBox.Show("No se ha ingresado ningun nombre para la playlist", "ERROR DE NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pivote == false)
            {
                MessageBox.Show("El Nombre ingresado ya existe", "ERROR DE NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = 60;
                yPV += 175;
                List<string> mylist = new List<string>();
                foreach (string videos in Check_Videos_agregar_playlist.CheckedItems)
                {
                    mylist.Add(videos);
                }
                PictureBox pict = new PictureBox();
                const string message = "Deseas agregar una foto a tu playlist?";
                const string caption = "Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                string path = "";
                if (result == DialogResult.Yes)
                {

                    OpenFileDialog find_path = new OpenFileDialog();
                    find_path.Filter = "Image File (*.jpg; *.jpeg; *.bmp;) |*.jpg; *.jpeg; *.bmp; |(*.png; *.jpeg; *.bmp;) |*.png; *.jpeg; *.bmp; ";
                    if (find_path.ShowDialog() == DialogResult.OK)
                    {
                        path = find_path.FileName;
                    }
                }
                else
                {

                    pict.Image = Properties.Resources.totoro;
                    test = false;
                }

                if(test == true)
                {
                    pict.ImageLocation = path;
                }
                pict.Name = textBox_Nombre_playlist_videos.Text;
                pict.Width = 140;
                pict.Height = 140;
                pict.SizeMode = PictureBoxSizeMode.StretchImage;
                pict.BackColor = Color.Black;
                pict.Location = new Point(x, yPV);
                Label l = new Label();
                l.Text = textBox_Nombre_playlist_videos.Text;
                l.Location = new Point(x+50, yPV + 140);
                panel_playlist_mostrar.Controls.Add(pict);
                panel_playlist_mostrar.Controls.Add(l);
                List<Video> AllVideos = GetAllVideos(this, new GetMultimediaDataEventArgs());
                List<Video> MyVideoPlay = new List<Video>();
                foreach(Video vid in AllVideos)
                {
                    foreach(string item in mylist)
                    {
                        if (vid.Titulo == item)
                        {
                            MyVideoPlay.Add(vid);
                        }
                    }
                }
                bool p = DetectPrivate(this, new LoginEventArgs() { Nickname = user_enter });
                if (p == false)
                {
                    const string message2 = "Eres un Usuario publico, Quieres hacer tu playlist privada?";
                    const string caption2 = "Closing";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        p = true;
                    }
                    else
                    {
                        p = false;
                    }
                }
                Usuario usua = UsuarioGet(this, new LoginEventArgs() { Nickname = user_enter });
                Playlist playing = new Playlist(textBox_Nombre_playlist_videos.Text, null, MyVideoPlay, null, p, path);
                usua.Add_Playlist_To_My_List(playing);
                OnGeneratePlaylist(textBox_Nombre_playlist_videos.Text,null, MyVideoPlay,p,path);
                pict.Click += new System.EventHandler(this.OnVideoPlay);
            }


        }


        private void OnVideoPlay(object sender, EventArgs e)
        {
            ReproductorVideo.Ctlcontrols.pause();
            ReproductorCancion.Ctlcontrols.pause();
            panel_resultado_busqueda_avanzada.Visible = true;
            ReproducirPlaylist.Visible = true;
            PictureBox currentable = (PictureBox)sender;
            label2.Text = currentable.Name;
            Playlist p = UserPlaylists(this,new AddPlaylistEventArgs() { names = currentable.Name });
            Reproductor_de_Playlist.currentPlaylist = Reproductor_de_Playlist.newPlaylist(p.Name, "");
            for(int i = 0; i < p.Playlist_videos1.Count;i++)
            {
                Reproductor_de_Playlist.currentPlaylist.appendItem(Reproductor_de_Playlist.newMedia(p.Playlist_videos1[i].Carpeta_archivo));
            }
            Reproductor_de_Playlist.Ctlcontrols.play();

        }

        private void pictureBox_atras_busqueda_especifica_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_info_artista.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
        }

        private void button_busqueda_or_Click(object sender, EventArgs e)
        {
            List<string> palabras_clave = textBox_palabras_clave_buscar.Text.Split(',').ToList();
            List<string> nombres_clave = textBox_nombre_personas_buscar.Text.Split(',').ToList();
            int edad_condition = 0;
            int edad_clave = 0;
            try
            {
                edad_clave = int.Parse(textBox_edad_personas_buscar.Text);
            }
            catch
            {
                try
                {
                    if (textBox_edad_personas_buscar.Text[0] == '>')
                    {
                        edad_condition = 1;
                    }
                    else
                    {
                        edad_condition = 2;
                    }
                    edad_clave = int.Parse(textBox_edad_personas_buscar.Text.Substring(1));
                }
                catch
                {
                    edad_condition = 0;
                    edad_clave = -1;
                }
            }
            string genero = "";
            if (checkBox_buscar_hombre.Checked)
            {
                genero = "H";
            }
            if (checkBox_buscar_mujer.Checked)
            {
                genero = "M";
            }
            int duration_condition = 0;
            int duracion_clave = 0;
            try
            {
                duracion_clave = int.Parse(textBox_buscar_duracion.Text);
            }
            catch
            {
                try
                {
                    if (textBox_buscar_duracion.Text[0] == '>')
                    {
                        duration_condition = 1;
                    }
                    else
                    {
                        duration_condition = 2;
                    }
                    duracion_clave = int.Parse(textBox_buscar_duracion.Text.Substring(1));
                }
                catch
                {
                    duration_condition = 0;
                    duracion_clave = -1;
                }
            }
            int resolution_condition = 0;
            int resolucion_clave = 0;
            try
            {
                resolucion_clave = int.Parse(textBox_buscar_Calidad.Text);
            }
            catch
            {
                try
                {
                    if (textBox_buscar_Calidad.Text[0] == '>')
                    {
                        resolution_condition = 1;
                    }
                    else
                    {
                        resolution_condition = 2;
                    }
                    resolucion_clave = int.Parse(textBox_buscar_Calidad.Text.Substring(1));
                }
                catch
                {
                    resolution_condition = 0;
                    resolucion_clave = -1;
                }
            }
            int calificacion_condition = 0;
            decimal calificacion_clave = 0;
            try
            {
                calificacion_clave = decimal.Parse(textBox_buscar_ranking.Text);
            }
            catch
            {
                try
                {
                    if (textBox_buscar_ranking.Text[0] == '>')
                    {
                        calificacion_condition = 1;
                    }
                    else
                    {
                        calificacion_condition = 2;
                    }
                    calificacion_clave = int.Parse(textBox_buscar_ranking.Text.Substring(1));
                }
                catch
                {
                    calificacion_condition = 0;
                    calificacion_clave = -1;
                }
            }
            List<string> generos_clave = textBox_genero_busqueda.Text.Split(',').ToList();
            OnBusquedaOr(palabras_clave, nombres_clave, edad_clave, edad_condition, genero, duracion_clave, duration_condition,
                resolucion_clave, resolution_condition, generos_clave, calificacion_clave, calificacion_condition);
        }

        private void button2_Click(object sender, EventArgs e) //Button busqueda and
        {
            List<string> palabras_clave = textBox_palabras_clave_buscar.Text.Split(',').ToList();
            List<string> nombres_clave = textBox_nombre_personas_buscar.Text.Split(',').ToList();
            int edad_condition = 0;
            int edad_clave = 0;
            try
            {
                edad_clave = int.Parse(textBox_edad_personas_buscar.Text);
            }
            catch
            {
                try
                {
                    if (textBox_edad_personas_buscar.Text[0] == '>')
                    {
                        edad_condition = 1;
                    }
                    else
                    {
                        edad_condition = 2;
                    }
                    edad_clave = int.Parse(textBox_edad_personas_buscar.Text.Substring(1));
                }
                catch
                {
                    edad_condition = 0;
                    edad_clave = -1;
                }
            }
            string genero = "";
            if (checkBox_buscar_hombre.Checked)
            {
                genero = "H";
            }
            if (checkBox_buscar_mujer.Checked)
            {
                genero = "M";
            }
            int duration_condition = 0;
            int duracion_clave = 0;
            try
            {
                duracion_clave = int.Parse(textBox_buscar_duracion.Text);
            }
            catch
            {
                try
                {
                    if (textBox_buscar_duracion.Text[0] == '>')
                    {
                        duration_condition = 1;
                    }
                    else
                    {
                        duration_condition = 2;
                    }
                    duracion_clave = int.Parse(textBox_buscar_duracion.Text.Substring(1));
                }
                catch
                {
                    duration_condition = 0;
                    duracion_clave = -1;
                }
            }
            int resolution_condition = 0;
            int resolucion_clave = 0;
            try
            {
                resolucion_clave = int.Parse(textBox_buscar_Calidad.Text);
            }
            catch
            {
                try
                {
                    if (textBox_buscar_Calidad.Text[0] == '>')
                    {
                        resolution_condition = 1;
                    }
                    else
                    {
                        resolution_condition = 2;
                    }
                    resolucion_clave = int.Parse(textBox_buscar_Calidad.Text.Substring(1));
                }
                catch
                {
                    resolution_condition = 0;
                    resolucion_clave = -1;
                }
            }
            int calificacion_condition = 0;
            decimal calificacion_clave = 0;
            try
            {
                calificacion_clave = decimal.Parse(textBox_buscar_ranking.Text);
            }
            catch
            {
                try
                {
                    if (textBox_buscar_ranking.Text[0] == '>')
                    {
                        calificacion_condition = 1;
                    }
                    else
                    {
                        calificacion_condition = 2;
                    }
                    calificacion_clave = int.Parse(textBox_buscar_ranking.Text.Substring(1));
                }
                catch
                {
                    calificacion_condition = 0;
                    calificacion_clave = -1;
                }
            }
            List<string> generos_clave = textBox_genero_busqueda.Text.Split(',').ToList();
            OnBusquedaAnd(palabras_clave, nombres_clave, edad_clave, edad_condition, genero, duracion_clave, duration_condition,
                resolucion_clave, resolution_condition, generos_clave, calificacion_clave, calificacion_condition);
        }


        private void picturebox_atras_playlist_Click_1(object sender, EventArgs e)
        {
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_info_artista.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
        }

        private void Volver_a_Playlist_Click(object sender, EventArgs e)
        {
            panel_resultado_busqueda_avanzada.Visible = false;
            ReproducirPlaylist.Visible = false;
        }

        private void label_Favoritos_Click(object sender, EventArgs e)
        {
            OnGetFavorites();
        }

        private void checkbtnHdirec_vid_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxM_direcvid.Checked = false;
        }

        private void checkBoxMActores_nuevovid_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxHActor_nuevovid.Checked = false;
        }

        private void checkBoxHActor_nuevovid_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMActores_nuevovid.Checked = false;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkbtnHdirec_vid.Checked = false;
        }

        private void pictureBox_atras_favs_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = false;
            panel_informacion.Visible = false;
            panel_title_add_cancion.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_fijar_add_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panelAgregarunVid.Visible = false;
            panel_info_cancion.Visible = false;
            panel_fijar_info_cancion.Visible = false;
            panel3.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_info_artista.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_playlist_mostrar.Visible = false;
            panel_favoritos.Visible = false;
        }

        private void radioButtonFavoritoNuevaCancion_CheckedChanged(object sender, EventArgs e)
        {
            OnVideoFavorite(user_enter, lblTitulo_vid.Text);
            SaveData(this, new EventArgs());

        }

        public void OnVideoFavorite(string user, string title)
        {
            if (AddFavoriteVideo != null && PutFavoriteVideo != null)
            {
                Video favorita = AddFavoriteVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = title });
                PutFavoriteVideo(this, new AddMultimediaEventArgs() { Video = favorita, user = user_enter });
            }
        }

        private void buttonComentar_Video_Click(object sender, EventArgs e)
        {
            string comentario = richTextBoxComentar_Video.Text;
            if (CommentAddedVideo != null && comentario != "")
            {
                Usuario usuario = UsuarioGet(this, new LoginEventArgs() { Nickname = user_enter });
                CommentAddedVideo(this, new AddComentarioEventArgs() { user = usuario, comentario = comentario, Multimedia_Name = lblTituloDelVideoAReproducir.Text });
                OnShowComentariosVideo();
                richTextBoxComentar_Video.ResetText();
            }
        }

        public void OnShowComentariosVideo()
        {
            int comentarios_pos_x = 50;
            int comentarios_pos_y = 240;
            List<string> nickname_usu = GetUserNickComentVideo(this, new AddComentarioEventArgs() { Multimedia_Name = lblTituloDelVideoAReproducir.Text });
            List<string> path_foto_perfil_usu = GetUserPhotoComentVideo(this, new AddComentarioEventArgs() { Multimedia_Name = lblTituloDelVideoAReproducir.Text });
            List<string> comment_usu = GetUserComentVideo(this, new AddComentarioEventArgs() { Multimedia_Name = lblTituloDelVideoAReproducir.Text });
            for (int i = 0; i < nickname_usu.Count(); i++)
            {
                PictureBox pict = add_coment_image(comentarios_pos_x, comentarios_pos_y, nickname_usu[i], path_foto_perfil_usu[i]);
                lista_fotos_comentarios_a_mostrar.Add(pict);
                panelComentarios_Video.Controls.Add(pict);
                Label l = add_coment_label(comentarios_pos_x + 80, comentarios_pos_y, nickname_usu[i], comment_usu[i]);
                lista_labels_comentarios_a_mostrar.Add(l);
                panelComentarios_Video.Controls.Add(l);
                comentarios_pos_y += 60;
            }
        }

        private void btn_Comentarios_ReproducirVideo_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_playlist.Visible = true;
            panel_playlist_mostrar.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            ReproducirPlaylist.Visible = true;
            panel_favoritos.Visible = true;
            panelComentarios_Video.Visible = true;
            labelComentarios_Video.Text = "Comentarios "+ lblTituloDelVideoAReproducir.Text +":";
            OnShowComentariosVideo();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_playlist_mostrar.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_favoritos.Visible = false;
            panelComentarios_Video.Visible = false;
        }

        int yPVC = -165;
        List<Label> labes = new List<Label>();
        private void Eliminar_Playlist_Click(object sender, EventArgs e)
        {
            bool test = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            ReproducirPlaylist.Visible = true;
            panel_favoritos.Visible = true;
            panel_Eliminar_Playlist.Visible = true;
            Mis_Playlist_Eliminar.Visible = true;
            panelComentarios_Video.Visible = true;
            Mis_Playlist_Eliminar.Controls.Clear();
            yPVC = -165;

            List<Playlist> myplay = GetUserPlaylist(this, new LoginEventArgs() { Nickname = user_enter });

            foreach (Playlist play in myplay)
            {
                if (play.Mostrar_Videos() != null)
                {
                    int x = 60;
                    yPVC += 175;
                    string path = play.Foto;


                    PictureBox pict = new PictureBox();
                    List<string> mylist = new List<string>();
                    if (path == "")
                    {
                        pict.Image = Properties.Resources.totoro;
                        test = false;
                    }
                    foreach (Video videos in play.Mostrar_Videos())
                    {
                        mylist.Add(videos.Titulo);
                    }


                    pict.Name = play.Name;
                    if(test == true)
                    {
                        test = true;
                        pict.ImageLocation = path;
                    }
                    pict.Width = 140;
                    pict.Height = 140;
                    pict.SizeMode = PictureBoxSizeMode.StretchImage;
                    pict.BackColor = Color.Black;
                    pict.Location = new Point(x, yPVC);
                    Mis_Playlist_Eliminar.Controls.Add(pict);
                    Label l = new Label();
                    l.Text = play.Name;
                    l.Location = new Point(x + 50, yPVC + 140);
                    labes.Add(l);
                    Mis_Playlist_Eliminar.Controls.Add(l);
                    List<Video> AllVideos = GetAllVideos(this, new GetMultimediaDataEventArgs());
                    List<Video> MySongsPlay = new List<Video>();
                    foreach (Video vid in AllVideos)
                    {
                        foreach (string item2 in mylist)
                        {
                            if (vid.Titulo == item2)
                            {
                                MySongsPlay.Add(vid);
                            }
                        }
                    }
                    pict.Click += new System.EventHandler(this.OnVideoPlayDelete);
                }
                else if (play.Mostrar_Canciones() != null)
                {
                    int x = 60;
                    yPVC += 175;
                    string path = play.Foto;


                    PictureBox pict = new PictureBox();
                    if (path == "")
                    {
                        pict.Image = Properties.Resources.CPlaylist;
                        test = false;
                    }
                    List<string> mylist = new List<string>();

                    foreach (Canciones canciones in play.Mostrar_Canciones())
                    {
                        mylist.Add(canciones.Titulo);
                    }


                    pict.Name = play.Name;
                    if(test == true)
                    {
                        test = true;
                        pict.ImageLocation = path;
                    }
                    pict.Width = 140;
                    pict.Height = 140;
                    pict.SizeMode = PictureBoxSizeMode.StretchImage;
                    pict.BackColor = Color.Black;
                    pict.Location = new Point(x, yPVC);
                    Mis_Playlist_Eliminar.Controls.Add(pict);
                    Label l = new Label();
                    l.Text = play.Name;
                    l.Location = new Point(x + 50, yPVC + 140);
                    labes.Add(l);
                    Mis_Playlist_Eliminar.Controls.Add(l);
                    List<Canciones> AllCanciones = GetAllSongs(this, new GetMultimediaDataEventArgs());
                    List<Canciones> MySongsPlay = new List<Canciones>();
                    foreach (Canciones vid in AllCanciones)
                    {
                        foreach (string item2 in mylist)
                        {
                            if (vid.Titulo == item2)
                            {
                                MySongsPlay.Add(vid);
                            }
                        }
                    }
                    pict.Click += new System.EventHandler(this.OnCancionPlayDelete);
                }
            }

        }

        public void OnDelete_Playlist(string name)
        {
            if (Delete_Playlist != null)
            {
                Delete_Playlist(this, new AddPlaylistEventArgs() { names = name });
            }
        }
        private void OnCancionPlayDelete(object sender, EventArgs e)
        {
            const string message = "Seguro que quieres borrar esta Playlist?";
            const string caption = "Action";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PictureBox currentable = (PictureBox)sender;
                List<Playlist> allPlay = get_Playlist(this, new AddPlaylistEventArgs());
                string Rnames = "";
                List<Label> RemoveLab = new List<Label>();
                foreach (Playlist item in allPlay)
                {
                    if (item.Name == currentable.Name)
                    {
                        Usuario usua = UsuarioGet(this, new LoginEventArgs() { Nickname = user_enter });
                        usua.Remove_Playlist(item);
                        SaveData(this, new EventArgs());
                        Mis_Playlist_Eliminar.Controls.Remove(currentable);
                        foreach (Label cosa in labes)
                        {
                            if (currentable.Name == cosa.Text)
                            {
                                RemoveLab.Add(cosa);
                            }
                        }
                        foreach (Label cosa2 in RemoveLab)
                        {
                            Mis_Playlist_Eliminar.Controls.Remove(cosa2);
                        }
                        panel_playlist_mostrar.Controls.Clear();
                        Rnames = item.Name;
                    }
                }
                OnDelete_Playlist(Rnames);
                yPV = -130;
                MisCancionesYVideos();
                Eliminar_Playlist_Click(sender, e);
            }
        }

        private void OnVideoPlayDelete(object sender, EventArgs e)
        {
            const string message = "Seguro que quieres borrar esta Playlist?";
            const string caption = "Action";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PictureBox currentable = (PictureBox)sender;
                List<Playlist> allPlay = get_Playlist(this, new AddPlaylistEventArgs());
                string Rnames = "";
                List<Label> RemoveLab = new List<Label>();
                foreach (Playlist item in allPlay)
                {
                    if (item.Name == currentable.Name)
                    {
                        Rnames = item.Name;
                        Usuario usua = UsuarioGet(this, new LoginEventArgs() { Nickname = user_enter });
                        usua.Remove_Playlist(item);
                        SaveData(this, new EventArgs());
                        Mis_Playlist_Eliminar.Controls.Remove(currentable);
                        foreach (Label cosa in labes)
                        {
                            if (currentable.Name == cosa.Text)
                            {
                                RemoveLab.Add(cosa);
                            }

                        }
                        foreach (Label cosa2 in RemoveLab)
                        {
                            Mis_Playlist_Eliminar.Controls.Remove(cosa2);
                        }
                        panel_playlist_mostrar.Controls.Clear();
                    }
                }
                OnDelete_Playlist(Rnames);
                yPV = -130;
                MisCancionesYVideos();
                Eliminar_Playlist_Click(sender, e);
            }
        }

        private void VolverDeBorrarPlaylist_Click_2(object sender, EventArgs e)
        {
            panel_resultado_busqueda_avanzada.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_favoritos.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
        }

        private void label_ranking_Click(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            panel3.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_info_artista.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_playlist.Visible = true;
            panel_playlist_mostrar.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            ReproducirPlaylist.Visible = true;
            panel_favoritos.Visible = true;
            panelComentarios_Video.Visible = true;
            panel_Eliminar_Playlist.Visible = true;
            Mis_Playlist_Eliminar.Visible = true;
            panel_de_rankings.Visible = true;
            panel_Ranking_de_Canciones.Visible = false;

        }


        private void OnSongClick2(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_info_artista.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel3.Visible = false;
            pictureBox_reproducir_cancion.Visible = true;
            pictureBox_download.Visible = true;
            PictureBox currentable = (PictureBox)sender;
            string name_cancion = currentable.Name;

            pictureBox_1star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_2star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_3star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_4star_Canciones.Image = Properties.Resources.nostar;
            pictureBox_5star_Canciones.Image = Properties.Resources.nostar;

            ShowInfoCancion(this, new AddMultimediaEventArgs() { name_multimedia_file = name_cancion });
            radioButton_add_favorito.Checked = CheckedFavorite(this, new AddMultimediaEventArgs() { name_multimedia_file = name_cancion, user = user_enter });
            if (reproduciendo && multimedia_playing == name_cancion)
            {
                panel_reproductor_cancion.Visible = true;
            }
        }
        int pp = 0;
        private void Mostrar_Ranking_Musica_Click_1(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = true;

            panel_Mostrar_Ranking_Canciones.Controls.Clear();
            panel_Mostrar_Ranking_Canciones.Visible = true;
            pp = 0;
            IEnumerable<Canciones> canciones = GetRankingSongs(this, new AddMultimediaEventArgs());


            foreach (Canciones can in canciones)
            {
                PictureBox pict = add_buscado_image(50, 20 + pp, can.Titulo, can.Portada);
                pict.Name = can.Titulo;

                pict.Click += new System.EventHandler(this.OnSongClick2);
                panel_Mostrar_Ranking_Canciones.Controls.Add(pict);

                Label l = add_name_busqueda_label(150, pp +20, can.Titulo);
                Label l2 = add_name_busqueda_label(150, pp + 40,"Ranking: " + can.Get_Mean_Tier().ToString());
                pp += 75;
                panel_Mostrar_Ranking_Canciones.Controls.Add(l2);
                panel_Mostrar_Ranking_Canciones.Controls.Add(l);
                

            }

        }

        private void button_add_cola_cancion_Click(object sender, EventArgs e)
        {
            string titulo = label_info_nombre_cancion.Text;
            Canciones can = GetSong(this, new AddMultimediaEventArgs() { name_multimedia_file = titulo });
            ColaCancion(this, new AddMultimediaEventArgs() { Cancion = can, user = user_enter });
        }

        private void btnAñadirALaCola_ReproducirVideo_Click(object sender, EventArgs e)
        {
            string titulo = lblTituloDelVideoAReproducir.Text;
            Video vid = GetVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = titulo });
            ColaVideo(this, new AddMultimediaEventArgs() { Video = vid, user = user_enter });
        }

        private void Mostrar_Ranking_Video_Click(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = true;

            panel_Mostrar_Ranking_Canciones.Controls.Clear();
            panel_Mostrar_Ranking_Canciones.Visible = true;
            pp = 0;
            IEnumerable<Video> canciones = GetRankingVideo(this, new GetMultimediaDataEventArgs());


            foreach (Video can in canciones)
            {
                PictureBox pict = add_buscado_image(50, 20 + pp, can.Titulo, can.Portada);
                pict.Name = can.Titulo;

                pict.Click += new System.EventHandler(this.OnVideoClick2);
                panel_Mostrar_Ranking_Canciones.Controls.Add(pict);

                Label l = add_name_busqueda_label(150, pp + 20, can.Titulo);
                Label l2 = add_name_busqueda_label(150, pp + 40, "Ranking: " + can.Get_Mean_Tier().ToString());
                pp += 75;
                panel_Mostrar_Ranking_Canciones.Controls.Add(l2);
                panel_Mostrar_Ranking_Canciones.Controls.Add(l);


            }
        }

        private void OnVideoClick2(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;

            pictureBoxEstrellaVideo1.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo2.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo3.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo4.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo5.Image = Properties.Resources.nostar;

            PictureBox currentable = (PictureBox)sender;
            string name_Video = currentable.Name;
            ShowInfoVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = name_Video });
            radioButtonFavoritoNuevoVideo.Checked = CheckedFavorite(this, new AddMultimediaEventArgs() { name_multimedia_file = name_Video, user = user_enter });
            if (reproduciendo && multimedia_playing == name_Video)
            {
                panel_reproductor_Video.Visible = true;
            }
        }

        private void OnVideoClickedBySearch(object sender, EventArgs e)
        {
            panel_ajustes.Visible = true;
            panel_informacion.Visible = true;
            panel_title_add_cancion.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_fijar_add_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panelAgregarunVid.Visible = true;
            panel_info_cancion.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_fijar_info_cancion.Visible = true;
            pictureBox_reproducir_cancion.Visible = true;
            pictureBox_download.Visible = true;
            label_size_cancion.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_favoritos.Visible = false;
            panel_playlist.Visible = false;
            panel_playlist_mostrar.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;

            pictureBoxEstrellaVideo1.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo2.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo3.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo4.Image = Properties.Resources.nostar;
            pictureBoxEstrellaVideo5.Image = Properties.Resources.nostar;

            Label currentable = (Label)sender;
            string name_video = currentable.Name.Remove(0, 14);
            ShowInfoVideo(this, new AddMultimediaEventArgs() { name_multimedia_file = name_video });
            radioButtonFavoritoNuevoVideo.Checked = CheckedFavorite(this, new AddMultimediaEventArgs() { name_multimedia_file = name_video, user = user_enter });
            if (reproduciendo && multimedia_playing == name_video)
            {
                panel_reproductor_Video.Visible = true;
            }
        }

        private void Volver_Ranking_video_y_canciones_Click(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = false;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_info_artista.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel3.Visible = false;
            panel_info_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_informacion.Visible = false;
            panel_ajustes.Visible = false;
        }

        private void radioButtonFavoritoNuevoVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFavoritoNuevoVideo.Checked)
            {
                OnVideoFavorite(user_enter, lblTituloDelVideoAReproducir.Text);
            }
            SaveData(this, new EventArgs());
        }


        private void pictureBoxRetroceder_Recomendaciones_Click(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_info_artista.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel3.Visible = false;
            panel_info_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_informacion.Visible = false;
            panel_ajustes.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            Mis_Playlist_Eliminar.Visible = false;
            panel_Ranking_de_Canciones.Visible = false;
            panel_Mostrar_Ranking_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panelRecomendaciones.Visible = false;
        }


        private void label_recomendaciones_Click(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = true;
            panel_de_rankings.Visible = true;
            panel_Eliminar_Playlist.Visible = true;
            panelComentarios_Video.Visible = true;
            panel_favoritos.Visible = true;
            ReproducirPlaylist.Visible = true;
            panel_resultado_busqueda_avanzada.Visible = true;
            panel_playlist.Visible = true;
            panel_busqueda_avanzada.Visible = true;
            panelReproducirVideo.Visible = true;
            panel_info_artista.Visible = true;
            panel_usuario_buscado.Visible = true;
            panel_resultado_busqueda_general.Visible = true;
            panel_comentarios_cancion.Visible = true;
            panel3.Visible = true;
            panel_info_cancion.Visible = true;
            panel_De_Agregar_Video.Visible = true;
            panel_datos_add_cancion.Visible = true;
            panel_informacion.Visible = true;
            panel_ajustes.Visible = true;
            panelComentarios_Video.Visible = true;
            panel_Eliminar_Playlist.Visible = true;
            Mis_Playlist_Eliminar.Visible = true;
            panel_Ranking_de_Canciones.Visible = true;
            panel_Mostrar_Ranking_Canciones.Visible = true;
            panel_de_rankings.Visible = true;
            panelRecomendaciones.Visible = true;
            OnGetRecomendaciones();
        }


        public void OnGetRecomendaciones()
        {
            labelText1.Visible = true;
            labelText2.Visible = true;
            labelText3.Visible = true;
            labelText4.Visible = true;
            labelText5.Visible = false;
            List<Canciones> titulos_canciones_favoritas = new List<Canciones>();
            List<string> fotos_canciones_favoritas = new List<string>();
            List<Video> titulos_videos_favoritas = new List<Video>();
            List<string> fotos_videos_favoritas = new List<string>();
            MyRecomendaciones(this, new AddMultimediaEventArgs()
            {
                user = user_enter,
                can_Reco = titulos_canciones_favoritas,
                can_foto_favs = fotos_canciones_favoritas,
                vid_Reco = titulos_videos_favoritas,
                vid_foto_favs = fotos_videos_favoritas
            });
            List<string> titulos_canciones_Recomendadas = new List<string>();
            List<string> fotos_canciones_Recomendadas = new List<string>();
            List<string> titulos_videos_Recomendadas = new List<string>();
            List<string> fotos_videos_Recomendadas = new List<string>();
            // canciones
            if(titulos_canciones_favoritas.Count() != 0 || titulos_videos_favoritas.Count() != 0)
            {
                labelText1.Visible = false;
                labelText2.Visible = false;
                labelText3.Visible = false;
                labelText4.Visible = false;
            }


            for (int i = 0; i < titulos_canciones_favoritas.Count(); i++)
            {
                for (int h = 0; h < GetAllSongs(this,new GetMultimediaDataEventArgs() { }).Count; h++)
                {
                    for (int p = 0; p < titulos_canciones_favoritas[i].Genero.Count(); p++)
                    {
                        for (int q = 0; q < GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Genero.Count(); q++)
                        {
                            if (titulos_canciones_favoritas[i].Genero[p] == GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Genero[q])
                            {
                                if(titulos_canciones_Recomendadas.Count == 0)
                                {
                                    int esta = 0;
                                    for (int s = 0; s < titulos_canciones_favoritas.Count(); s++)
                                    {
                                        if (titulos_canciones_favoritas[s].Titulo == GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Titulo)
                                        {
                                            esta = 1;
                                        }
                                    }
                                    if(esta == 0)
                                    {
                                        titulos_canciones_Recomendadas.Add(GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Titulo);
                                        fotos_canciones_Recomendadas.Add(GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Portada);
                                    }

                                }
                                else
                                {
                                    int auxi = 0;
                                    foreach (string item in titulos_canciones_Recomendadas)
                                    {

                                        if (item == GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Titulo)
                                        {
                                            auxi = 1;
                                        }

                                    }
                                    if(auxi == 0)
                                    {
                                        int esta = 0;
                                        for (int s = 0; s < titulos_canciones_favoritas.Count(); s++)
                                        {
                                            if (titulos_canciones_favoritas[s].Titulo == GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Titulo)
                                            {
                                                esta = 1;
                                            }
                                        }
                                        if (esta == 0)
                                        {
                                            titulos_canciones_Recomendadas.Add(GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Titulo);
                                            fotos_canciones_Recomendadas.Add(GetAllSongs(this, new GetMultimediaDataEventArgs() { })[h].Portada);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
 
            }
            //videos
            for (int i = 0; i < titulos_videos_favoritas.Count(); i++)
            {
                for (int h = 0; h < GetAllVideos(this, new GetMultimediaDataEventArgs() { }).Count; h++)
                {
                    for (int p = 0; p < titulos_videos_favoritas[i].Genero.Count(); p++)
                    {
                        for (int q = 0; q < GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Genero.Count(); q++)
                        {
                            if (titulos_videos_favoritas[i].Genero[p] == GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Genero[q])
                            {
                                if (titulos_canciones_Recomendadas.Count == 0)
                                {
                                    int esta = 0;
                                    for (int s = 0; s < titulos_videos_favoritas.Count(); s++)
                                    {
                                        if (titulos_videos_favoritas[s].Titulo == GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Titulo)
                                        {
                                            esta = 1;
                                        }
                                    }
                                    if (esta == 0)
                                    {
                                        titulos_videos_Recomendadas.Add(GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Titulo);
                                        fotos_videos_Recomendadas.Add(GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Portada);
                                    }

                                }
                                else
                                {
                                    int auxi = 0;
                                    foreach (string item in titulos_canciones_Recomendadas)
                                    {

                                        if (item == GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Titulo)
                                        {
                                            auxi = 1;
                                        }

                                    }
                                    if (auxi == 0)
                                    {
                                        int esta = 0;
                                        for (int s = 0; s < titulos_videos_favoritas.Count(); s++)
                                        {
                                            if (titulos_videos_favoritas[s].Titulo == GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Titulo)
                                            {
                                                esta = 1;
                                            }
                                        }
                                        if (esta == 0)
                                        {
                                            titulos_videos_Recomendadas.Add(GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Titulo);
                                            fotos_videos_Recomendadas.Add(GetAllVideos(this, new GetMultimediaDataEventArgs() { })[h].Portada);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }



            if (titulos_canciones_Recomendadas.Count == 0 && titulos_videos_Recomendadas.Count ==0)
            {
                labelText5.Visible = true;
            }
            ShowMyRecomendados(titulos_canciones_Recomendadas, fotos_canciones_Recomendadas, titulos_videos_Recomendadas, fotos_videos_Recomendadas);
        }

        public void ShowMyRecomendados(List<string> name_canciones, List<string> fotos_canciones, List<string> name_videos,
    List<string> fotos_videos)
        {
            for (int i = 0; i < lista_fotos_encontradas_favorita.Count(); i++)
            {
                panelRecomendaciones.Controls.Remove(lista_fotos_encontradas_favorita[i]);
            }
            for (int i = 0; i < lista_titulos_encontradas_favorita.Count(); i++)
            {
                panelRecomendaciones.Controls.Remove(lista_titulos_encontradas_favorita[i]);
            }
            for (int i = 0; i < lista_labels_secciones.Count(); i++)
            {
                panelRecomendaciones.Controls.Remove(lista_labels_secciones[i]);
            }
            lista_fotos_encontradas_favorita.Clear();
            lista_titulos_encontradas_favorita.Clear();
            lista_labels_secciones.Clear();
            int pos_x = 50;
            int pos_y = 110;
            if (name_canciones.Count() > 0)
            {
                Label song_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Canciones");
                panelRecomendaciones.Controls.Add(song_seccion);
                lista_labels_secciones.Add(song_seccion);
                pos_y += 45;
                for (int i = 0; i < name_canciones.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_canciones[i], fotos_canciones[i]);
                    panelRecomendaciones.Controls.Add(pict);
                    lista_fotos_encontradas_favorita.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_canciones[i]);
                    lista_titulos_encontradas_favorita.Add(l);
                    l.Click += new System.EventHandler(this.OnSongClickedBySearch);
                    panelRecomendaciones.Controls.Add(l);
                    pos_y += 50;
                }
            }
            if (name_videos.Count() > 0)
            {
                Label video_seccion = add_seccion_busqueda_label(pos_x, pos_y, "Videos");
                panelRecomendaciones.Controls.Add(video_seccion);
                lista_labels_secciones.Add(video_seccion);
                pos_y += 45;
                for (int i = 0; i < name_videos.Count(); i++)
                {
                    PictureBox pict = add_buscado_image(pos_x, pos_y, name_videos[i], fotos_videos[i]);
                    panelRecomendaciones.Controls.Add(pict);
                    lista_fotos_encontradas_favorita.Add(pict);
                    Label l = add_name_busqueda_label(pos_x + 50, pos_y, name_videos[i]);
                    lista_titulos_encontradas_favorita.Add(l);
                    l.Click += new System.EventHandler(this.OnVideoClickedBySearch);
                    panelRecomendaciones.Controls.Add(l);
                    pos_y += 50;
                }
            }
        }

        private void pictureBox_atras_eliminar_usuario_Click(object sender, EventArgs e)
        {
            panel_Ranking_de_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_favoritos.Visible = false;
            ReproducirPlaylist.Visible = false;
            panel_resultado_busqueda_avanzada.Visible = false;
            panel_playlist.Visible = false;
            panel_busqueda_avanzada.Visible = false;
            panelReproducirVideo.Visible = false;
            panel_info_artista.Visible = false;
            panel_usuario_buscado.Visible = false;
            panel_resultado_busqueda_general.Visible = false;
            panel_comentarios_cancion.Visible = false;
            panel3.Visible = false;
            panel_info_cancion.Visible = false;
            panel_De_Agregar_Video.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_informacion.Visible = false;
            panel_ajustes.Visible = false;
            panelComentarios_Video.Visible = false;
            panel_Eliminar_Playlist.Visible = false;
            Mis_Playlist_Eliminar.Visible = false;
            panel_Ranking_de_Canciones.Visible = false;
            panel_Mostrar_Ranking_Canciones.Visible = false;
            panel_de_rankings.Visible = false;
            panelRecomendaciones.Visible = false;
            panel_eliminar_usuario.Visible = false;
        }
        private void Volver_de_Borrar_VidYCan_Click(object sender, EventArgs e)
        {
            //panel3.Visible = false;
            panel_datos_add_cancion.Visible = false;
            panel_informacion.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           
        }

        private void panel_de_rankings_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            //MessageBox.Show(ReproductorCancion.Ctlcontrols.currentPosition.ToString());
            double time = ReproductorCancion.Ctlcontrols.currentPosition;
            double time2 = ReproductorVideo.Ctlcontrols.currentPosition;
            double time3 = Reproductor_de_Playlist.Ctlcontrols.currentPosition;
            //ReproductorCancion.URL
            //ReproductorCancion.settings.defaultFrame = 10;
            string CancionPath = "";
            string VideosPath = "";
            if(ReproductorCancion.Ctlcontrols.currentItem != null)
            {
                CancionPath = ReproductorCancion.Ctlcontrols.currentItem.sourceURL;

            }
            if(ReproductorVideo.Ctlcontrols.currentItem != null)
            {
                VideosPath = ReproductorVideo.Ctlcontrols.currentItem.sourceURL;

            }
            

            
            if(user_enter != null)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream8 = new FileStream("ReproductionTime.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream8, time);
                formatter.Serialize(stream8, time2);
                formatter.Serialize(stream8, user_enter);
                formatter.Serialize(stream8, CancionPath);
                formatter.Serialize(stream8, VideosPath);

                stream8.Close();
            }




        }

        private void checkBoxHActor_nuevovid_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxMActores_nuevovid.Checked)
                checkBoxMActores_nuevovid.Checked = false;
        }

        private void checkBoxMActores_nuevovid_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxHActor_nuevovid.Checked)
                checkBoxHActor_nuevovid.Checked = false;
        }

        private void checkBoxM_direcvid_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkbtnHdirec_vid.Checked)
                checkbtnHdirec_vid.Checked = false;
        }

        private void checkbtnHdirec_vid_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxM_direcvid.Checked)
                checkBoxM_direcvid.Checked = false;
        }
    }
}
