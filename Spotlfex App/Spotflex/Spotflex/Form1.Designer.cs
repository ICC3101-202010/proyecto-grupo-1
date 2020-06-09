using System.Windows.Forms;

namespace Spotflex
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_iniciar_sesion = new System.Windows.Forms.Button();
            this.button_crear_sesion = new System.Windows.Forms.Button();
            this.panel_iniciar_sesion = new System.Windows.Forms.Panel();
            this.panel_crear_sesion = new System.Windows.Forms.Panel();
            this.panel_datos_usuario = new System.Windows.Forms.Panel();
            this.label_NombreUsuario = new System.Windows.Forms.Label();
            this.panel_comentarios_cancion = new System.Windows.Forms.Panel();
            this.panel_resultado_busqueda_general = new System.Windows.Forms.Panel();
            this.panel_usuario_buscado = new System.Windows.Forms.Panel();
            this.panel_info_artista = new System.Windows.Forms.Panel();
            this.panelReproducirVideo = new System.Windows.Forms.Panel();
            this.panel_busqueda_avanzada = new System.Windows.Forms.Panel();
            this.panel_playlist = new System.Windows.Forms.Panel();
            this.panel_resultado_busqueda_avanzada = new System.Windows.Forms.Panel();
            this.ReproducirPlaylist = new System.Windows.Forms.Panel();
            this.panel_favoritos = new System.Windows.Forms.Panel();
            this.panelComentarios_Video = new System.Windows.Forms.Panel();
            this.panel_Eliminar_Playlist = new System.Windows.Forms.Panel();
            this.panel_de_rankings = new System.Windows.Forms.Panel();
            this.panel_Ranking_de_Canciones = new System.Windows.Forms.Panel();
            this.panelRecomendaciones = new System.Windows.Forms.Panel();
            this.panel_eliminar_usuario = new System.Windows.Forms.Panel();
            this.pictureBox_atras_eliminar_usuario = new System.Windows.Forms.PictureBox();
            this.label_eliminar_usuario = new System.Windows.Forms.Label();
            this.labelText5 = new System.Windows.Forms.Label();
            this.labelText4 = new System.Windows.Forms.Label();
            this.labelText3 = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.picturelogoRecomendados = new System.Windows.Forms.PictureBox();
            this.labelRecomendados = new System.Windows.Forms.Label();
            this.pictureBoxRetroceder_Recomendaciones = new System.Windows.Forms.PictureBox();
            this.Volver_Ranking_video_y_canciones = new System.Windows.Forms.PictureBox();
            this.panel_Mostrar_Ranking_Canciones = new System.Windows.Forms.Panel();
            this.label_ranking_canciones = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mostrar_Ranking_Video = new System.Windows.Forms.PictureBox();
            this.Musica = new System.Windows.Forms.Label();
            this.Mostrar_Ranking_Musica = new System.Windows.Forms.PictureBox();
            this.Ranking = new System.Windows.Forms.Label();
            this.VolverDeBorrarPlaylist = new System.Windows.Forms.PictureBox();
            this.Mis_Playlist_Eliminar = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.labelComentarios_Video = new System.Windows.Forms.Label();
            this.buttonComentar_Video = new System.Windows.Forms.Button();
            this.richTextBoxComentar_Video = new System.Windows.Forms.RichTextBox();
            this.pictureBox_atras_favs = new System.Windows.Forms.PictureBox();
            this.label_tus_favoritos = new System.Windows.Forms.Label();
            this.pictureBox_tus_favoritos = new System.Windows.Forms.PictureBox();
            this.Volver_a_Playlist = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Reproductor_de_Playlist = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_resultado_busqueda_especifica = new System.Windows.Forms.Label();
            this.pictureBox_atras_busqueda_especifica = new System.Windows.Forms.PictureBox();
            this.picturebox_atras_playlist = new System.Windows.Forms.PictureBox();
            this.Nombre_Playlist_de_Videos = new System.Windows.Forms.Label();
            this.Nombre_Playlist_de_Canciones = new System.Windows.Forms.Label();
            this.textBox_Nombre_playlist_videos = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_playlist_canciones = new System.Windows.Forms.TextBox();
            this.Add_Video_Playlist = new System.Windows.Forms.PictureBox();
            this.Check_Videos_agregar_playlist = new System.Windows.Forms.CheckedListBox();
            this.Check_Canciones_agregar_playlist = new System.Windows.Forms.CheckedListBox();
            this.Add_Cancion_Playlist = new System.Windows.Forms.PictureBox();
            this.panel_playlist_mostrar = new System.Windows.Forms.Panel();
            this.Eliminar_Playlist = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_busqueda_or = new System.Windows.Forms.Button();
            this.label_hint_genero_busqueda = new System.Windows.Forms.Label();
            this.textBox_genero_busqueda = new System.Windows.Forms.TextBox();
            this.label_genero_busqueda = new System.Windows.Forms.Label();
            this.label_hint_busqueda_duracion = new System.Windows.Forms.Label();
            this.textBox_buscar_Calidad = new System.Windows.Forms.TextBox();
            this.label_busqueda_calidad = new System.Windows.Forms.Label();
            this.label_buscar_hint_duracion = new System.Windows.Forms.Label();
            this.textBox_buscar_duracion = new System.Windows.Forms.TextBox();
            this.label_busqueda_duracion = new System.Windows.Forms.Label();
            this.checkBox_buscar_mujer = new System.Windows.Forms.CheckBox();
            this.checkBox_buscar_hombre = new System.Windows.Forms.CheckBox();
            this.label_hint_edad_persona = new System.Windows.Forms.Label();
            this.textBox_edad_personas_buscar = new System.Windows.Forms.TextBox();
            this.textBox_nombre_personas_buscar = new System.Windows.Forms.TextBox();
            this.label_hint_nombre_busqueda = new System.Windows.Forms.Label();
            this.label_busqueda_genero_persona = new System.Windows.Forms.Label();
            this.label_busqueda_edad_personas = new System.Windows.Forms.Label();
            this.label_busqueda_personas_involucradas_nombre = new System.Windows.Forms.Label();
            this.label_busqueda_personas_involucradas = new System.Windows.Forms.Label();
            this.label_busqueda_palabras_clave_hint = new System.Windows.Forms.Label();
            this.label_busqueda_palabras_clave = new System.Windows.Forms.Label();
            this.textBox_palabras_clave_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_buscar_ranking = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_reproductor_Video = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ReproductorVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButtonFavoritoNuevoVideo = new System.Windows.Forms.RadioButton();
            this.pictureBox_Portada_VideoAlReproducir = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstrellaVideo5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstrellaVideo4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstrellaVideo3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstrellaVideo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstrellaVideo1 = new System.Windows.Forms.PictureBox();
            this.lblCalificacion_ReproducirVideo = new System.Windows.Forms.Label();
            this.btnAñadirALaCola_ReproducirVideo = new System.Windows.Forms.Button();
            this.btn_Comentarios_ReproducirVideo = new System.Windows.Forms.Button();
            this.lblDescripcionReproducirVideo = new System.Windows.Forms.Label();
            this.lblVisitasReproducirVideo = new System.Windows.Forms.Label();
            this.lblNotaReproducirvideo = new System.Windows.Forms.Label();
            this.lblDuracionReproducirvideo = new System.Windows.Forms.Label();
            this.lblEstudioReproducirVideo = new System.Windows.Forms.Label();
            this.lblGeneroReproducirVideo = new System.Windows.Forms.Label();
            this.lblActores_reproducirvideo = new System.Windows.Forms.Label();
            this.lblDirectores_ReproducirVideo = new System.Windows.Forms.Label();
            this.lblTituloDelVideoAReproducir = new System.Windows.Forms.Label();
            this.pictureBoxregresar_desde_reproducirvideo = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Reproducri_vid = new System.Windows.Forms.PictureBox();
            this.label_trabajo_artistas = new System.Windows.Forms.Label();
            this.button_seguir_artista = new System.Windows.Forms.Button();
            this.label_info_artista_seguidores = new System.Windows.Forms.Label();
            this.label_info_edad_Artista = new System.Windows.Forms.Label();
            this.label_info_ocupacion_artista = new System.Windows.Forms.Label();
            this.label_info_nombre_artista = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_archivos_subidos_por_usuario = new System.Windows.Forms.Label();
            this.label_info_usuario = new System.Windows.Forms.Label();
            this.button_seguir_usuario = new System.Windows.Forms.Button();
            this.label_seguidores = new System.Windows.Forms.Label();
            this.label_nickname_usuario = new System.Windows.Forms.Label();
            this.pictureBox_foto_perfil_usuario_buscado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_resultados_busquedas_general = new System.Windows.Forms.Label();
            this.pictureBox_atras_busqueda_general = new System.Windows.Forms.PictureBox();
            this.pictureBox_atras_comentarios_cancion = new System.Windows.Forms.PictureBox();
            this.button_comentar_cancion = new System.Windows.Forms.Button();
            this.richTextBox_caja_de_comentarios = new System.Windows.Forms.RichTextBox();
            this.label_subtitulo_comentarios_Cancion = new System.Windows.Forms.Label();
            this.pictureBox_recomendaciones = new System.Windows.Forms.PictureBox();
            this.pictureBox_see_ranking = new System.Windows.Forms.PictureBox();
            this.label_recomendaciones = new System.Windows.Forms.Label();
            this.label_ranking = new System.Windows.Forms.Label();
            this.label_cerrar_sesion = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.Label();
            this.pictureBox_Favoritos = new System.Windows.Forms.PictureBox();
            this.pictureBox_playlist = new System.Windows.Forms.PictureBox();
            this.label_Favoritos = new System.Windows.Forms.Label();
            this.label_Playlist_Usuario = new System.Windows.Forms.Label();
            this.panel_galeria = new System.Windows.Forms.Panel();
            this.panel_ajustes = new System.Windows.Forms.Panel();
            this.panel_informacion = new System.Windows.Forms.Panel();
            this.panel_datos_add_cancion = new System.Windows.Forms.Panel();
            this.panel_De_Agregar_Video = new System.Windows.Forms.Panel();
            this.panel_info_cancion = new System.Windows.Forms.Panel();
            this.panel_fijar_add_cancion = new System.Windows.Forms.Panel();
            this.panel_fijar_reproducir_cancion = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_size_cancion = new System.Windows.Forms.Label();
            this.pictureBox_download = new System.Windows.Forms.PictureBox();
            this.pictureBox_reproducir_cancion = new System.Windows.Forms.PictureBox();
            this.panel_reproductor_cancion = new System.Windows.Forms.Panel();
            this.pictureBox_salir = new System.Windows.Forms.PictureBox();
            this.ReproductorCancion = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox_5star_Canciones = new System.Windows.Forms.PictureBox();
            this.pictureBox_4star_Canciones = new System.Windows.Forms.PictureBox();
            this.pictureBox_3star_Canciones = new System.Windows.Forms.PictureBox();
            this.pictureBox_2star_Canciones = new System.Windows.Forms.PictureBox();
            this.pictureBox_1star_Canciones = new System.Windows.Forms.PictureBox();
            this.label_calificacion = new System.Windows.Forms.Label();
            this.radioButton_add_favorito = new System.Windows.Forms.RadioButton();
            this.button_add_cola_cancion = new System.Windows.Forms.Button();
            this.button_add_coment_cancion = new System.Windows.Forms.Button();
            this.label_cancion_descripcion = new System.Windows.Forms.Label();
            this.label_visitas_cancion = new System.Windows.Forms.Label();
            this.label_calificacion_cancion = new System.Windows.Forms.Label();
            this.pictureBox_calificacion_cancion = new System.Windows.Forms.PictureBox();
            this.pictureBox_vistas_cancion = new System.Windows.Forms.PictureBox();
            this.label_info_cancion_estudio = new System.Windows.Forms.Label();
            this.label_info_cancion_duracion = new System.Windows.Forms.Label();
            this.label_info_genero_cancion = new System.Windows.Forms.Label();
            this.label_cancion_info_album = new System.Windows.Forms.Label();
            this.label_cancion_Artistas = new System.Windows.Forms.Label();
            this.pictureBox_foto_cancion = new System.Windows.Forms.PictureBox();
            this.label_info_nombre_cancion = new System.Windows.Forms.Label();
            this.label_error_add_video = new System.Windows.Forms.Label();
            this.label_error_add_actor = new System.Windows.Forms.Label();
            this.label_error_video_director = new System.Windows.Forms.Label();
            this.pictureboxAtras_nuevovid = new System.Windows.Forms.PictureBox();
            this.btnExaminar_nuevovid = new System.Windows.Forms.Button();
            this.pictureBoxFoto_NuevoVid = new System.Windows.Forms.PictureBox();
            this.textBoxDirecorio_nuevovid = new System.Windows.Forms.TextBox();
            this.richTextBoxDescripcion_Nuevovid = new System.Windows.Forms.RichTextBox();
            this.textBoxGenero_nuevovid = new System.Windows.Forms.TextBox();
            this.lblDirectorio_nuevovid = new System.Windows.Forms.Label();
            this.lblPortada_nuevovid = new System.Windows.Forms.Label();
            this.lblDescripcion_Nuevovid = new System.Windows.Forms.Label();
            this.lblGeneros_nuevovid = new System.Windows.Forms.Label();
            this.checkBoxMActores_nuevovid = new System.Windows.Forms.CheckBox();
            this.checkBoxHActor_nuevovid = new System.Windows.Forms.CheckBox();
            this.textBoxEdadActor_nuevovid = new System.Windows.Forms.TextBox();
            this.textBoxNombreActor_nuevovid = new System.Windows.Forms.TextBox();
            this.lblSexoActores_nuevovid = new System.Windows.Forms.Label();
            this.lblNombreActores_nuevovid = new System.Windows.Forms.Label();
            this.lblEdadActores_Nuevovid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActores_nuevoVid = new System.Windows.Forms.Label();
            this.textBoxEstudio_nuevovid = new System.Windows.Forms.TextBox();
            this.dateTimePickerNuevoVid = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPublicacionNuevoVid = new System.Windows.Forms.Label();
            this.lblEstudio_nuevovid = new System.Windows.Forms.Label();
            this.btnAñadirOtro_direcvid = new System.Windows.Forms.Button();
            this.checkBoxM_direcvid = new System.Windows.Forms.CheckBox();
            this.checkbtnHdirec_vid = new System.Windows.Forms.CheckBox();
            this.textBoxEdadDirector_nuevovid = new System.Windows.Forms.TextBox();
            this.textBoxnombreDirector_nuevovid = new System.Windows.Forms.TextBox();
            this.textBoxtitulo_nuevovid = new System.Windows.Forms.TextBox();
            this.lblSexo_direc_vid = new System.Windows.Forms.Label();
            this.lblEdad_direc_vid = new System.Windows.Forms.Label();
            this.lblNombre_direc_vid = new System.Windows.Forms.Label();
            this.lblDirector_vid = new System.Windows.Forms.Label();
            this.lblTitulo_vid = new System.Windows.Forms.Label();
            this.lblEjemploVideo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Volver_de_Borrar_VidYCan = new System.Windows.Forms.PictureBox();
            this.panel_label_borrar_video = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_label_borrar_Cancion = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_add_genero = new System.Windows.Forms.Label();
            this.pictureBox_back_create_music = new System.Windows.Forms.PictureBox();
            this.button_add_more_artists = new System.Windows.Forms.Button();
            this.checkBox_sexo_mujer = new System.Windows.Forms.CheckBox();
            this.checkBox_sexo_hombre = new System.Windows.Forms.CheckBox();
            this.textBox_add_edad_artista = new System.Windows.Forms.TextBox();
            this.label_add_artista_sexo = new System.Windows.Forms.Label();
            this.label_add_edad_artista_cancion = new System.Windows.Forms.Label();
            this.richTextBox_add_descripcion_cancion = new System.Windows.Forms.RichTextBox();
            this.button_examinar_directorio = new System.Windows.Forms.Button();
            this.textBox_add_directorio_cancion = new System.Windows.Forms.TextBox();
            this.button_examinar_letra = new System.Windows.Forms.Button();
            this.textBox_add_letra_cancion = new System.Windows.Forms.TextBox();
            this.pictureBox_add_portada_cancion = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_add_fecha_publicacion_cancion = new System.Windows.Forms.DateTimePicker();
            this.textBox_add_estudio_cancion = new System.Windows.Forms.TextBox();
            this.textBox_add_album_artist = new System.Windows.Forms.TextBox();
            this.textBox_add_nombre_artista_cancion = new System.Windows.Forms.TextBox();
            this.textBox_add_titulo_cancion = new System.Windows.Forms.TextBox();
            this.label_add_directorio_cancion = new System.Windows.Forms.Label();
            this.label_add_letra_cancion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_add_descripcion_cancion = new System.Windows.Forms.Label();
            this.label_add_fecha_cancion = new System.Windows.Forms.Label();
            this.label_add_estudio_cancion = new System.Windows.Forms.Label();
            this.label_add_album_cancion = new System.Windows.Forms.Label();
            this.label_add_Artistas_cancion = new System.Windows.Forms.Label();
            this.label_add_titulo_cancion = new System.Windows.Forms.Label();
            this.panel_title_add_cancion = new System.Windows.Forms.Panel();
            this.panelAgregarunVid = new System.Windows.Forms.Panel();
            this.panel_fijar_info_cancion = new System.Windows.Forms.Panel();
            this.pictureBox_atras_cancion = new System.Windows.Forms.PictureBox();
            this.label_mensaje_cancion_descargada = new System.Windows.Forms.Label();
            this.pictureBoxAgregarElVIdeo_enNuevoVId = new System.Windows.Forms.PictureBox();
            this.lblAgregarNuevoVid = new System.Windows.Forms.Label();
            this.pictureBox_add_song_to_data = new System.Windows.Forms.PictureBox();
            this.label_add_cancion = new System.Windows.Forms.Label();
            this.label_error_add_artista = new System.Windows.Forms.Label();
            this.label_error_add_cancion = new System.Windows.Forms.Label();
            this.lblEjemploCanciones = new System.Windows.Forms.Label();
            this.textBox_add_generos_cancion = new System.Windows.Forms.TextBox();
            this.label_info_tipo_usuario = new System.Windows.Forms.Label();
            this.label_infoPrivate = new System.Windows.Forms.Label();
            this.label_info_Nombre = new System.Windows.Forms.Label();
            this.label_infoEdad = new System.Windows.Forms.Label();
            this.label_infoSeguidores = new System.Windows.Forms.Label();
            this.pictureBox_backtoconfig = new System.Windows.Forms.PictureBox();
            this.label_error_config = new System.Windows.Forms.Label();
            this.label_ver_info = new System.Windows.Forms.Label();
            this.pictureBox_Back1 = new System.Windows.Forms.PictureBox();
            this.label_borrar_usuario = new System.Windows.Forms.Label();
            this.button_cambiar_free = new System.Windows.Forms.Button();
            this.button_cmabiar_premium = new System.Windows.Forms.Button();
            this.label_cambiar_plan = new System.Windows.Forms.Label();
            this.button_guardar_cambios = new System.Windows.Forms.Button();
            this.button_cambiarPrivado = new System.Windows.Forms.Button();
            this.button_cambiar_publico = new System.Windows.Forms.Button();
            this.label_cambiar_tipoUsuario = new System.Windows.Forms.Label();
            this.textBox_cambiar_edad = new System.Windows.Forms.TextBox();
            this.textBox_cambiar_nombre = new System.Windows.Forms.TextBox();
            this.textBox_cambiar_clave = new System.Windows.Forms.TextBox();
            this.textBox_cambiarNick = new System.Windows.Forms.TextBox();
            this.label_cambiar_Edad = new System.Windows.Forms.Label();
            this.label_cambiar_nombre = new System.Windows.Forms.Label();
            this.label_cambiar_password = new System.Windows.Forms.Label();
            this.label_cambiar_nickname = new System.Windows.Forms.Label();
            this.label_cambiar_datos = new System.Windows.Forms.Label();
            this.BorrarVidYCan = new System.Windows.Forms.Label();
            this.panel_buscador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.picture_buscar = new System.Windows.Forms.PictureBox();
            this.button_buscar_filtro = new System.Windows.Forms.Button();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.panel_secc_video = new System.Windows.Forms.Panel();
            this.pictureBox_add_video = new System.Windows.Forms.PictureBox();
            this.label_indicador_Videos = new System.Windows.Forms.Label();
            this.panel_galeria_videos = new System.Windows.Forms.Panel();
            this.panel_galeria_canciones = new System.Windows.Forms.Panel();
            this.panel_secc_cancion = new System.Windows.Forms.Panel();
            this.pictureBox_add_music = new System.Windows.Forms.PictureBox();
            this.label_indicador_Canciones_Disp = new System.Windows.Forms.Label();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.label_error_registro = new System.Windows.Forms.Label();
            this.button_registrar = new System.Windows.Forms.Button();
            this.button_regresar = new System.Windows.Forms.Button();
            this.error_edad = new System.Windows.Forms.Label();
            this.error_plan_usuario = new System.Windows.Forms.Label();
            this.error_plan_sesion = new System.Windows.Forms.Label();
            this.error_nickname = new System.Windows.Forms.Label();
            this.error_clave = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.textBox_IngreseClave = new System.Windows.Forms.TextBox();
            this.textBox_IngreseNick = new System.Windows.Forms.TextBox();
            this.button_Premium = new System.Windows.Forms.Button();
            this.button_Gratuito = new System.Windows.Forms.Button();
            this.button_privado = new System.Windows.Forms.Button();
            this.button_publico = new System.Windows.Forms.Button();
            this.textBox_Ingrese_Edad = new System.Windows.Forms.TextBox();
            this.textBox_Ingrese_Nombre = new System.Windows.Forms.TextBox();
            this.label_tipo_usuario = new System.Windows.Forms.Label();
            this.label_premium_user = new System.Windows.Forms.Label();
            this.label_ingrese_nickname = new System.Windows.Forms.Label();
            this.label_ingrese_clave = new System.Windows.Forms.Label();
            this.label_ingrese_nombre = new System.Windows.Forms.Label();
            this.label_ingrese_edad = new System.Windows.Forms.Label();
            this.MensajeAcceso = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BotonInicio = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.NicknameText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_iniciar_sesion.SuspendLayout();
            this.panel_crear_sesion.SuspendLayout();
            this.panel_datos_usuario.SuspendLayout();
            this.panel_comentarios_cancion.SuspendLayout();
            this.panel_resultado_busqueda_general.SuspendLayout();
            this.panel_usuario_buscado.SuspendLayout();
            this.panel_info_artista.SuspendLayout();
            this.panelReproducirVideo.SuspendLayout();
            this.panel_busqueda_avanzada.SuspendLayout();
            this.panel_playlist.SuspendLayout();
            this.panel_resultado_busqueda_avanzada.SuspendLayout();
            this.ReproducirPlaylist.SuspendLayout();
            this.panel_favoritos.SuspendLayout();
            this.panelComentarios_Video.SuspendLayout();
            this.panel_Eliminar_Playlist.SuspendLayout();
            this.panel_de_rankings.SuspendLayout();
            this.panel_Ranking_de_Canciones.SuspendLayout();
            this.panelRecomendaciones.SuspendLayout();
            this.panel_eliminar_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_eliminar_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogoRecomendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroceder_Recomendaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volver_Ranking_video_y_canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Ranking_Video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Ranking_Musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolverDeBorrarPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_favs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tus_favoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volver_a_Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor_de_Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_busqueda_especifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_atras_playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Video_Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Cancion_Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_reproductor_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Portada_VideoAlReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxregresar_desde_reproducirvideo)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reproducri_vid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto_perfil_usuario_buscado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_busqueda_general)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_comentarios_cancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recomendaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_see_ranking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Favoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_playlist)).BeginInit();
            this.panel_galeria.SuspendLayout();
            this.panel_ajustes.SuspendLayout();
            this.panel_informacion.SuspendLayout();
            this.panel_datos_add_cancion.SuspendLayout();
            this.panel_De_Agregar_Video.SuspendLayout();
            this.panel_info_cancion.SuspendLayout();
            this.panel_fijar_add_cancion.SuspendLayout();
            this.panel_fijar_reproducir_cancion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reproducir_cancion)).BeginInit();
            this.panel_reproductor_cancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorCancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_5star_Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_4star_Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3star_Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2star_Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1star_Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_calificacion_cancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vistas_cancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto_cancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAtras_nuevovid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto_NuevoVid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volver_de_Borrar_VidYCan)).BeginInit();
            this.panel_label_borrar_video.SuspendLayout();
            this.panel_label_borrar_Cancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back_create_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_portada_cancion)).BeginInit();
            this.panel_title_add_cancion.SuspendLayout();
            this.panelAgregarunVid.SuspendLayout();
            this.panel_fijar_info_cancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_cancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarElVIdeo_enNuevoVId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_song_to_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoconfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back1)).BeginInit();
            this.panel_buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_buscar)).BeginInit();
            this.panel_secc_video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_video)).BeginInit();
            this.panel_secc_cancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // button_iniciar_sesion
            // 
            this.button_iniciar_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_iniciar_sesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar_sesion.Location = new System.Drawing.Point(291, 390);
            this.button_iniciar_sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_iniciar_sesion.Name = "button_iniciar_sesion";
            this.button_iniciar_sesion.Size = new System.Drawing.Size(460, 85);
            this.button_iniciar_sesion.TabIndex = 0;
            this.button_iniciar_sesion.Text = "Iniciar Sesion";
            this.button_iniciar_sesion.UseVisualStyleBackColor = true;
            this.button_iniciar_sesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_crear_sesion
            // 
            this.button_crear_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_crear_sesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_crear_sesion.Location = new System.Drawing.Point(291, 496);
            this.button_crear_sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_crear_sesion.Name = "button_crear_sesion";
            this.button_crear_sesion.Size = new System.Drawing.Size(460, 57);
            this.button_crear_sesion.TabIndex = 1;
            this.button_crear_sesion.Text = "Crear Sesion";
            this.button_crear_sesion.UseVisualStyleBackColor = true;
            this.button_crear_sesion.Click += new System.EventHandler(this.button_crear_sesion_Click);
            // 
            // panel_iniciar_sesion
            // 
            this.panel_iniciar_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_iniciar_sesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_iniciar_sesion.BackgroundImage")));
            this.panel_iniciar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_iniciar_sesion.Controls.Add(this.panel_crear_sesion);
            this.panel_iniciar_sesion.Controls.Add(this.MensajeAcceso);
            this.panel_iniciar_sesion.Controls.Add(this.BackButton);
            this.panel_iniciar_sesion.Controls.Add(this.BotonInicio);
            this.panel_iniciar_sesion.Controls.Add(this.PasswordText);
            this.panel_iniciar_sesion.Controls.Add(this.NicknameText);
            this.panel_iniciar_sesion.Controls.Add(this.PasswordLabel);
            this.panel_iniciar_sesion.Controls.Add(this.NicknameLabel);
            this.panel_iniciar_sesion.Location = new System.Drawing.Point(0, 0);
            this.panel_iniciar_sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_iniciar_sesion.MinimumSize = new System.Drawing.Size(1005, 721);
            this.panel_iniciar_sesion.Name = "panel_iniciar_sesion";
            this.panel_iniciar_sesion.Size = new System.Drawing.Size(1005, 721);
            this.panel_iniciar_sesion.TabIndex = 2;
            this.panel_iniciar_sesion.Visible = false;
            // 
            // panel_crear_sesion
            // 
            this.panel_crear_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_crear_sesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_crear_sesion.BackgroundImage")));
            this.panel_crear_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_crear_sesion.Controls.Add(this.panel_datos_usuario);
            this.panel_crear_sesion.Controls.Add(this.label_error_registro);
            this.panel_crear_sesion.Controls.Add(this.button_registrar);
            this.panel_crear_sesion.Controls.Add(this.button_regresar);
            this.panel_crear_sesion.Controls.Add(this.error_edad);
            this.panel_crear_sesion.Controls.Add(this.error_plan_usuario);
            this.panel_crear_sesion.Controls.Add(this.error_plan_sesion);
            this.panel_crear_sesion.Controls.Add(this.error_nickname);
            this.panel_crear_sesion.Controls.Add(this.error_clave);
            this.panel_crear_sesion.Controls.Add(this.error_nombre);
            this.panel_crear_sesion.Controls.Add(this.textBox_IngreseClave);
            this.panel_crear_sesion.Controls.Add(this.textBox_IngreseNick);
            this.panel_crear_sesion.Controls.Add(this.button_Premium);
            this.panel_crear_sesion.Controls.Add(this.button_Gratuito);
            this.panel_crear_sesion.Controls.Add(this.button_privado);
            this.panel_crear_sesion.Controls.Add(this.button_publico);
            this.panel_crear_sesion.Controls.Add(this.textBox_Ingrese_Edad);
            this.panel_crear_sesion.Controls.Add(this.textBox_Ingrese_Nombre);
            this.panel_crear_sesion.Controls.Add(this.label_tipo_usuario);
            this.panel_crear_sesion.Controls.Add(this.label_premium_user);
            this.panel_crear_sesion.Controls.Add(this.label_ingrese_nickname);
            this.panel_crear_sesion.Controls.Add(this.label_ingrese_clave);
            this.panel_crear_sesion.Controls.Add(this.label_ingrese_nombre);
            this.panel_crear_sesion.Controls.Add(this.label_ingrese_edad);
            this.panel_crear_sesion.Location = new System.Drawing.Point(0, 0);
            this.panel_crear_sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_crear_sesion.MinimumSize = new System.Drawing.Size(1005, 721);
            this.panel_crear_sesion.Name = "panel_crear_sesion";
            this.panel_crear_sesion.Size = new System.Drawing.Size(1005, 721);
            this.panel_crear_sesion.TabIndex = 8;
            this.panel_crear_sesion.Visible = false;
            // 
            // panel_datos_usuario
            // 
            this.panel_datos_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_datos_usuario.BackColor = System.Drawing.Color.Indigo;
            this.panel_datos_usuario.Controls.Add(this.label_NombreUsuario);
            this.panel_datos_usuario.Controls.Add(this.panel_comentarios_cancion);
            this.panel_datos_usuario.Controls.Add(this.pictureBox_recomendaciones);
            this.panel_datos_usuario.Controls.Add(this.pictureBox_see_ranking);
            this.panel_datos_usuario.Controls.Add(this.label_recomendaciones);
            this.panel_datos_usuario.Controls.Add(this.label_ranking);
            this.panel_datos_usuario.Controls.Add(this.label_cerrar_sesion);
            this.panel_datos_usuario.Controls.Add(this.Opciones);
            this.panel_datos_usuario.Controls.Add(this.pictureBox_Favoritos);
            this.panel_datos_usuario.Controls.Add(this.pictureBox_playlist);
            this.panel_datos_usuario.Controls.Add(this.label_Favoritos);
            this.panel_datos_usuario.Controls.Add(this.label_Playlist_Usuario);
            this.panel_datos_usuario.Controls.Add(this.panel_galeria);
            this.panel_datos_usuario.Controls.Add(this.FotoPerfil);
            this.panel_datos_usuario.Location = new System.Drawing.Point(0, 0);
            this.panel_datos_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_datos_usuario.MinimumSize = new System.Drawing.Size(1005, 721);
            this.panel_datos_usuario.Name = "panel_datos_usuario";
            this.panel_datos_usuario.Size = new System.Drawing.Size(1005, 721);
            this.panel_datos_usuario.TabIndex = 23;
            // 
            // label_NombreUsuario
            // 
            this.label_NombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NombreUsuario.AutoSize = true;
            this.label_NombreUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreUsuario.ForeColor = System.Drawing.Color.White;
            this.label_NombreUsuario.Location = new System.Drawing.Point(75, 176);
            this.label_NombreUsuario.Name = "label_NombreUsuario";
            this.label_NombreUsuario.Size = new System.Drawing.Size(107, 23);
            this.label_NombreUsuario.TabIndex = 1;
            this.label_NombreUsuario.Text = "Nickname";
            // 
            // panel_comentarios_cancion
            // 
            this.panel_comentarios_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_comentarios_cancion.AutoScroll = true;
            this.panel_comentarios_cancion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_comentarios_cancion.Controls.Add(this.panel_resultado_busqueda_general);
            this.panel_comentarios_cancion.Controls.Add(this.pictureBox_atras_comentarios_cancion);
            this.panel_comentarios_cancion.Controls.Add(this.button_comentar_cancion);
            this.panel_comentarios_cancion.Controls.Add(this.richTextBox_caja_de_comentarios);
            this.panel_comentarios_cancion.Controls.Add(this.label_subtitulo_comentarios_Cancion);
            this.panel_comentarios_cancion.Location = new System.Drawing.Point(262, 2);
            this.panel_comentarios_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_comentarios_cancion.Name = "panel_comentarios_cancion";
            this.panel_comentarios_cancion.Size = new System.Drawing.Size(746, 725);
            this.panel_comentarios_cancion.TabIndex = 2;
            this.panel_comentarios_cancion.Visible = false;
            // 
            // panel_resultado_busqueda_general
            // 
            this.panel_resultado_busqueda_general.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_resultado_busqueda_general.AutoScroll = true;
            this.panel_resultado_busqueda_general.Controls.Add(this.panel_usuario_buscado);
            this.panel_resultado_busqueda_general.Controls.Add(this.label_resultados_busquedas_general);
            this.panel_resultado_busqueda_general.Controls.Add(this.pictureBox_atras_busqueda_general);
            this.panel_resultado_busqueda_general.Location = new System.Drawing.Point(0, 0);
            this.panel_resultado_busqueda_general.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_resultado_busqueda_general.Name = "panel_resultado_busqueda_general";
            this.panel_resultado_busqueda_general.Size = new System.Drawing.Size(743, 723);
            this.panel_resultado_busqueda_general.TabIndex = 4;
            this.panel_resultado_busqueda_general.Visible = false;
            // 
            // panel_usuario_buscado
            // 
            this.panel_usuario_buscado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_usuario_buscado.AutoScroll = true;
            this.panel_usuario_buscado.Controls.Add(this.panel_info_artista);
            this.panel_usuario_buscado.Controls.Add(this.label_archivos_subidos_por_usuario);
            this.panel_usuario_buscado.Controls.Add(this.label_info_usuario);
            this.panel_usuario_buscado.Controls.Add(this.button_seguir_usuario);
            this.panel_usuario_buscado.Controls.Add(this.label_seguidores);
            this.panel_usuario_buscado.Controls.Add(this.label_nickname_usuario);
            this.panel_usuario_buscado.Controls.Add(this.pictureBox_foto_perfil_usuario_buscado);
            this.panel_usuario_buscado.Controls.Add(this.pictureBox1);
            this.panel_usuario_buscado.Location = new System.Drawing.Point(0, 0);
            this.panel_usuario_buscado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_usuario_buscado.Name = "panel_usuario_buscado";
            this.panel_usuario_buscado.Size = new System.Drawing.Size(743, 723);
            this.panel_usuario_buscado.TabIndex = 6;
            this.panel_usuario_buscado.Visible = false;
            // 
            // panel_info_artista
            // 
            this.panel_info_artista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_info_artista.AutoScroll = true;
            this.panel_info_artista.Controls.Add(this.panelReproducirVideo);
            this.panel_info_artista.Controls.Add(this.label_trabajo_artistas);
            this.panel_info_artista.Controls.Add(this.button_seguir_artista);
            this.panel_info_artista.Controls.Add(this.label_info_artista_seguidores);
            this.panel_info_artista.Controls.Add(this.label_info_edad_Artista);
            this.panel_info_artista.Controls.Add(this.label_info_ocupacion_artista);
            this.panel_info_artista.Controls.Add(this.label_info_nombre_artista);
            this.panel_info_artista.Controls.Add(this.pictureBox2);
            this.panel_info_artista.Location = new System.Drawing.Point(0, 0);
            this.panel_info_artista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_info_artista.Name = "panel_info_artista";
            this.panel_info_artista.Size = new System.Drawing.Size(743, 723);
            this.panel_info_artista.TabIndex = 12;
            this.panel_info_artista.Visible = false;
            // 
            // panelReproducirVideo
            // 
            this.panelReproducirVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReproducirVideo.Controls.Add(this.panel_busqueda_avanzada);
            this.panelReproducirVideo.Controls.Add(this.panel_reproductor_Video);
            this.panelReproducirVideo.Controls.Add(this.pictureBox4);
            this.panelReproducirVideo.Controls.Add(this.pictureBox3);
            this.panelReproducirVideo.Controls.Add(this.radioButtonFavoritoNuevoVideo);
            this.panelReproducirVideo.Controls.Add(this.pictureBox_Portada_VideoAlReproducir);
            this.panelReproducirVideo.Controls.Add(this.pictureBoxEstrellaVideo5);
            this.panelReproducirVideo.Controls.Add(this.pictureBoxEstrellaVideo4);
            this.panelReproducirVideo.Controls.Add(this.pictureBoxEstrellaVideo3);
            this.panelReproducirVideo.Controls.Add(this.pictureBoxEstrellaVideo2);
            this.panelReproducirVideo.Controls.Add(this.pictureBoxEstrellaVideo1);
            this.panelReproducirVideo.Controls.Add(this.lblCalificacion_ReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.btnAñadirALaCola_ReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.btn_Comentarios_ReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.lblDescripcionReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.lblVisitasReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.lblNotaReproducirvideo);
            this.panelReproducirVideo.Controls.Add(this.lblDuracionReproducirvideo);
            this.panelReproducirVideo.Controls.Add(this.lblEstudioReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.lblGeneroReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.lblActores_reproducirvideo);
            this.panelReproducirVideo.Controls.Add(this.lblDirectores_ReproducirVideo);
            this.panelReproducirVideo.Controls.Add(this.lblTituloDelVideoAReproducir);
            this.panelReproducirVideo.Controls.Add(this.pictureBoxregresar_desde_reproducirvideo);
            this.panelReproducirVideo.Controls.Add(this.panel7);
            this.panelReproducirVideo.Location = new System.Drawing.Point(0, 0);
            this.panelReproducirVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelReproducirVideo.Name = "panelReproducirVideo";
            this.panelReproducirVideo.Size = new System.Drawing.Size(743, 723);
            this.panelReproducirVideo.TabIndex = 14;
            this.panelReproducirVideo.Visible = false;
            // 
            // panel_busqueda_avanzada
            // 
            this.panel_busqueda_avanzada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_busqueda_avanzada.Controls.Add(this.panel_playlist);
            this.panel_busqueda_avanzada.Controls.Add(this.pictureBox6);
            this.panel_busqueda_avanzada.Controls.Add(this.button2);
            this.panel_busqueda_avanzada.Controls.Add(this.button_busqueda_or);
            this.panel_busqueda_avanzada.Controls.Add(this.label_hint_genero_busqueda);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_genero_busqueda);
            this.panel_busqueda_avanzada.Controls.Add(this.label_genero_busqueda);
            this.panel_busqueda_avanzada.Controls.Add(this.label_hint_busqueda_duracion);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_buscar_Calidad);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_calidad);
            this.panel_busqueda_avanzada.Controls.Add(this.label_buscar_hint_duracion);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_buscar_duracion);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_duracion);
            this.panel_busqueda_avanzada.Controls.Add(this.checkBox_buscar_mujer);
            this.panel_busqueda_avanzada.Controls.Add(this.checkBox_buscar_hombre);
            this.panel_busqueda_avanzada.Controls.Add(this.label_hint_edad_persona);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_edad_personas_buscar);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_nombre_personas_buscar);
            this.panel_busqueda_avanzada.Controls.Add(this.label_hint_nombre_busqueda);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_genero_persona);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_edad_personas);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_personas_involucradas_nombre);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_personas_involucradas);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_palabras_clave_hint);
            this.panel_busqueda_avanzada.Controls.Add(this.label_busqueda_palabras_clave);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_palabras_clave_buscar);
            this.panel_busqueda_avanzada.Controls.Add(this.label6);
            this.panel_busqueda_avanzada.Controls.Add(this.textBox_buscar_ranking);
            this.panel_busqueda_avanzada.Controls.Add(this.label7);
            this.panel_busqueda_avanzada.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda_avanzada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_busqueda_avanzada.Name = "panel_busqueda_avanzada";
            this.panel_busqueda_avanzada.Size = new System.Drawing.Size(743, 723);
            this.panel_busqueda_avanzada.TabIndex = 25;
            this.panel_busqueda_avanzada.Visible = false;
            // 
            // panel_playlist
            // 
            this.panel_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_playlist.BackgroundImage = global::Spotflex.Properties.Resources.playback;
            this.panel_playlist.Controls.Add(this.panel_resultado_busqueda_avanzada);
            this.panel_playlist.Controls.Add(this.picturebox_atras_playlist);
            this.panel_playlist.Controls.Add(this.Nombre_Playlist_de_Videos);
            this.panel_playlist.Controls.Add(this.Nombre_Playlist_de_Canciones);
            this.panel_playlist.Controls.Add(this.textBox_Nombre_playlist_videos);
            this.panel_playlist.Controls.Add(this.textBox_Nombre_playlist_canciones);
            this.panel_playlist.Controls.Add(this.Add_Video_Playlist);
            this.panel_playlist.Controls.Add(this.Check_Videos_agregar_playlist);
            this.panel_playlist.Controls.Add(this.Check_Canciones_agregar_playlist);
            this.panel_playlist.Controls.Add(this.Add_Cancion_Playlist);
            this.panel_playlist.Controls.Add(this.panel_playlist_mostrar);
            this.panel_playlist.Controls.Add(this.Eliminar_Playlist);
            this.panel_playlist.Location = new System.Drawing.Point(0, 0);
            this.panel_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_playlist.Name = "panel_playlist";
            this.panel_playlist.Size = new System.Drawing.Size(743, 723);
            this.panel_playlist.TabIndex = 26;
            this.panel_playlist.Visible = false;
            // 
            // panel_resultado_busqueda_avanzada
            // 
            this.panel_resultado_busqueda_avanzada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_resultado_busqueda_avanzada.Controls.Add(this.ReproducirPlaylist);
            this.panel_resultado_busqueda_avanzada.Controls.Add(this.label_resultado_busqueda_especifica);
            this.panel_resultado_busqueda_avanzada.Controls.Add(this.pictureBox_atras_busqueda_especifica);
            this.panel_resultado_busqueda_avanzada.Location = new System.Drawing.Point(0, 0);
            this.panel_resultado_busqueda_avanzada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_resultado_busqueda_avanzada.Name = "panel_resultado_busqueda_avanzada";
            this.panel_resultado_busqueda_avanzada.Size = new System.Drawing.Size(743, 723);
            this.panel_resultado_busqueda_avanzada.TabIndex = 9;
            this.panel_resultado_busqueda_avanzada.Visible = false;
            // 
            // ReproducirPlaylist
            // 
            this.ReproducirPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReproducirPlaylist.BackgroundImage = global::Spotflex.Properties.Resources.city;
            this.ReproducirPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReproducirPlaylist.Controls.Add(this.panel_favoritos);
            this.ReproducirPlaylist.Controls.Add(this.Volver_a_Playlist);
            this.ReproducirPlaylist.Controls.Add(this.label2);
            this.ReproducirPlaylist.Controls.Add(this.Reproductor_de_Playlist);
            this.ReproducirPlaylist.Location = new System.Drawing.Point(0, 0);
            this.ReproducirPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReproducirPlaylist.Name = "ReproducirPlaylist";
            this.ReproducirPlaylist.Size = new System.Drawing.Size(743, 723);
            this.ReproducirPlaylist.TabIndex = 28;
            this.ReproducirPlaylist.Visible = false;
            // 
            // panel_favoritos
            // 
            this.panel_favoritos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_favoritos.BackgroundImage = global::Spotflex.Properties.Resources.Favorites;
            this.panel_favoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_favoritos.Controls.Add(this.panelComentarios_Video);
            this.panel_favoritos.Controls.Add(this.pictureBox_atras_favs);
            this.panel_favoritos.Controls.Add(this.label_tus_favoritos);
            this.panel_favoritos.Controls.Add(this.pictureBox_tus_favoritos);
            this.panel_favoritos.Location = new System.Drawing.Point(0, 0);
            this.panel_favoritos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_favoritos.Name = "panel_favoritos";
            this.panel_favoritos.Size = new System.Drawing.Size(743, 723);
            this.panel_favoritos.TabIndex = 3;
            this.panel_favoritos.Visible = false;
            // 
            // panelComentarios_Video
            // 
            this.panelComentarios_Video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelComentarios_Video.AutoScroll = true;
            this.panelComentarios_Video.Controls.Add(this.panel_Eliminar_Playlist);
            this.panelComentarios_Video.Controls.Add(this.pictureBox9);
            this.panelComentarios_Video.Controls.Add(this.labelComentarios_Video);
            this.panelComentarios_Video.Controls.Add(this.buttonComentar_Video);
            this.panelComentarios_Video.Controls.Add(this.richTextBoxComentar_Video);
            this.panelComentarios_Video.Location = new System.Drawing.Point(0, 0);
            this.panelComentarios_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelComentarios_Video.Name = "panelComentarios_Video";
            this.panelComentarios_Video.Size = new System.Drawing.Size(743, 723);
            this.panelComentarios_Video.TabIndex = 10;
            // 
            // panel_Eliminar_Playlist
            // 
            this.panel_Eliminar_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Eliminar_Playlist.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Eliminar_Playlist.Controls.Add(this.panel_de_rankings);
            this.panel_Eliminar_Playlist.Controls.Add(this.VolverDeBorrarPlaylist);
            this.panel_Eliminar_Playlist.Controls.Add(this.Mis_Playlist_Eliminar);
            this.panel_Eliminar_Playlist.Location = new System.Drawing.Point(0, 0);
            this.panel_Eliminar_Playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Eliminar_Playlist.Name = "panel_Eliminar_Playlist";
            this.panel_Eliminar_Playlist.Size = new System.Drawing.Size(743, 723);
            this.panel_Eliminar_Playlist.TabIndex = 13;
            this.panel_Eliminar_Playlist.Visible = false;
            // 
            // panel_de_rankings
            // 
            this.panel_de_rankings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_de_rankings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_de_rankings.BackgroundImage = global::Spotflex.Properties.Resources.ranking2;
            this.panel_de_rankings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_de_rankings.Controls.Add(this.panel_Ranking_de_Canciones);
            this.panel_de_rankings.Controls.Add(this.pictureBox10);
            this.panel_de_rankings.Controls.Add(this.label3);
            this.panel_de_rankings.Controls.Add(this.Mostrar_Ranking_Video);
            this.panel_de_rankings.Controls.Add(this.Musica);
            this.panel_de_rankings.Controls.Add(this.Mostrar_Ranking_Musica);
            this.panel_de_rankings.Controls.Add(this.Ranking);
            this.panel_de_rankings.Location = new System.Drawing.Point(0, 0);
            this.panel_de_rankings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_de_rankings.Name = "panel_de_rankings";
            this.panel_de_rankings.Size = new System.Drawing.Size(743, 723);
            this.panel_de_rankings.TabIndex = 11;
            this.panel_de_rankings.Visible = false;
            this.panel_de_rankings.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_de_rankings_Paint);
            // 
            // panel_Ranking_de_Canciones
            // 
            this.panel_Ranking_de_Canciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Ranking_de_Canciones.BackgroundImage = global::Spotflex.Properties.Resources.disco;
            this.panel_Ranking_de_Canciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Ranking_de_Canciones.Controls.Add(this.panelRecomendaciones);
            this.panel_Ranking_de_Canciones.Controls.Add(this.Volver_Ranking_video_y_canciones);
            this.panel_Ranking_de_Canciones.Controls.Add(this.panel_Mostrar_Ranking_Canciones);
            this.panel_Ranking_de_Canciones.Controls.Add(this.label_ranking_canciones);
            this.panel_Ranking_de_Canciones.Location = new System.Drawing.Point(0, 0);
            this.panel_Ranking_de_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Ranking_de_Canciones.Name = "panel_Ranking_de_Canciones";
            this.panel_Ranking_de_Canciones.Size = new System.Drawing.Size(743, 723);
            this.panel_Ranking_de_Canciones.TabIndex = 7;
            this.panel_Ranking_de_Canciones.Visible = false;
            // 
            // panelRecomendaciones
            // 
            this.panelRecomendaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecomendaciones.Controls.Add(this.panel_eliminar_usuario);
            this.panelRecomendaciones.Controls.Add(this.labelText5);
            this.panelRecomendaciones.Controls.Add(this.labelText4);
            this.panelRecomendaciones.Controls.Add(this.labelText3);
            this.panelRecomendaciones.Controls.Add(this.labelText2);
            this.panelRecomendaciones.Controls.Add(this.labelText1);
            this.panelRecomendaciones.Controls.Add(this.picturelogoRecomendados);
            this.panelRecomendaciones.Controls.Add(this.labelRecomendados);
            this.panelRecomendaciones.Controls.Add(this.pictureBoxRetroceder_Recomendaciones);
            this.panelRecomendaciones.Location = new System.Drawing.Point(0, 0);
            this.panelRecomendaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRecomendaciones.Name = "panelRecomendaciones";
            this.panelRecomendaciones.Size = new System.Drawing.Size(743, 723);
            this.panelRecomendaciones.TabIndex = 8;
            this.panelRecomendaciones.Visible = false;
            // 
            // panel_eliminar_usuario
            // 
            this.panel_eliminar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_eliminar_usuario.AutoScroll = true;
            this.panel_eliminar_usuario.Controls.Add(this.pictureBox_atras_eliminar_usuario);
            this.panel_eliminar_usuario.Controls.Add(this.label_eliminar_usuario);
            this.panel_eliminar_usuario.Location = new System.Drawing.Point(0, 0);
            this.panel_eliminar_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_eliminar_usuario.Name = "panel_eliminar_usuario";
            this.panel_eliminar_usuario.Size = new System.Drawing.Size(743, 723);
            this.panel_eliminar_usuario.TabIndex = 8;
            this.panel_eliminar_usuario.Visible = false;
            // 
            // pictureBox_atras_eliminar_usuario
            // 
            this.pictureBox_atras_eliminar_usuario.Image = global::Spotflex.Properties.Resources._25618;
            this.pictureBox_atras_eliminar_usuario.Location = new System.Drawing.Point(21, 32);
            this.pictureBox_atras_eliminar_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_atras_eliminar_usuario.Name = "pictureBox_atras_eliminar_usuario";
            this.pictureBox_atras_eliminar_usuario.Size = new System.Drawing.Size(108, 49);
            this.pictureBox_atras_eliminar_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_atras_eliminar_usuario.TabIndex = 5;
            this.pictureBox_atras_eliminar_usuario.TabStop = false;
            this.pictureBox_atras_eliminar_usuario.Click += new System.EventHandler(this.pictureBox_atras_eliminar_usuario_Click);
            // 
            // label_eliminar_usuario
            // 
            this.label_eliminar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_eliminar_usuario.AutoSize = true;
            this.label_eliminar_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eliminar_usuario.ForeColor = System.Drawing.Color.Black;
            this.label_eliminar_usuario.Location = new System.Drawing.Point(20, 97);
            this.label_eliminar_usuario.Name = "label_eliminar_usuario";
            this.label_eliminar_usuario.Size = new System.Drawing.Size(442, 28);
            this.label_eliminar_usuario.TabIndex = 4;
            this.label_eliminar_usuario.Text = "Elija al usuario al cual desea eliminar";
            // 
            // labelText5
            // 
            this.labelText5.AutoSize = true;
            this.labelText5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText5.Location = new System.Drawing.Point(-1, 153);
            this.labelText5.Name = "labelText5";
            this.labelText5.Size = new System.Drawing.Size(711, 28);
            this.labelText5.TabIndex = 7;
            this.labelText5.Text = "No hay canciones y videos para recomendar en la aplicacion";
            // 
            // labelText4
            // 
            this.labelText4.AutoSize = true;
            this.labelText4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText4.Location = new System.Drawing.Point(19, 286);
            this.labelText4.Name = "labelText4";
            this.labelText4.Size = new System.Drawing.Size(311, 28);
            this.labelText4.TabIndex = 6;
            this.labelText4.Text = "Nuevas recomendaciones";
            // 
            // labelText3
            // 
            this.labelText3.AutoSize = true;
            this.labelText3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText3.Location = new System.Drawing.Point(19, 241);
            this.labelText3.Name = "labelText3";
            this.labelText3.Size = new System.Drawing.Size(635, 28);
            this.labelText3.TabIndex = 5;
            this.labelText3.Text = "Agrega canciones y Videos a favoritos para mostrarte";
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText2.Location = new System.Drawing.Point(20, 190);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(399, 28);
            this.labelText2.TabIndex = 4;
            this.labelText2.Text = "a las canciones y videos favoritos";
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.labelText1.Location = new System.Drawing.Point(19, 153);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(487, 28);
            this.labelText1.TabIndex = 3;
            this.labelText1.Text = "Las recomendaciones funcionan en base ";
            // 
            // picturelogoRecomendados
            // 
            this.picturelogoRecomendados.Image = global::Spotflex.Properties.Resources.pngocean_com__1_;
            this.picturelogoRecomendados.Location = new System.Drawing.Point(611, 14);
            this.picturelogoRecomendados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturelogoRecomendados.Name = "picturelogoRecomendados";
            this.picturelogoRecomendados.Size = new System.Drawing.Size(81, 66);
            this.picturelogoRecomendados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturelogoRecomendados.TabIndex = 2;
            this.picturelogoRecomendados.TabStop = false;
            // 
            // labelRecomendados
            // 
            this.labelRecomendados.AutoSize = true;
            this.labelRecomendados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecomendados.Location = new System.Drawing.Point(329, 34);
            this.labelRecomendados.Name = "labelRecomendados";
            this.labelRecomendados.Size = new System.Drawing.Size(270, 38);
            this.labelRecomendados.TabIndex = 1;
            this.labelRecomendados.Text = "Recomendados";
            // 
            // pictureBoxRetroceder_Recomendaciones
            // 
            this.pictureBoxRetroceder_Recomendaciones.Image = global::Spotflex.Properties.Resources._25618;
            this.pictureBoxRetroceder_Recomendaciones.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxRetroceder_Recomendaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRetroceder_Recomendaciones.Name = "pictureBoxRetroceder_Recomendaciones";
            this.pictureBoxRetroceder_Recomendaciones.Size = new System.Drawing.Size(108, 49);
            this.pictureBoxRetroceder_Recomendaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRetroceder_Recomendaciones.TabIndex = 0;
            this.pictureBoxRetroceder_Recomendaciones.TabStop = false;
            this.pictureBoxRetroceder_Recomendaciones.Click += new System.EventHandler(this.pictureBoxRetroceder_Recomendaciones_Click);
            // 
            // Volver_Ranking_video_y_canciones
            // 
            this.Volver_Ranking_video_y_canciones.Image = global::Spotflex.Properties.Resources._25618;
            this.Volver_Ranking_video_y_canciones.Location = new System.Drawing.Point(8, 14);
            this.Volver_Ranking_video_y_canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Volver_Ranking_video_y_canciones.Name = "Volver_Ranking_video_y_canciones";
            this.Volver_Ranking_video_y_canciones.Size = new System.Drawing.Size(103, 62);
            this.Volver_Ranking_video_y_canciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Volver_Ranking_video_y_canciones.TabIndex = 7;
            this.Volver_Ranking_video_y_canciones.TabStop = false;
            this.Volver_Ranking_video_y_canciones.Click += new System.EventHandler(this.Volver_Ranking_video_y_canciones_Click);
            // 
            // panel_Mostrar_Ranking_Canciones
            // 
            this.panel_Mostrar_Ranking_Canciones.AutoScroll = true;
            this.panel_Mostrar_Ranking_Canciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_Mostrar_Ranking_Canciones.Location = new System.Drawing.Point(29, 100);
            this.panel_Mostrar_Ranking_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Mostrar_Ranking_Canciones.Name = "panel_Mostrar_Ranking_Canciones";
            this.panel_Mostrar_Ranking_Canciones.Size = new System.Drawing.Size(683, 441);
            this.panel_Mostrar_Ranking_Canciones.TabIndex = 1;
            // 
            // label_ranking_canciones
            // 
            this.label_ranking_canciones.AutoSize = true;
            this.label_ranking_canciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_ranking_canciones.Font = new System.Drawing.Font("Viner Hand ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ranking_canciones.Location = new System.Drawing.Point(260, 23);
            this.label_ranking_canciones.Name = "label_ranking_canciones";
            this.label_ranking_canciones.Size = new System.Drawing.Size(205, 68);
            this.label_ranking_canciones.TabIndex = 0;
            this.label_ranking_canciones.Text = "Ranking";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Spotflex.Properties.Resources._25618;
            this.pictureBox10.Location = new System.Drawing.Point(9, 544);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(103, 62);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 6;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Mistral", 20F);
            this.label3.Location = new System.Drawing.Point(565, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Videos";
            // 
            // Mostrar_Ranking_Video
            // 
            this.Mostrar_Ranking_Video.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar_Ranking_Video.Image")));
            this.Mostrar_Ranking_Video.Location = new System.Drawing.Point(444, 186);
            this.Mostrar_Ranking_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mostrar_Ranking_Video.Name = "Mostrar_Ranking_Video";
            this.Mostrar_Ranking_Video.Size = new System.Drawing.Size(229, 239);
            this.Mostrar_Ranking_Video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mostrar_Ranking_Video.TabIndex = 3;
            this.Mostrar_Ranking_Video.TabStop = false;
            this.Mostrar_Ranking_Video.Click += new System.EventHandler(this.Mostrar_Ranking_Video_Click);
            // 
            // Musica
            // 
            this.Musica.AutoSize = true;
            this.Musica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Musica.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Musica.Location = new System.Drawing.Point(173, 190);
            this.Musica.Name = "Musica";
            this.Musica.Size = new System.Drawing.Size(94, 41);
            this.Musica.TabIndex = 2;
            this.Musica.Text = "Musica";
            // 
            // Mostrar_Ranking_Musica
            // 
            this.Mostrar_Ranking_Musica.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar_Ranking_Musica.Image")));
            this.Mostrar_Ranking_Musica.Location = new System.Drawing.Point(103, 188);
            this.Mostrar_Ranking_Musica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mostrar_Ranking_Musica.Name = "Mostrar_Ranking_Musica";
            this.Mostrar_Ranking_Musica.Size = new System.Drawing.Size(231, 242);
            this.Mostrar_Ranking_Musica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mostrar_Ranking_Musica.TabIndex = 1;
            this.Mostrar_Ranking_Musica.TabStop = false;
            this.Mostrar_Ranking_Musica.Click += new System.EventHandler(this.Mostrar_Ranking_Musica_Click_1);
            // 
            // Ranking
            // 
            this.Ranking.AutoSize = true;
            this.Ranking.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ranking.Location = new System.Drawing.Point(251, 30);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(214, 67);
            this.Ranking.TabIndex = 0;
            this.Ranking.Text = "Ranking";
            // 
            // VolverDeBorrarPlaylist
            // 
            this.VolverDeBorrarPlaylist.Image = global::Spotflex.Properties.Resources._25618;
            this.VolverDeBorrarPlaylist.Location = new System.Drawing.Point(571, 585);
            this.VolverDeBorrarPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VolverDeBorrarPlaylist.Name = "VolverDeBorrarPlaylist";
            this.VolverDeBorrarPlaylist.Size = new System.Drawing.Size(115, 59);
            this.VolverDeBorrarPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolverDeBorrarPlaylist.TabIndex = 10;
            this.VolverDeBorrarPlaylist.TabStop = false;
            this.VolverDeBorrarPlaylist.Click += new System.EventHandler(this.VolverDeBorrarPlaylist_Click_2);
            // 
            // Mis_Playlist_Eliminar
            // 
            this.Mis_Playlist_Eliminar.AutoScroll = true;
            this.Mis_Playlist_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mis_Playlist_Eliminar.ForeColor = System.Drawing.Color.Coral;
            this.Mis_Playlist_Eliminar.Location = new System.Drawing.Point(81, 23);
            this.Mis_Playlist_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mis_Playlist_Eliminar.Name = "Mis_Playlist_Eliminar";
            this.Mis_Playlist_Eliminar.Size = new System.Drawing.Size(319, 629);
            this.Mis_Playlist_Eliminar.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Spotflex.Properties.Resources._25618;
            this.pictureBox9.Location = new System.Drawing.Point(41, 18);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(113, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // labelComentarios_Video
            // 
            this.labelComentarios_Video.AutoSize = true;
            this.labelComentarios_Video.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentarios_Video.Location = new System.Drawing.Point(41, 262);
            this.labelComentarios_Video.Name = "labelComentarios_Video";
            this.labelComentarios_Video.Size = new System.Drawing.Size(119, 20);
            this.labelComentarios_Video.TabIndex = 2;
            this.labelComentarios_Video.Text = "Comentarios:";
            // 
            // buttonComentar_Video
            // 
            this.buttonComentar_Video.Location = new System.Drawing.Point(253, 207);
            this.buttonComentar_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComentar_Video.Name = "buttonComentar_Video";
            this.buttonComentar_Video.Size = new System.Drawing.Size(213, 26);
            this.buttonComentar_Video.TabIndex = 1;
            this.buttonComentar_Video.Text = "Comentar";
            this.buttonComentar_Video.UseVisualStyleBackColor = true;
            this.buttonComentar_Video.Click += new System.EventHandler(this.buttonComentar_Video_Click);
            // 
            // richTextBoxComentar_Video
            // 
            this.richTextBoxComentar_Video.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxComentar_Video.Location = new System.Drawing.Point(148, 64);
            this.richTextBoxComentar_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxComentar_Video.Name = "richTextBoxComentar_Video";
            this.richTextBoxComentar_Video.Size = new System.Drawing.Size(0, 131);
            this.richTextBoxComentar_Video.TabIndex = 0;
            this.richTextBoxComentar_Video.Text = "";
            // 
            // pictureBox_atras_favs
            // 
            this.pictureBox_atras_favs.Image = global::Spotflex.Properties.Resources._25618;
            this.pictureBox_atras_favs.Location = new System.Drawing.Point(33, 34);
            this.pictureBox_atras_favs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_atras_favs.Name = "pictureBox_atras_favs";
            this.pictureBox_atras_favs.Size = new System.Drawing.Size(115, 59);
            this.pictureBox_atras_favs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_atras_favs.TabIndex = 9;
            this.pictureBox_atras_favs.TabStop = false;
            this.pictureBox_atras_favs.Click += new System.EventHandler(this.pictureBox_atras_favs_Click);
            // 
            // label_tus_favoritos
            // 
            this.label_tus_favoritos.AutoSize = true;
            this.label_tus_favoritos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tus_favoritos.Location = new System.Drawing.Point(493, 46);
            this.label_tus_favoritos.Name = "label_tus_favoritos";
            this.label_tus_favoritos.Size = new System.Drawing.Size(151, 34);
            this.label_tus_favoritos.TabIndex = 8;
            this.label_tus_favoritos.Text = "Favoritos";
            // 
            // pictureBox_tus_favoritos
            // 
            this.pictureBox_tus_favoritos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tus_favoritos.Image")));
            this.pictureBox_tus_favoritos.Location = new System.Drawing.Point(651, 25);
            this.pictureBox_tus_favoritos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_tus_favoritos.Name = "pictureBox_tus_favoritos";
            this.pictureBox_tus_favoritos.Size = new System.Drawing.Size(69, 65);
            this.pictureBox_tus_favoritos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_tus_favoritos.TabIndex = 7;
            this.pictureBox_tus_favoritos.TabStop = false;
            // 
            // Volver_a_Playlist
            // 
            this.Volver_a_Playlist.Image = global::Spotflex.Properties.Resources._25618;
            this.Volver_a_Playlist.Location = new System.Drawing.Point(27, 25);
            this.Volver_a_Playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Volver_a_Playlist.Name = "Volver_a_Playlist";
            this.Volver_a_Playlist.Size = new System.Drawing.Size(115, 59);
            this.Volver_a_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Volver_a_Playlist.TabIndex = 2;
            this.Volver_a_Playlist.TabStop = false;
            this.Volver_a_Playlist.Click += new System.EventHandler(this.Volver_a_Playlist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "PlaylistName";
            // 
            // Reproductor_de_Playlist
            // 
            this.Reproductor_de_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reproductor_de_Playlist.Enabled = true;
            this.Reproductor_de_Playlist.Location = new System.Drawing.Point(66, 143);
            this.Reproductor_de_Playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reproductor_de_Playlist.Name = "Reproductor_de_Playlist";
            this.Reproductor_de_Playlist.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor_de_Playlist.OcxState")));
            this.Reproductor_de_Playlist.Size = new System.Drawing.Size(521, 327);
            this.Reproductor_de_Playlist.TabIndex = 0;
            // 
            // label_resultado_busqueda_especifica
            // 
            this.label_resultado_busqueda_especifica.AutoSize = true;
            this.label_resultado_busqueda_especifica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado_busqueda_especifica.Location = new System.Drawing.Point(189, 41);
            this.label_resultado_busqueda_especifica.Name = "label_resultado_busqueda_especifica";
            this.label_resultado_busqueda_especifica.Size = new System.Drawing.Size(449, 28);
            this.label_resultado_busqueda_especifica.TabIndex = 27;
            this.label_resultado_busqueda_especifica.Text = "Resultados de la busqueda especifica";
            // 
            // pictureBox_atras_busqueda_especifica
            // 
            this.pictureBox_atras_busqueda_especifica.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_atras_busqueda_especifica.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_atras_busqueda_especifica.Image")));
            this.pictureBox_atras_busqueda_especifica.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_atras_busqueda_especifica.InitialImage")));
            this.pictureBox_atras_busqueda_especifica.Location = new System.Drawing.Point(25, 26);
            this.pictureBox_atras_busqueda_especifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_atras_busqueda_especifica.Name = "pictureBox_atras_busqueda_especifica";
            this.pictureBox_atras_busqueda_especifica.Size = new System.Drawing.Size(123, 57);
            this.pictureBox_atras_busqueda_especifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_atras_busqueda_especifica.TabIndex = 26;
            this.pictureBox_atras_busqueda_especifica.TabStop = false;
            this.pictureBox_atras_busqueda_especifica.Click += new System.EventHandler(this.pictureBox_atras_busqueda_especifica_Click);
            // 
            // picturebox_atras_playlist
            // 
            this.picturebox_atras_playlist.BackColor = System.Drawing.Color.Transparent;
            this.picturebox_atras_playlist.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_atras_playlist.Image")));
            this.picturebox_atras_playlist.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturebox_atras_playlist.InitialImage")));
            this.picturebox_atras_playlist.Location = new System.Drawing.Point(421, 585);
            this.picturebox_atras_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebox_atras_playlist.Name = "picturebox_atras_playlist";
            this.picturebox_atras_playlist.Size = new System.Drawing.Size(120, 69);
            this.picturebox_atras_playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_atras_playlist.TabIndex = 28;
            this.picturebox_atras_playlist.TabStop = false;
            this.picturebox_atras_playlist.Click += new System.EventHandler(this.picturebox_atras_playlist_Click_1);
            // 
            // Nombre_Playlist_de_Videos
            // 
            this.Nombre_Playlist_de_Videos.AutoSize = true;
            this.Nombre_Playlist_de_Videos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Nombre_Playlist_de_Videos.Location = new System.Drawing.Point(427, 310);
            this.Nombre_Playlist_de_Videos.Name = "Nombre_Playlist_de_Videos";
            this.Nombre_Playlist_de_Videos.Size = new System.Drawing.Size(240, 20);
            this.Nombre_Playlist_de_Videos.TabIndex = 8;
            this.Nombre_Playlist_de_Videos.Text = "Nombre_Playlist_de_Videos";
            // 
            // Nombre_Playlist_de_Canciones
            // 
            this.Nombre_Playlist_de_Canciones.AutoSize = true;
            this.Nombre_Playlist_de_Canciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Nombre_Playlist_de_Canciones.Location = new System.Drawing.Point(415, 26);
            this.Nombre_Playlist_de_Canciones.Name = "Nombre_Playlist_de_Canciones";
            this.Nombre_Playlist_de_Canciones.Size = new System.Drawing.Size(270, 20);
            this.Nombre_Playlist_de_Canciones.TabIndex = 7;
            this.Nombre_Playlist_de_Canciones.Text = "Nombre_Playlist_de_Canciones";
            // 
            // textBox_Nombre_playlist_videos
            // 
            this.textBox_Nombre_playlist_videos.Location = new System.Drawing.Point(425, 332);
            this.textBox_Nombre_playlist_videos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Nombre_playlist_videos.Name = "textBox_Nombre_playlist_videos";
            this.textBox_Nombre_playlist_videos.Size = new System.Drawing.Size(237, 22);
            this.textBox_Nombre_playlist_videos.TabIndex = 6;
            // 
            // textBox_Nombre_playlist_canciones
            // 
            this.textBox_Nombre_playlist_canciones.Location = new System.Drawing.Point(425, 49);
            this.textBox_Nombre_playlist_canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Nombre_playlist_canciones.Name = "textBox_Nombre_playlist_canciones";
            this.textBox_Nombre_playlist_canciones.Size = new System.Drawing.Size(237, 22);
            this.textBox_Nombre_playlist_canciones.TabIndex = 5;
            // 
            // Add_Video_Playlist
            // 
            this.Add_Video_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("Add_Video_Playlist.Image")));
            this.Add_Video_Playlist.Location = new System.Drawing.Point(671, 415);
            this.Add_Video_Playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Video_Playlist.Name = "Add_Video_Playlist";
            this.Add_Video_Playlist.Size = new System.Drawing.Size(64, 65);
            this.Add_Video_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Video_Playlist.TabIndex = 4;
            this.Add_Video_Playlist.TabStop = false;
            this.Add_Video_Playlist.Click += new System.EventHandler(this.Add_Video_Playlist_Click);
            // 
            // Check_Videos_agregar_playlist
            // 
            this.Check_Videos_agregar_playlist.FormattingEnabled = true;
            this.Check_Videos_agregar_playlist.Location = new System.Drawing.Point(425, 359);
            this.Check_Videos_agregar_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_Videos_agregar_playlist.Name = "Check_Videos_agregar_playlist";
            this.Check_Videos_agregar_playlist.Size = new System.Drawing.Size(237, 191);
            this.Check_Videos_agregar_playlist.TabIndex = 3;
            // 
            // Check_Canciones_agregar_playlist
            // 
            this.Check_Canciones_agregar_playlist.FormattingEnabled = true;
            this.Check_Canciones_agregar_playlist.Location = new System.Drawing.Point(425, 78);
            this.Check_Canciones_agregar_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_Canciones_agregar_playlist.Name = "Check_Canciones_agregar_playlist";
            this.Check_Canciones_agregar_playlist.Size = new System.Drawing.Size(237, 191);
            this.Check_Canciones_agregar_playlist.TabIndex = 2;
            // 
            // Add_Cancion_Playlist
            // 
            this.Add_Cancion_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("Add_Cancion_Playlist.Image")));
            this.Add_Cancion_Playlist.Location = new System.Drawing.Point(675, 128);
            this.Add_Cancion_Playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Cancion_Playlist.Name = "Add_Cancion_Playlist";
            this.Add_Cancion_Playlist.Size = new System.Drawing.Size(64, 65);
            this.Add_Cancion_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Cancion_Playlist.TabIndex = 1;
            this.Add_Cancion_Playlist.TabStop = false;
            this.Add_Cancion_Playlist.Click += new System.EventHandler(this.Add_Cancion_Playlist_Click);
            // 
            // panel_playlist_mostrar
            // 
            this.panel_playlist_mostrar.AutoScroll = true;
            this.panel_playlist_mostrar.BackColor = System.Drawing.Color.Firebrick;
            this.panel_playlist_mostrar.Location = new System.Drawing.Point(17, 11);
            this.panel_playlist_mostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_playlist_mostrar.Name = "panel_playlist_mostrar";
            this.panel_playlist_mostrar.Size = new System.Drawing.Size(373, 647);
            this.panel_playlist_mostrar.TabIndex = 0;
            // 
            // Eliminar_Playlist
            // 
            this.Eliminar_Playlist.AutoSize = true;
            this.Eliminar_Playlist.BackColor = System.Drawing.Color.SlateBlue;
            this.Eliminar_Playlist.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Eliminar_Playlist.ForeColor = System.Drawing.Color.Indigo;
            this.Eliminar_Playlist.Location = new System.Drawing.Point(565, 601);
            this.Eliminar_Playlist.Name = "Eliminar_Playlist";
            this.Eliminar_Playlist.Size = new System.Drawing.Size(163, 23);
            this.Eliminar_Playlist.TabIndex = 33;
            this.Eliminar_Playlist.Text = "Eliminar Playlist";
            this.Eliminar_Playlist.Click += new System.EventHandler(this.Eliminar_Playlist_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(39, 26);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(123, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 572);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "BUSQUEDA \"AND\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_busqueda_or
            // 
            this.button_busqueda_or.Location = new System.Drawing.Point(89, 570);
            this.button_busqueda_or.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_busqueda_or.Name = "button_busqueda_or";
            this.button_busqueda_or.Size = new System.Drawing.Size(287, 38);
            this.button_busqueda_or.TabIndex = 22;
            this.button_busqueda_or.Text = "BUSQUEDA \"OR\"";
            this.button_busqueda_or.UseVisualStyleBackColor = true;
            this.button_busqueda_or.Click += new System.EventHandler(this.button_busqueda_or_Click);
            // 
            // label_hint_genero_busqueda
            // 
            this.label_hint_genero_busqueda.AutoSize = true;
            this.label_hint_genero_busqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hint_genero_busqueda.Location = new System.Drawing.Point(61, 501);
            this.label_hint_genero_busqueda.Name = "label_hint_genero_busqueda";
            this.label_hint_genero_busqueda.Size = new System.Drawing.Size(575, 17);
            this.label_hint_genero_busqueda.TabIndex = 21;
            this.label_hint_genero_busqueda.Text = "Si quiere poner mas de una palabra clave separelo por coma ej: accion,terror";
            // 
            // textBox_genero_busqueda
            // 
            this.textBox_genero_busqueda.Location = new System.Drawing.Point(149, 469);
            this.textBox_genero_busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_genero_busqueda.Name = "textBox_genero_busqueda";
            this.textBox_genero_busqueda.Size = new System.Drawing.Size(479, 22);
            this.textBox_genero_busqueda.TabIndex = 20;
            // 
            // label_genero_busqueda
            // 
            this.label_genero_busqueda.AutoSize = true;
            this.label_genero_busqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genero_busqueda.Location = new System.Drawing.Point(59, 471);
            this.label_genero_busqueda.Name = "label_genero_busqueda";
            this.label_genero_busqueda.Size = new System.Drawing.Size(69, 20);
            this.label_genero_busqueda.TabIndex = 19;
            this.label_genero_busqueda.Text = "Genero";
            // 
            // label_hint_busqueda_duracion
            // 
            this.label_hint_busqueda_duracion.AutoSize = true;
            this.label_hint_busqueda_duracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hint_busqueda_duracion.Location = new System.Drawing.Point(245, 383);
            this.label_hint_busqueda_duracion.Name = "label_hint_busqueda_duracion";
            this.label_hint_busqueda_duracion.Size = new System.Drawing.Size(462, 16);
            this.label_hint_busqueda_duracion.TabIndex = 18;
            this.label_hint_busqueda_duracion.Text = "Medido en p, tambien puede buscar por intervalos (ej: >480 o <480)";
            // 
            // textBox_buscar_Calidad
            // 
            this.textBox_buscar_Calidad.Location = new System.Drawing.Point(149, 379);
            this.textBox_buscar_Calidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_buscar_Calidad.Name = "textBox_buscar_Calidad";
            this.textBox_buscar_Calidad.Size = new System.Drawing.Size(80, 22);
            this.textBox_buscar_Calidad.TabIndex = 17;
            // 
            // label_busqueda_calidad
            // 
            this.label_busqueda_calidad.AutoSize = true;
            this.label_busqueda_calidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_calidad.Location = new System.Drawing.Point(30, 380);
            this.label_busqueda_calidad.Name = "label_busqueda_calidad";
            this.label_busqueda_calidad.Size = new System.Drawing.Size(100, 20);
            this.label_busqueda_calidad.TabIndex = 16;
            this.label_busqueda_calidad.Text = "Resolucion";
            // 
            // label_buscar_hint_duracion
            // 
            this.label_buscar_hint_duracion.AutoSize = true;
            this.label_buscar_hint_duracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar_hint_duracion.Location = new System.Drawing.Point(242, 337);
            this.label_buscar_hint_duracion.Name = "label_buscar_hint_duracion";
            this.label_buscar_hint_duracion.Size = new System.Drawing.Size(462, 16);
            this.label_buscar_hint_duracion.TabIndex = 15;
            this.label_buscar_hint_duracion.Text = "Medido en seg, tambien puede buscar por intervalos (ej: >20 o <20)";
            // 
            // textBox_buscar_duracion
            // 
            this.textBox_buscar_duracion.Location = new System.Drawing.Point(149, 332);
            this.textBox_buscar_duracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_buscar_duracion.Name = "textBox_buscar_duracion";
            this.textBox_buscar_duracion.Size = new System.Drawing.Size(80, 22);
            this.textBox_buscar_duracion.TabIndex = 14;
            // 
            // label_busqueda_duracion
            // 
            this.label_busqueda_duracion.AutoSize = true;
            this.label_busqueda_duracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_duracion.Location = new System.Drawing.Point(45, 332);
            this.label_busqueda_duracion.Name = "label_busqueda_duracion";
            this.label_busqueda_duracion.Size = new System.Drawing.Size(84, 20);
            this.label_busqueda_duracion.TabIndex = 13;
            this.label_busqueda_duracion.Text = "Duracion";
            // 
            // checkBox_buscar_mujer
            // 
            this.checkBox_buscar_mujer.AutoSize = true;
            this.checkBox_buscar_mujer.Location = new System.Drawing.Point(269, 290);
            this.checkBox_buscar_mujer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_buscar_mujer.Name = "checkBox_buscar_mujer";
            this.checkBox_buscar_mujer.Size = new System.Drawing.Size(65, 21);
            this.checkBox_buscar_mujer.TabIndex = 12;
            this.checkBox_buscar_mujer.Text = "Mujer";
            this.checkBox_buscar_mujer.UseVisualStyleBackColor = true;
            // 
            // checkBox_buscar_hombre
            // 
            this.checkBox_buscar_hombre.AutoSize = true;
            this.checkBox_buscar_hombre.Location = new System.Drawing.Point(165, 288);
            this.checkBox_buscar_hombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_buscar_hombre.Name = "checkBox_buscar_hombre";
            this.checkBox_buscar_hombre.Size = new System.Drawing.Size(80, 21);
            this.checkBox_buscar_hombre.TabIndex = 11;
            this.checkBox_buscar_hombre.Text = "Hombre";
            this.checkBox_buscar_hombre.UseVisualStyleBackColor = true;
            // 
            // label_hint_edad_persona
            // 
            this.label_hint_edad_persona.AutoSize = true;
            this.label_hint_edad_persona.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hint_edad_persona.Location = new System.Drawing.Point(247, 250);
            this.label_hint_edad_persona.Name = "label_hint_edad_persona";
            this.label_hint_edad_persona.Size = new System.Drawing.Size(446, 16);
            this.label_hint_edad_persona.TabIndex = 10;
            this.label_hint_edad_persona.Text = "Si quiere buscar por un grupo de edad puede poner ej: >35 o <35";
            // 
            // textBox_edad_personas_buscar
            // 
            this.textBox_edad_personas_buscar.Location = new System.Drawing.Point(162, 245);
            this.textBox_edad_personas_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_edad_personas_buscar.Name = "textBox_edad_personas_buscar";
            this.textBox_edad_personas_buscar.Size = new System.Drawing.Size(80, 22);
            this.textBox_edad_personas_buscar.TabIndex = 9;
            // 
            // textBox_nombre_personas_buscar
            // 
            this.textBox_nombre_personas_buscar.Location = new System.Drawing.Point(160, 191);
            this.textBox_nombre_personas_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nombre_personas_buscar.Name = "textBox_nombre_personas_buscar";
            this.textBox_nombre_personas_buscar.Size = new System.Drawing.Size(479, 22);
            this.textBox_nombre_personas_buscar.TabIndex = 8;
            // 
            // label_hint_nombre_busqueda
            // 
            this.label_hint_nombre_busqueda.AutoSize = true;
            this.label_hint_nombre_busqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hint_nombre_busqueda.Location = new System.Drawing.Point(160, 221);
            this.label_hint_nombre_busqueda.Name = "label_hint_nombre_busqueda";
            this.label_hint_nombre_busqueda.Size = new System.Drawing.Size(448, 16);
            this.label_hint_nombre_busqueda.TabIndex = 7;
            this.label_hint_nombre_busqueda.Text = "Si quiere poner mas de un artista separelo por coma ej: Ana,Juan";
            // 
            // label_busqueda_genero_persona
            // 
            this.label_busqueda_genero_persona.AutoSize = true;
            this.label_busqueda_genero_persona.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_genero_persona.Location = new System.Drawing.Point(90, 289);
            this.label_busqueda_genero_persona.Name = "label_busqueda_genero_persona";
            this.label_busqueda_genero_persona.Size = new System.Drawing.Size(63, 17);
            this.label_busqueda_genero_persona.TabIndex = 6;
            this.label_busqueda_genero_persona.Text = "Genero";
            // 
            // label_busqueda_edad_personas
            // 
            this.label_busqueda_edad_personas.AutoSize = true;
            this.label_busqueda_edad_personas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_edad_personas.Location = new System.Drawing.Point(112, 247);
            this.label_busqueda_edad_personas.Name = "label_busqueda_edad_personas";
            this.label_busqueda_edad_personas.Size = new System.Drawing.Size(45, 17);
            this.label_busqueda_edad_personas.TabIndex = 5;
            this.label_busqueda_edad_personas.Text = "Edad";
            // 
            // label_busqueda_personas_involucradas_nombre
            // 
            this.label_busqueda_personas_involucradas_nombre.AutoSize = true;
            this.label_busqueda_personas_involucradas_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_personas_involucradas_nombre.Location = new System.Drawing.Point(86, 193);
            this.label_busqueda_personas_involucradas_nombre.Name = "label_busqueda_personas_involucradas_nombre";
            this.label_busqueda_personas_involucradas_nombre.Size = new System.Drawing.Size(74, 17);
            this.label_busqueda_personas_involucradas_nombre.TabIndex = 4;
            this.label_busqueda_personas_involucradas_nombre.Text = "Nombres";
            // 
            // label_busqueda_personas_involucradas
            // 
            this.label_busqueda_personas_involucradas.AutoSize = true;
            this.label_busqueda_personas_involucradas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_personas_involucradas.Location = new System.Drawing.Point(40, 162);
            this.label_busqueda_personas_involucradas.Name = "label_busqueda_personas_involucradas";
            this.label_busqueda_personas_involucradas.Size = new System.Drawing.Size(195, 20);
            this.label_busqueda_personas_involucradas.TabIndex = 3;
            this.label_busqueda_personas_involucradas.Text = "Personas Involucradas";
            // 
            // label_busqueda_palabras_clave_hint
            // 
            this.label_busqueda_palabras_clave_hint.AutoSize = true;
            this.label_busqueda_palabras_clave_hint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_palabras_clave_hint.Location = new System.Drawing.Point(41, 129);
            this.label_busqueda_palabras_clave_hint.Name = "label_busqueda_palabras_clave_hint";
            this.label_busqueda_palabras_clave_hint.Size = new System.Drawing.Size(609, 17);
            this.label_busqueda_palabras_clave_hint.TabIndex = 2;
            this.label_busqueda_palabras_clave_hint.Text = "Si quiere poner mas de una palabra clave separelo por coma ej: risas,enamorados";
            // 
            // label_busqueda_palabras_clave
            // 
            this.label_busqueda_palabras_clave.AutoSize = true;
            this.label_busqueda_palabras_clave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busqueda_palabras_clave.Location = new System.Drawing.Point(40, 100);
            this.label_busqueda_palabras_clave.Name = "label_busqueda_palabras_clave";
            this.label_busqueda_palabras_clave.Size = new System.Drawing.Size(133, 20);
            this.label_busqueda_palabras_clave.TabIndex = 1;
            this.label_busqueda_palabras_clave.Text = "Palabras Clave";
            // 
            // textBox_palabras_clave_buscar
            // 
            this.textBox_palabras_clave_buscar.Location = new System.Drawing.Point(189, 100);
            this.textBox_palabras_clave_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_palabras_clave_buscar.Name = "textBox_palabras_clave_buscar";
            this.textBox_palabras_clave_buscar.Size = new System.Drawing.Size(479, 22);
            this.textBox_palabras_clave_buscar.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ranking";
            // 
            // textBox_buscar_ranking
            // 
            this.textBox_buscar_ranking.Location = new System.Drawing.Point(151, 422);
            this.textBox_buscar_ranking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_buscar_ranking.Name = "textBox_buscar_ranking";
            this.textBox_buscar_ranking.Size = new System.Drawing.Size(80, 22);
            this.textBox_buscar_ranking.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Puedes buscarlo igual a una calificacion o por intervalos (ej: >4 o <4)";
            // 
            // panel_reproductor_Video
            // 
            this.panel_reproductor_Video.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_reproductor_Video.Controls.Add(this.pictureBox5);
            this.panel_reproductor_Video.Controls.Add(this.ReproductorVideo);
            this.panel_reproductor_Video.Location = new System.Drawing.Point(0, 87);
            this.panel_reproductor_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_reproductor_Video.Name = "panel_reproductor_Video";
            this.panel_reproductor_Video.Size = new System.Drawing.Size(590, 313);
            this.panel_reproductor_Video.TabIndex = 23;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Spotflex.Properties.Resources.pngocean_com__3_;
            this.pictureBox5.Location = new System.Drawing.Point(565, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // ReproductorVideo
            // 
            this.ReproductorVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReproductorVideo.Enabled = true;
            this.ReproductorVideo.Location = new System.Drawing.Point(0, 0);
            this.ReproductorVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReproductorVideo.Name = "ReproductorVideo";
            this.ReproductorVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorVideo.OcxState")));
            this.ReproductorVideo.Size = new System.Drawing.Size(590, 313);
            this.ReproductorVideo.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Spotflex.Properties.Resources.pngocean_com__2_;
            this.pictureBox4.Location = new System.Drawing.Point(163, 343);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Spotflex.Properties.Resources._7514_Visto;
            this.pictureBox3.Location = new System.Drawing.Point(405, 343);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // radioButtonFavoritoNuevoVideo
            // 
            this.radioButtonFavoritoNuevoVideo.AutoSize = true;
            this.radioButtonFavoritoNuevoVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.radioButtonFavoritoNuevoVideo.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioButtonFavoritoNuevoVideo.Location = new System.Drawing.Point(223, 530);
            this.radioButtonFavoritoNuevoVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFavoritoNuevoVideo.Name = "radioButtonFavoritoNuevoVideo";
            this.radioButtonFavoritoNuevoVideo.Size = new System.Drawing.Size(128, 32);
            this.radioButtonFavoritoNuevoVideo.TabIndex = 20;
            this.radioButtonFavoritoNuevoVideo.TabStop = true;
            this.radioButtonFavoritoNuevoVideo.Text = "Favorito";
            this.radioButtonFavoritoNuevoVideo.UseVisualStyleBackColor = true;
            this.radioButtonFavoritoNuevoVideo.CheckedChanged += new System.EventHandler(this.radioButtonFavoritoNuevoVideo_CheckedChanged);
            // 
            // pictureBox_Portada_VideoAlReproducir
            // 
            this.pictureBox_Portada_VideoAlReproducir.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Portada_VideoAlReproducir.Location = new System.Drawing.Point(11, 95);
            this.pictureBox_Portada_VideoAlReproducir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Portada_VideoAlReproducir.Name = "pictureBox_Portada_VideoAlReproducir";
            this.pictureBox_Portada_VideoAlReproducir.Size = new System.Drawing.Size(283, 238);
            this.pictureBox_Portada_VideoAlReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Portada_VideoAlReproducir.TabIndex = 19;
            this.pictureBox_Portada_VideoAlReproducir.TabStop = false;
            // 
            // pictureBoxEstrellaVideo5
            // 
            this.pictureBoxEstrellaVideo5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEstrellaVideo5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo5.Image")));
            this.pictureBoxEstrellaVideo5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo5.InitialImage")));
            this.pictureBoxEstrellaVideo5.Location = new System.Drawing.Point(439, 571);
            this.pictureBoxEstrellaVideo5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEstrellaVideo5.Name = "pictureBoxEstrellaVideo5";
            this.pictureBoxEstrellaVideo5.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxEstrellaVideo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstrellaVideo5.TabIndex = 18;
            this.pictureBoxEstrellaVideo5.TabStop = false;
            this.pictureBoxEstrellaVideo5.Click += new System.EventHandler(this.pictureBoxEstrellaVideo5_Click);
            // 
            // pictureBoxEstrellaVideo4
            // 
            this.pictureBoxEstrellaVideo4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEstrellaVideo4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo4.Image")));
            this.pictureBoxEstrellaVideo4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo4.InitialImage")));
            this.pictureBoxEstrellaVideo4.Location = new System.Drawing.Point(357, 570);
            this.pictureBoxEstrellaVideo4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEstrellaVideo4.Name = "pictureBoxEstrellaVideo4";
            this.pictureBoxEstrellaVideo4.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxEstrellaVideo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstrellaVideo4.TabIndex = 17;
            this.pictureBoxEstrellaVideo4.TabStop = false;
            this.pictureBoxEstrellaVideo4.Click += new System.EventHandler(this.pictureBoxEstrellaVideo4_Click);
            // 
            // pictureBoxEstrellaVideo3
            // 
            this.pictureBoxEstrellaVideo3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEstrellaVideo3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo3.Image")));
            this.pictureBoxEstrellaVideo3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo3.InitialImage")));
            this.pictureBoxEstrellaVideo3.Location = new System.Drawing.Point(273, 569);
            this.pictureBoxEstrellaVideo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEstrellaVideo3.Name = "pictureBoxEstrellaVideo3";
            this.pictureBoxEstrellaVideo3.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxEstrellaVideo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstrellaVideo3.TabIndex = 16;
            this.pictureBoxEstrellaVideo3.TabStop = false;
            this.pictureBoxEstrellaVideo3.Click += new System.EventHandler(this.pictureBoxEstrellaVideo3_Click);
            // 
            // pictureBoxEstrellaVideo2
            // 
            this.pictureBoxEstrellaVideo2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEstrellaVideo2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo2.Image")));
            this.pictureBoxEstrellaVideo2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo2.InitialImage")));
            this.pictureBoxEstrellaVideo2.Location = new System.Drawing.Point(185, 569);
            this.pictureBoxEstrellaVideo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEstrellaVideo2.Name = "pictureBoxEstrellaVideo2";
            this.pictureBoxEstrellaVideo2.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxEstrellaVideo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstrellaVideo2.TabIndex = 15;
            this.pictureBoxEstrellaVideo2.TabStop = false;
            this.pictureBoxEstrellaVideo2.Click += new System.EventHandler(this.pictureBoxEstrellaVideo2_Click);
            // 
            // pictureBoxEstrellaVideo1
            // 
            this.pictureBoxEstrellaVideo1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEstrellaVideo1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo1.Image")));
            this.pictureBoxEstrellaVideo1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstrellaVideo1.InitialImage")));
            this.pictureBoxEstrellaVideo1.Location = new System.Drawing.Point(101, 567);
            this.pictureBoxEstrellaVideo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEstrellaVideo1.Name = "pictureBoxEstrellaVideo1";
            this.pictureBoxEstrellaVideo1.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxEstrellaVideo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstrellaVideo1.TabIndex = 14;
            this.pictureBoxEstrellaVideo1.TabStop = false;
            this.pictureBoxEstrellaVideo1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblCalificacion_ReproducirVideo
            // 
            this.lblCalificacion_ReproducirVideo.AutoSize = true;
            this.lblCalificacion_ReproducirVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion_ReproducirVideo.Location = new System.Drawing.Point(237, 640);
            this.lblCalificacion_ReproducirVideo.Name = "lblCalificacion_ReproducirVideo";
            this.lblCalificacion_ReproducirVideo.Size = new System.Drawing.Size(108, 20);
            this.lblCalificacion_ReproducirVideo.TabIndex = 13;
            this.lblCalificacion_ReproducirVideo.Text = "Calificacion";
            // 
            // btnAñadirALaCola_ReproducirVideo
            // 
            this.btnAñadirALaCola_ReproducirVideo.Location = new System.Drawing.Point(301, 485);
            this.btnAñadirALaCola_ReproducirVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirALaCola_ReproducirVideo.Name = "btnAñadirALaCola_ReproducirVideo";
            this.btnAñadirALaCola_ReproducirVideo.Size = new System.Drawing.Size(237, 47);
            this.btnAñadirALaCola_ReproducirVideo.TabIndex = 12;
            this.btnAñadirALaCola_ReproducirVideo.Text = "Añadir a la Cola";
            this.btnAñadirALaCola_ReproducirVideo.UseVisualStyleBackColor = true;
            this.btnAñadirALaCola_ReproducirVideo.Click += new System.EventHandler(this.btnAñadirALaCola_ReproducirVideo_Click);
            // 
            // btn_Comentarios_ReproducirVideo
            // 
            this.btn_Comentarios_ReproducirVideo.Location = new System.Drawing.Point(31, 485);
            this.btn_Comentarios_ReproducirVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Comentarios_ReproducirVideo.Name = "btn_Comentarios_ReproducirVideo";
            this.btn_Comentarios_ReproducirVideo.Size = new System.Drawing.Size(237, 47);
            this.btn_Comentarios_ReproducirVideo.TabIndex = 11;
            this.btn_Comentarios_ReproducirVideo.Text = "Comentario";
            this.btn_Comentarios_ReproducirVideo.UseVisualStyleBackColor = true;
            this.btn_Comentarios_ReproducirVideo.Click += new System.EventHandler(this.btn_Comentarios_ReproducirVideo_Click);
            // 
            // lblDescripcionReproducirVideo
            // 
            this.lblDescripcionReproducirVideo.AutoSize = true;
            this.lblDescripcionReproducirVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionReproducirVideo.Location = new System.Drawing.Point(76, 415);
            this.lblDescripcionReproducirVideo.Name = "lblDescripcionReproducirVideo";
            this.lblDescripcionReproducirVideo.Size = new System.Drawing.Size(109, 20);
            this.lblDescripcionReproducirVideo.TabIndex = 10;
            this.lblDescripcionReproducirVideo.Text = "Descripcion";
            // 
            // lblVisitasReproducirVideo
            // 
            this.lblVisitasReproducirVideo.AutoSize = true;
            this.lblVisitasReproducirVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitasReproducirVideo.Location = new System.Drawing.Point(476, 347);
            this.lblVisitasReproducirVideo.Name = "lblVisitasReproducirVideo";
            this.lblVisitasReproducirVideo.Size = new System.Drawing.Size(70, 20);
            this.lblVisitasReproducirVideo.TabIndex = 9;
            this.lblVisitasReproducirVideo.Text = "Visitas:";
            // 
            // lblNotaReproducirvideo
            // 
            this.lblNotaReproducirvideo.AutoSize = true;
            this.lblNotaReproducirvideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaReproducirvideo.Location = new System.Drawing.Point(227, 351);
            this.lblNotaReproducirvideo.Name = "lblNotaReproducirvideo";
            this.lblNotaReproducirvideo.Size = new System.Drawing.Size(53, 20);
            this.lblNotaReproducirvideo.TabIndex = 8;
            this.lblNotaReproducirvideo.Text = "Nota:";
            // 
            // lblDuracionReproducirvideo
            // 
            this.lblDuracionReproducirvideo.AutoSize = true;
            this.lblDuracionReproducirvideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionReproducirvideo.Location = new System.Drawing.Point(309, 300);
            this.lblDuracionReproducirvideo.Name = "lblDuracionReproducirvideo";
            this.lblDuracionReproducirvideo.Size = new System.Drawing.Size(84, 20);
            this.lblDuracionReproducirvideo.TabIndex = 7;
            this.lblDuracionReproducirvideo.Text = "Duracion";
            // 
            // lblEstudioReproducirVideo
            // 
            this.lblEstudioReproducirVideo.AutoSize = true;
            this.lblEstudioReproducirVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudioReproducirVideo.Location = new System.Drawing.Point(309, 272);
            this.lblEstudioReproducirVideo.Name = "lblEstudioReproducirVideo";
            this.lblEstudioReproducirVideo.Size = new System.Drawing.Size(71, 20);
            this.lblEstudioReproducirVideo.TabIndex = 6;
            this.lblEstudioReproducirVideo.Text = "Estudio";
            // 
            // lblGeneroReproducirVideo
            // 
            this.lblGeneroReproducirVideo.AutoSize = true;
            this.lblGeneroReproducirVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroReproducirVideo.Location = new System.Drawing.Point(308, 239);
            this.lblGeneroReproducirVideo.Name = "lblGeneroReproducirVideo";
            this.lblGeneroReproducirVideo.Size = new System.Drawing.Size(83, 20);
            this.lblGeneroReproducirVideo.TabIndex = 5;
            this.lblGeneroReproducirVideo.Text = "Generos:";
            // 
            // lblActores_reproducirvideo
            // 
            this.lblActores_reproducirvideo.AutoSize = true;
            this.lblActores_reproducirvideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActores_reproducirvideo.Location = new System.Drawing.Point(308, 182);
            this.lblActores_reproducirvideo.Name = "lblActores_reproducirvideo";
            this.lblActores_reproducirvideo.Size = new System.Drawing.Size(73, 20);
            this.lblActores_reproducirvideo.TabIndex = 4;
            this.lblActores_reproducirvideo.Text = "Actores";
            // 
            // lblDirectores_ReproducirVideo
            // 
            this.lblDirectores_ReproducirVideo.AutoSize = true;
            this.lblDirectores_ReproducirVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectores_ReproducirVideo.Location = new System.Drawing.Point(305, 97);
            this.lblDirectores_ReproducirVideo.Name = "lblDirectores_ReproducirVideo";
            this.lblDirectores_ReproducirVideo.Size = new System.Drawing.Size(101, 20);
            this.lblDirectores_ReproducirVideo.TabIndex = 3;
            this.lblDirectores_ReproducirVideo.Text = "Directores:";
            // 
            // lblTituloDelVideoAReproducir
            // 
            this.lblTituloDelVideoAReproducir.AutoSize = true;
            this.lblTituloDelVideoAReproducir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblTituloDelVideoAReproducir.Location = new System.Drawing.Point(79, 50);
            this.lblTituloDelVideoAReproducir.Name = "lblTituloDelVideoAReproducir";
            this.lblTituloDelVideoAReproducir.Size = new System.Drawing.Size(82, 29);
            this.lblTituloDelVideoAReproducir.TabIndex = 2;
            this.lblTituloDelVideoAReproducir.Text = "Titulo";
            // 
            // pictureBoxregresar_desde_reproducirvideo
            // 
            this.pictureBoxregresar_desde_reproducirvideo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxregresar_desde_reproducirvideo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxregresar_desde_reproducirvideo.Image")));
            this.pictureBoxregresar_desde_reproducirvideo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxregresar_desde_reproducirvideo.InitialImage")));
            this.pictureBoxregresar_desde_reproducirvideo.Location = new System.Drawing.Point(7, 2);
            this.pictureBoxregresar_desde_reproducirvideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxregresar_desde_reproducirvideo.Name = "pictureBoxregresar_desde_reproducirvideo";
            this.pictureBoxregresar_desde_reproducirvideo.Size = new System.Drawing.Size(100, 44);
            this.pictureBoxregresar_desde_reproducirvideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxregresar_desde_reproducirvideo.TabIndex = 1;
            this.pictureBoxregresar_desde_reproducirvideo.TabStop = false;
            this.pictureBoxregresar_desde_reproducirvideo.Click += new System.EventHandler(this.pictureBoxregresar_desde_reproducirvideo_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox8);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.pictureBox_Reproducri_vid);
            this.panel7.Location = new System.Drawing.Point(666, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(91, 719);
            this.panel7.TabIndex = 24;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Spotflex.Properties.Resources.reproducir;
            this.pictureBox8.InitialImage = global::Spotflex.Properties.Resources.reproducir;
            this.pictureBox8.Location = new System.Drawing.Point(-3, 50);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(88, 92);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox_Reproducri_vid
            // 
            this.pictureBox_Reproducri_vid.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Reproducri_vid.InitialImage = null;
            this.pictureBox_Reproducri_vid.Location = new System.Drawing.Point(-1, 32);
            this.pictureBox_Reproducri_vid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Reproducri_vid.Name = "pictureBox_Reproducri_vid";
            this.pictureBox_Reproducri_vid.Size = new System.Drawing.Size(96, 94);
            this.pictureBox_Reproducri_vid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Reproducri_vid.TabIndex = 0;
            this.pictureBox_Reproducri_vid.TabStop = false;
            // 
            // label_trabajo_artistas
            // 
            this.label_trabajo_artistas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_trabajo_artistas.AutoSize = true;
            this.label_trabajo_artistas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trabajo_artistas.Location = new System.Drawing.Point(139, 330);
            this.label_trabajo_artistas.Name = "label_trabajo_artistas";
            this.label_trabajo_artistas.Size = new System.Drawing.Size(209, 23);
            this.label_trabajo_artistas.TabIndex = 13;
            this.label_trabajo_artistas.Text = "Trabajos realizados:";
            // 
            // button_seguir_artista
            // 
            this.button_seguir_artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seguir_artista.Location = new System.Drawing.Point(141, 260);
            this.button_seguir_artista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_seguir_artista.Name = "button_seguir_artista";
            this.button_seguir_artista.Size = new System.Drawing.Size(129, 41);
            this.button_seguir_artista.TabIndex = 12;
            this.button_seguir_artista.Text = "Seguir";
            this.button_seguir_artista.UseVisualStyleBackColor = true;
            this.button_seguir_artista.Click += new System.EventHandler(this.button_seguir_artista_Click);
            // 
            // label_info_artista_seguidores
            // 
            this.label_info_artista_seguidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info_artista_seguidores.AutoSize = true;
            this.label_info_artista_seguidores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_artista_seguidores.Location = new System.Drawing.Point(139, 225);
            this.label_info_artista_seguidores.Name = "label_info_artista_seguidores";
            this.label_info_artista_seguidores.Size = new System.Drawing.Size(128, 23);
            this.label_info_artista_seguidores.TabIndex = 11;
            this.label_info_artista_seguidores.Text = "Seguidores:";
            // 
            // label_info_edad_Artista
            // 
            this.label_info_edad_Artista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info_edad_Artista.AutoSize = true;
            this.label_info_edad_Artista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_edad_Artista.Location = new System.Drawing.Point(139, 190);
            this.label_info_edad_Artista.Name = "label_info_edad_Artista";
            this.label_info_edad_Artista.Size = new System.Drawing.Size(67, 23);
            this.label_info_edad_Artista.TabIndex = 10;
            this.label_info_edad_Artista.Text = "Edad:";
            // 
            // label_info_ocupacion_artista
            // 
            this.label_info_ocupacion_artista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info_ocupacion_artista.AutoSize = true;
            this.label_info_ocupacion_artista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_ocupacion_artista.Location = new System.Drawing.Point(137, 154);
            this.label_info_ocupacion_artista.Name = "label_info_ocupacion_artista";
            this.label_info_ocupacion_artista.Size = new System.Drawing.Size(122, 23);
            this.label_info_ocupacion_artista.TabIndex = 9;
            this.label_info_ocupacion_artista.Text = "Ocupacion:";
            // 
            // label_info_nombre_artista
            // 
            this.label_info_nombre_artista.AutoSize = true;
            this.label_info_nombre_artista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_nombre_artista.Location = new System.Drawing.Point(135, 100);
            this.label_info_nombre_artista.Name = "label_info_nombre_artista";
            this.label_info_nombre_artista.Size = new System.Drawing.Size(224, 32);
            this.label_info_nombre_artista.TabIndex = 8;
            this.label_info_nombre_artista.Text = "Nombre Artista";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label_archivos_subidos_por_usuario
            // 
            this.label_archivos_subidos_por_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_archivos_subidos_por_usuario.AutoSize = true;
            this.label_archivos_subidos_por_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_archivos_subidos_por_usuario.Location = new System.Drawing.Point(91, 391);
            this.label_archivos_subidos_por_usuario.Name = "label_archivos_subidos_por_usuario";
            this.label_archivos_subidos_por_usuario.Size = new System.Drawing.Size(358, 23);
            this.label_archivos_subidos_por_usuario.TabIndex = 11;
            this.label_archivos_subidos_por_usuario.Text = "Archivos Subidos por este Usuario: ";
            // 
            // label_info_usuario
            // 
            this.label_info_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info_usuario.AutoSize = true;
            this.label_info_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_usuario.Location = new System.Drawing.Point(91, 294);
            this.label_info_usuario.Name = "label_info_usuario";
            this.label_info_usuario.Size = new System.Drawing.Size(254, 23);
            this.label_info_usuario.TabIndex = 10;
            this.label_info_usuario.Text = "Informacion del Usuario: ";
            // 
            // button_seguir_usuario
            // 
            this.button_seguir_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seguir_usuario.Location = new System.Drawing.Point(289, 229);
            this.button_seguir_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_seguir_usuario.Name = "button_seguir_usuario";
            this.button_seguir_usuario.Size = new System.Drawing.Size(129, 41);
            this.button_seguir_usuario.TabIndex = 9;
            this.button_seguir_usuario.Text = "Seguir";
            this.button_seguir_usuario.UseVisualStyleBackColor = true;
            this.button_seguir_usuario.Click += new System.EventHandler(this.button_seguir_usuario_Click);
            // 
            // label_seguidores
            // 
            this.label_seguidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_seguidores.AutoSize = true;
            this.label_seguidores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seguidores.Location = new System.Drawing.Point(288, 175);
            this.label_seguidores.Name = "label_seguidores";
            this.label_seguidores.Size = new System.Drawing.Size(133, 23);
            this.label_seguidores.TabIndex = 8;
            this.label_seguidores.Text = "Seguidores: ";
            // 
            // label_nickname_usuario
            // 
            this.label_nickname_usuario.AutoSize = true;
            this.label_nickname_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nickname_usuario.Location = new System.Drawing.Point(281, 122);
            this.label_nickname_usuario.Name = "label_nickname_usuario";
            this.label_nickname_usuario.Size = new System.Drawing.Size(239, 32);
            this.label_nickname_usuario.TabIndex = 7;
            this.label_nickname_usuario.Text = "Nombre Usuario";
            // 
            // pictureBox_foto_perfil_usuario_buscado
            // 
            this.pictureBox_foto_perfil_usuario_buscado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_foto_perfil_usuario_buscado.Location = new System.Drawing.Point(92, 121);
            this.pictureBox_foto_perfil_usuario_buscado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_foto_perfil_usuario_buscado.Name = "pictureBox_foto_perfil_usuario_buscado";
            this.pictureBox_foto_perfil_usuario_buscado.Size = new System.Drawing.Size(157, 151);
            this.pictureBox_foto_perfil_usuario_buscado.TabIndex = 6;
            this.pictureBox_foto_perfil_usuario_buscado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_resultados_busquedas_general
            // 
            this.label_resultados_busquedas_general.AutoSize = true;
            this.label_resultados_busquedas_general.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultados_busquedas_general.Location = new System.Drawing.Point(155, 50);
            this.label_resultados_busquedas_general.Name = "label_resultados_busquedas_general";
            this.label_resultados_busquedas_general.Size = new System.Drawing.Size(358, 28);
            this.label_resultados_busquedas_general.TabIndex = 5;
            this.label_resultados_busquedas_general.Text = "Resultados de la busqueda de";
            // 
            // pictureBox_atras_busqueda_general
            // 
            this.pictureBox_atras_busqueda_general.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_atras_busqueda_general.Image")));
            this.pictureBox_atras_busqueda_general.Location = new System.Drawing.Point(43, 37);
            this.pictureBox_atras_busqueda_general.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_atras_busqueda_general.Name = "pictureBox_atras_busqueda_general";
            this.pictureBox_atras_busqueda_general.Size = new System.Drawing.Size(91, 57);
            this.pictureBox_atras_busqueda_general.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_atras_busqueda_general.TabIndex = 4;
            this.pictureBox_atras_busqueda_general.TabStop = false;
            this.pictureBox_atras_busqueda_general.Click += new System.EventHandler(this.pictureBox_atras_busqueda_general_Click);
            // 
            // pictureBox_atras_comentarios_cancion
            // 
            this.pictureBox_atras_comentarios_cancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_atras_comentarios_cancion.Image")));
            this.pictureBox_atras_comentarios_cancion.Location = new System.Drawing.Point(41, 23);
            this.pictureBox_atras_comentarios_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_atras_comentarios_cancion.Name = "pictureBox_atras_comentarios_cancion";
            this.pictureBox_atras_comentarios_cancion.Size = new System.Drawing.Size(91, 57);
            this.pictureBox_atras_comentarios_cancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_atras_comentarios_cancion.TabIndex = 3;
            this.pictureBox_atras_comentarios_cancion.TabStop = false;
            this.pictureBox_atras_comentarios_cancion.Click += new System.EventHandler(this.pictureBox_atras_comentarios_cancion_Click);
            // 
            // button_comentar_cancion
            // 
            this.button_comentar_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_comentar_cancion.Location = new System.Drawing.Point(156, 206);
            this.button_comentar_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_comentar_cancion.Name = "button_comentar_cancion";
            this.button_comentar_cancion.Size = new System.Drawing.Size(466, 32);
            this.button_comentar_cancion.TabIndex = 2;
            this.button_comentar_cancion.Text = "Comentar";
            this.button_comentar_cancion.UseVisualStyleBackColor = true;
            this.button_comentar_cancion.Click += new System.EventHandler(this.button_comentar_cancion_Click);
            // 
            // richTextBox_caja_de_comentarios
            // 
            this.richTextBox_caja_de_comentarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_caja_de_comentarios.Location = new System.Drawing.Point(100, 83);
            this.richTextBox_caja_de_comentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_caja_de_comentarios.Name = "richTextBox_caja_de_comentarios";
            this.richTextBox_caja_de_comentarios.Size = new System.Drawing.Size(570, 100);
            this.richTextBox_caja_de_comentarios.TabIndex = 1;
            this.richTextBox_caja_de_comentarios.Text = "";
            // 
            // label_subtitulo_comentarios_Cancion
            // 
            this.label_subtitulo_comentarios_Cancion.AutoSize = true;
            this.label_subtitulo_comentarios_Cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo_comentarios_Cancion.Location = new System.Drawing.Point(33, 262);
            this.label_subtitulo_comentarios_Cancion.Name = "label_subtitulo_comentarios_Cancion";
            this.label_subtitulo_comentarios_Cancion.Size = new System.Drawing.Size(283, 23);
            this.label_subtitulo_comentarios_Cancion.TabIndex = 0;
            this.label_subtitulo_comentarios_Cancion.Text = "Comentarios de la Cancion: ";
            // 
            // pictureBox_recomendaciones
            // 
            this.pictureBox_recomendaciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_recomendaciones.Image")));
            this.pictureBox_recomendaciones.Location = new System.Drawing.Point(52, 417);
            this.pictureBox_recomendaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_recomendaciones.Name = "pictureBox_recomendaciones";
            this.pictureBox_recomendaciones.Size = new System.Drawing.Size(47, 34);
            this.pictureBox_recomendaciones.TabIndex = 12;
            this.pictureBox_recomendaciones.TabStop = false;
            // 
            // pictureBox_see_ranking
            // 
            this.pictureBox_see_ranking.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_see_ranking.Image")));
            this.pictureBox_see_ranking.Location = new System.Drawing.Point(51, 368);
            this.pictureBox_see_ranking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_see_ranking.Name = "pictureBox_see_ranking";
            this.pictureBox_see_ranking.Size = new System.Drawing.Size(47, 34);
            this.pictureBox_see_ranking.TabIndex = 11;
            this.pictureBox_see_ranking.TabStop = false;
            // 
            // label_recomendaciones
            // 
            this.label_recomendaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_recomendaciones.AutoSize = true;
            this.label_recomendaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recomendaciones.ForeColor = System.Drawing.Color.White;
            this.label_recomendaciones.Location = new System.Drawing.Point(105, 417);
            this.label_recomendaciones.Name = "label_recomendaciones";
            this.label_recomendaciones.Size = new System.Drawing.Size(148, 28);
            this.label_recomendaciones.TabIndex = 10;
            this.label_recomendaciones.Text = "Me gustaria";
            this.label_recomendaciones.Click += new System.EventHandler(this.label_recomendaciones_Click);
            // 
            // label_ranking
            // 
            this.label_ranking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ranking.AutoSize = true;
            this.label_ranking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ranking.ForeColor = System.Drawing.Color.White;
            this.label_ranking.Location = new System.Drawing.Point(105, 368);
            this.label_ranking.Name = "label_ranking";
            this.label_ranking.Size = new System.Drawing.Size(107, 28);
            this.label_ranking.TabIndex = 9;
            this.label_ranking.Text = "Ranking";
            this.label_ranking.Click += new System.EventHandler(this.label_ranking_Click);
            // 
            // label_cerrar_sesion
            // 
            this.label_cerrar_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cerrar_sesion.AutoSize = true;
            this.label_cerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cerrar_sesion.ForeColor = System.Drawing.Color.White;
            this.label_cerrar_sesion.Location = new System.Drawing.Point(75, 620);
            this.label_cerrar_sesion.Name = "label_cerrar_sesion";
            this.label_cerrar_sesion.Size = new System.Drawing.Size(113, 20);
            this.label_cerrar_sesion.TabIndex = 8;
            this.label_cerrar_sesion.Text = "Cerrar Sesion";
            this.label_cerrar_sesion.Click += new System.EventHandler(this.label_cerrar_sesion_Click);
            // 
            // Opciones
            // 
            this.Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Opciones.AutoSize = true;
            this.Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opciones.ForeColor = System.Drawing.Color.White;
            this.Opciones.Location = new System.Drawing.Point(92, 578);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(80, 20);
            this.Opciones.TabIndex = 7;
            this.Opciones.Text = "Opciones";
            this.Opciones.Click += new System.EventHandler(this.label_ajuste_usuario_Click);
            // 
            // pictureBox_Favoritos
            // 
            this.pictureBox_Favoritos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Favoritos.Image")));
            this.pictureBox_Favoritos.Location = new System.Drawing.Point(51, 313);
            this.pictureBox_Favoritos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Favoritos.Name = "pictureBox_Favoritos";
            this.pictureBox_Favoritos.Size = new System.Drawing.Size(47, 34);
            this.pictureBox_Favoritos.TabIndex = 6;
            this.pictureBox_Favoritos.TabStop = false;
            // 
            // pictureBox_playlist
            // 
            this.pictureBox_playlist.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_playlist.Image")));
            this.pictureBox_playlist.Location = new System.Drawing.Point(51, 261);
            this.pictureBox_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_playlist.Name = "pictureBox_playlist";
            this.pictureBox_playlist.Size = new System.Drawing.Size(47, 34);
            this.pictureBox_playlist.TabIndex = 5;
            this.pictureBox_playlist.TabStop = false;
            // 
            // label_Favoritos
            // 
            this.label_Favoritos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Favoritos.AutoSize = true;
            this.label_Favoritos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Favoritos.ForeColor = System.Drawing.Color.White;
            this.label_Favoritos.Location = new System.Drawing.Point(105, 315);
            this.label_Favoritos.Name = "label_Favoritos";
            this.label_Favoritos.Size = new System.Drawing.Size(120, 28);
            this.label_Favoritos.TabIndex = 4;
            this.label_Favoritos.Text = "Favoritos";
            this.label_Favoritos.Click += new System.EventHandler(this.label_Favoritos_Click);
            // 
            // label_Playlist_Usuario
            // 
            this.label_Playlist_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Playlist_Usuario.AutoSize = true;
            this.label_Playlist_Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Playlist_Usuario.ForeColor = System.Drawing.Color.White;
            this.label_Playlist_Usuario.Location = new System.Drawing.Point(105, 261);
            this.label_Playlist_Usuario.Name = "label_Playlist_Usuario";
            this.label_Playlist_Usuario.Size = new System.Drawing.Size(110, 28);
            this.label_Playlist_Usuario.TabIndex = 3;
            this.label_Playlist_Usuario.Text = "Playlists";
            this.label_Playlist_Usuario.Click += new System.EventHandler(this.label_Playlist_Usuario_Click);
            // 
            // panel_galeria
            // 
            this.panel_galeria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_galeria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_galeria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_galeria.BackgroundImage")));
            this.panel_galeria.Controls.Add(this.panel_ajustes);
            this.panel_galeria.Controls.Add(this.panel_buscador);
            this.panel_galeria.Controls.Add(this.panel_secc_video);
            this.panel_galeria.Controls.Add(this.panel_galeria_videos);
            this.panel_galeria.Controls.Add(this.panel_galeria_canciones);
            this.panel_galeria.Controls.Add(this.panel_secc_cancion);
            this.panel_galeria.Location = new System.Drawing.Point(261, 2);
            this.panel_galeria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_galeria.MinimumSize = new System.Drawing.Size(744, 719);
            this.panel_galeria.Name = "panel_galeria";
            this.panel_galeria.Size = new System.Drawing.Size(744, 719);
            this.panel_galeria.TabIndex = 2;
            this.panel_galeria.Visible = false;
            // 
            // panel_ajustes
            // 
            this.panel_ajustes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_ajustes.Controls.Add(this.panel_informacion);
            this.panel_ajustes.Controls.Add(this.label_error_config);
            this.panel_ajustes.Controls.Add(this.label_ver_info);
            this.panel_ajustes.Controls.Add(this.pictureBox_Back1);
            this.panel_ajustes.Controls.Add(this.label_borrar_usuario);
            this.panel_ajustes.Controls.Add(this.button_cambiar_free);
            this.panel_ajustes.Controls.Add(this.button_cmabiar_premium);
            this.panel_ajustes.Controls.Add(this.label_cambiar_plan);
            this.panel_ajustes.Controls.Add(this.button_guardar_cambios);
            this.panel_ajustes.Controls.Add(this.button_cambiarPrivado);
            this.panel_ajustes.Controls.Add(this.button_cambiar_publico);
            this.panel_ajustes.Controls.Add(this.label_cambiar_tipoUsuario);
            this.panel_ajustes.Controls.Add(this.textBox_cambiar_edad);
            this.panel_ajustes.Controls.Add(this.textBox_cambiar_nombre);
            this.panel_ajustes.Controls.Add(this.textBox_cambiar_clave);
            this.panel_ajustes.Controls.Add(this.textBox_cambiarNick);
            this.panel_ajustes.Controls.Add(this.label_cambiar_Edad);
            this.panel_ajustes.Controls.Add(this.label_cambiar_nombre);
            this.panel_ajustes.Controls.Add(this.label_cambiar_password);
            this.panel_ajustes.Controls.Add(this.label_cambiar_nickname);
            this.panel_ajustes.Controls.Add(this.label_cambiar_datos);
            this.panel_ajustes.Controls.Add(this.BorrarVidYCan);
            this.panel_ajustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ajustes.Location = new System.Drawing.Point(0, 0);
            this.panel_ajustes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ajustes.Name = "panel_ajustes";
            this.panel_ajustes.Size = new System.Drawing.Size(744, 719);
            this.panel_ajustes.TabIndex = 3;
            this.panel_ajustes.Visible = false;
            // 
            // panel_informacion
            // 
            this.panel_informacion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_informacion.Controls.Add(this.panel_datos_add_cancion);
            this.panel_informacion.Controls.Add(this.label_info_tipo_usuario);
            this.panel_informacion.Controls.Add(this.label_infoPrivate);
            this.panel_informacion.Controls.Add(this.label_info_Nombre);
            this.panel_informacion.Controls.Add(this.label_infoEdad);
            this.panel_informacion.Controls.Add(this.label_infoSeguidores);
            this.panel_informacion.Controls.Add(this.pictureBox_backtoconfig);
            this.panel_informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_informacion.Location = new System.Drawing.Point(0, 0);
            this.panel_informacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_informacion.Name = "panel_informacion";
            this.panel_informacion.Size = new System.Drawing.Size(744, 719);
            this.panel_informacion.TabIndex = 20;
            this.panel_informacion.Visible = false;
            // 
            // panel_datos_add_cancion
            // 
            this.panel_datos_add_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_datos_add_cancion.Controls.Add(this.panel_De_Agregar_Video);
            this.panel_datos_add_cancion.Controls.Add(this.panel3);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_genero);
            this.panel_datos_add_cancion.Controls.Add(this.pictureBox_back_create_music);
            this.panel_datos_add_cancion.Controls.Add(this.button_add_more_artists);
            this.panel_datos_add_cancion.Controls.Add(this.checkBox_sexo_mujer);
            this.panel_datos_add_cancion.Controls.Add(this.checkBox_sexo_hombre);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_edad_artista);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_artista_sexo);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_edad_artista_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.richTextBox_add_descripcion_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.button_examinar_directorio);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_directorio_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.button_examinar_letra);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_letra_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.pictureBox_add_portada_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.dateTimePicker_add_fecha_publicacion_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_estudio_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_album_artist);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_nombre_artista_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_titulo_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_directorio_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_letra_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label1);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_descripcion_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_fecha_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_estudio_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_album_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_Artistas_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_add_titulo_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.panel_title_add_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.label_error_add_artista);
            this.panel_datos_add_cancion.Controls.Add(this.label_error_add_cancion);
            this.panel_datos_add_cancion.Controls.Add(this.lblEjemploCanciones);
            this.panel_datos_add_cancion.Controls.Add(this.textBox_add_generos_cancion);
            this.panel_datos_add_cancion.Location = new System.Drawing.Point(0, 0);
            this.panel_datos_add_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_datos_add_cancion.Name = "panel_datos_add_cancion";
            this.panel_datos_add_cancion.Size = new System.Drawing.Size(744, 719);
            this.panel_datos_add_cancion.TabIndex = 24;
            this.panel_datos_add_cancion.Visible = false;
            // 
            // panel_De_Agregar_Video
            // 
            this.panel_De_Agregar_Video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_De_Agregar_Video.Controls.Add(this.panel_info_cancion);
            this.panel_De_Agregar_Video.Controls.Add(this.label_error_add_video);
            this.panel_De_Agregar_Video.Controls.Add(this.label_error_add_actor);
            this.panel_De_Agregar_Video.Controls.Add(this.label_error_video_director);
            this.panel_De_Agregar_Video.Controls.Add(this.pictureboxAtras_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.btnExaminar_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.pictureBoxFoto_NuevoVid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxDirecorio_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.richTextBoxDescripcion_Nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxGenero_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblDirectorio_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblPortada_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblDescripcion_Nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblGeneros_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.checkBoxMActores_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.checkBoxHActor_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxEdadActor_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxNombreActor_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblSexoActores_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblNombreActores_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblEdadActores_Nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.button1);
            this.panel_De_Agregar_Video.Controls.Add(this.lblActores_nuevoVid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxEstudio_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.dateTimePickerNuevoVid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblFechaPublicacionNuevoVid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblEstudio_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.btnAñadirOtro_direcvid);
            this.panel_De_Agregar_Video.Controls.Add(this.checkBoxM_direcvid);
            this.panel_De_Agregar_Video.Controls.Add(this.checkbtnHdirec_vid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxEdadDirector_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxnombreDirector_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.textBoxtitulo_nuevovid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblSexo_direc_vid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblEdad_direc_vid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblNombre_direc_vid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblDirector_vid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblTitulo_vid);
            this.panel_De_Agregar_Video.Controls.Add(this.lblEjemploVideo);
            this.panel_De_Agregar_Video.Location = new System.Drawing.Point(0, 40);
            this.panel_De_Agregar_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_De_Agregar_Video.Name = "panel_De_Agregar_Video";
            this.panel_De_Agregar_Video.Size = new System.Drawing.Size(744, 685);
            this.panel_De_Agregar_Video.TabIndex = 35;
            // 
            // panel_info_cancion
            // 
            this.panel_info_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_info_cancion.Controls.Add(this.panel_fijar_add_cancion);
            this.panel_info_cancion.Controls.Add(this.panel_reproductor_cancion);
            this.panel_info_cancion.Controls.Add(this.pictureBox_5star_Canciones);
            this.panel_info_cancion.Controls.Add(this.pictureBox_4star_Canciones);
            this.panel_info_cancion.Controls.Add(this.pictureBox_3star_Canciones);
            this.panel_info_cancion.Controls.Add(this.pictureBox_2star_Canciones);
            this.panel_info_cancion.Controls.Add(this.pictureBox_1star_Canciones);
            this.panel_info_cancion.Controls.Add(this.label_calificacion);
            this.panel_info_cancion.Controls.Add(this.radioButton_add_favorito);
            this.panel_info_cancion.Controls.Add(this.button_add_cola_cancion);
            this.panel_info_cancion.Controls.Add(this.button_add_coment_cancion);
            this.panel_info_cancion.Controls.Add(this.label_cancion_descripcion);
            this.panel_info_cancion.Controls.Add(this.label_visitas_cancion);
            this.panel_info_cancion.Controls.Add(this.label_calificacion_cancion);
            this.panel_info_cancion.Controls.Add(this.pictureBox_calificacion_cancion);
            this.panel_info_cancion.Controls.Add(this.pictureBox_vistas_cancion);
            this.panel_info_cancion.Controls.Add(this.label_info_cancion_estudio);
            this.panel_info_cancion.Controls.Add(this.label_info_cancion_duracion);
            this.panel_info_cancion.Controls.Add(this.label_info_genero_cancion);
            this.panel_info_cancion.Controls.Add(this.label_cancion_info_album);
            this.panel_info_cancion.Controls.Add(this.label_cancion_Artistas);
            this.panel_info_cancion.Controls.Add(this.pictureBox_foto_cancion);
            this.panel_info_cancion.Controls.Add(this.label_info_nombre_cancion);
            this.panel_info_cancion.Location = new System.Drawing.Point(0, 0);
            this.panel_info_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_info_cancion.Name = "panel_info_cancion";
            this.panel_info_cancion.Size = new System.Drawing.Size(744, 685);
            this.panel_info_cancion.TabIndex = 37;
            this.panel_info_cancion.Visible = false;
            // 
            // panel_fijar_add_cancion
            // 
            this.panel_fijar_add_cancion.Controls.Add(this.panel_fijar_reproducir_cancion);
            this.panel_fijar_add_cancion.Controls.Add(this.pictureBox_reproducir_cancion);
            this.panel_fijar_add_cancion.Location = new System.Drawing.Point(603, -2);
            this.panel_fijar_add_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_fijar_add_cancion.Name = "panel_fijar_add_cancion";
            this.panel_fijar_add_cancion.Size = new System.Drawing.Size(144, 687);
            this.panel_fijar_add_cancion.TabIndex = 1;
            this.panel_fijar_add_cancion.Visible = false;
            this.panel_fijar_add_cancion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_fijar_add_cancion_Paint);
            // 
            // panel_fijar_reproducir_cancion
            // 
            this.panel_fijar_reproducir_cancion.Controls.Add(this.panel2);
            this.panel_fijar_reproducir_cancion.Controls.Add(this.pictureBox_download);
            this.panel_fijar_reproducir_cancion.Location = new System.Drawing.Point(0, 126);
            this.panel_fijar_reproducir_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_fijar_reproducir_cancion.Name = "panel_fijar_reproducir_cancion";
            this.panel_fijar_reproducir_cancion.Size = new System.Drawing.Size(144, 551);
            this.panel_fijar_reproducir_cancion.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_size_cancion);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 455);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // label_size_cancion
            // 
            this.label_size_cancion.AutoSize = true;
            this.label_size_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_size_cancion.Location = new System.Drawing.Point(60, 15);
            this.label_size_cancion.Name = "label_size_cancion";
            this.label_size_cancion.Size = new System.Drawing.Size(85, 24);
            this.label_size_cancion.TabIndex = 0;
            this.label_size_cancion.Text = "Tamaño:";
            this.label_size_cancion.Visible = false;
            // 
            // pictureBox_download
            // 
            this.pictureBox_download.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_download.Image")));
            this.pictureBox_download.Location = new System.Drawing.Point(59, 0);
            this.pictureBox_download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_download.Name = "pictureBox_download";
            this.pictureBox_download.Size = new System.Drawing.Size(99, 95);
            this.pictureBox_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_download.TabIndex = 0;
            this.pictureBox_download.TabStop = false;
            this.pictureBox_download.Visible = false;
            this.pictureBox_download.Click += new System.EventHandler(this.pictureBox_download_Click);
            // 
            // pictureBox_reproducir_cancion
            // 
            this.pictureBox_reproducir_cancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_reproducir_cancion.Image")));
            this.pictureBox_reproducir_cancion.Location = new System.Drawing.Point(59, 0);
            this.pictureBox_reproducir_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_reproducir_cancion.Name = "pictureBox_reproducir_cancion";
            this.pictureBox_reproducir_cancion.Size = new System.Drawing.Size(99, 90);
            this.pictureBox_reproducir_cancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reproducir_cancion.TabIndex = 0;
            this.pictureBox_reproducir_cancion.TabStop = false;
            this.pictureBox_reproducir_cancion.Visible = false;
            this.pictureBox_reproducir_cancion.Click += new System.EventHandler(this.pictureBox_reproducir_cancion_Click);
            // 
            // panel_reproductor_cancion
            // 
            this.panel_reproductor_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_reproductor_cancion.Controls.Add(this.pictureBox_salir);
            this.panel_reproductor_cancion.Controls.Add(this.ReproductorCancion);
            this.panel_reproductor_cancion.Location = new System.Drawing.Point(35, 52);
            this.panel_reproductor_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_reproductor_cancion.Name = "panel_reproductor_cancion";
            this.panel_reproductor_cancion.Size = new System.Drawing.Size(569, 382);
            this.panel_reproductor_cancion.TabIndex = 55;
            this.panel_reproductor_cancion.Visible = false;
            // 
            // pictureBox_salir
            // 
            this.pictureBox_salir.BackColor = System.Drawing.Color.Black;
            this.pictureBox_salir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_salir.Image")));
            this.pictureBox_salir.Location = new System.Drawing.Point(525, 2);
            this.pictureBox_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_salir.Name = "pictureBox_salir";
            this.pictureBox_salir.Size = new System.Drawing.Size(31, 30);
            this.pictureBox_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_salir.TabIndex = 57;
            this.pictureBox_salir.TabStop = false;
            this.pictureBox_salir.Click += new System.EventHandler(this.pictureBox_salir_Click);
            // 
            // ReproductorCancion
            // 
            this.ReproductorCancion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReproductorCancion.Enabled = true;
            this.ReproductorCancion.Location = new System.Drawing.Point(0, 0);
            this.ReproductorCancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReproductorCancion.Name = "ReproductorCancion";
            this.ReproductorCancion.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorCancion.OcxState")));
            this.ReproductorCancion.Size = new System.Drawing.Size(569, 382);
            this.ReproductorCancion.TabIndex = 0;
            // 
            // pictureBox_5star_Canciones
            // 
            this.pictureBox_5star_Canciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_5star_Canciones.Image")));
            this.pictureBox_5star_Canciones.Location = new System.Drawing.Point(471, 528);
            this.pictureBox_5star_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_5star_Canciones.Name = "pictureBox_5star_Canciones";
            this.pictureBox_5star_Canciones.Size = new System.Drawing.Size(60, 57);
            this.pictureBox_5star_Canciones.TabIndex = 54;
            this.pictureBox_5star_Canciones.TabStop = false;
            this.pictureBox_5star_Canciones.Click += new System.EventHandler(this.pictureBox_5star_Canciones_Click);
            // 
            // pictureBox_4star_Canciones
            // 
            this.pictureBox_4star_Canciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_4star_Canciones.Image")));
            this.pictureBox_4star_Canciones.Location = new System.Drawing.Point(385, 528);
            this.pictureBox_4star_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_4star_Canciones.Name = "pictureBox_4star_Canciones";
            this.pictureBox_4star_Canciones.Size = new System.Drawing.Size(60, 57);
            this.pictureBox_4star_Canciones.TabIndex = 53;
            this.pictureBox_4star_Canciones.TabStop = false;
            this.pictureBox_4star_Canciones.Click += new System.EventHandler(this.pictureBox_4star_Canciones_Click);
            // 
            // pictureBox_3star_Canciones
            // 
            this.pictureBox_3star_Canciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_3star_Canciones.Image")));
            this.pictureBox_3star_Canciones.Location = new System.Drawing.Point(295, 527);
            this.pictureBox_3star_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_3star_Canciones.Name = "pictureBox_3star_Canciones";
            this.pictureBox_3star_Canciones.Size = new System.Drawing.Size(60, 57);
            this.pictureBox_3star_Canciones.TabIndex = 52;
            this.pictureBox_3star_Canciones.TabStop = false;
            this.pictureBox_3star_Canciones.Click += new System.EventHandler(this.pictureBox_3star_Canciones_Click);
            // 
            // pictureBox_2star_Canciones
            // 
            this.pictureBox_2star_Canciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_2star_Canciones.Image")));
            this.pictureBox_2star_Canciones.Location = new System.Drawing.Point(205, 528);
            this.pictureBox_2star_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_2star_Canciones.Name = "pictureBox_2star_Canciones";
            this.pictureBox_2star_Canciones.Size = new System.Drawing.Size(60, 57);
            this.pictureBox_2star_Canciones.TabIndex = 51;
            this.pictureBox_2star_Canciones.TabStop = false;
            this.pictureBox_2star_Canciones.Click += new System.EventHandler(this.pictureBox_2star_Canciones_Click);
            // 
            // pictureBox_1star_Canciones
            // 
            this.pictureBox_1star_Canciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_1star_Canciones.Image")));
            this.pictureBox_1star_Canciones.Location = new System.Drawing.Point(109, 527);
            this.pictureBox_1star_Canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_1star_Canciones.Name = "pictureBox_1star_Canciones";
            this.pictureBox_1star_Canciones.Size = new System.Drawing.Size(60, 57);
            this.pictureBox_1star_Canciones.TabIndex = 50;
            this.pictureBox_1star_Canciones.TabStop = false;
            this.pictureBox_1star_Canciones.Click += new System.EventHandler(this.pictureBox_1star_Canciones_Click);
            // 
            // label_calificacion
            // 
            this.label_calificacion.AutoSize = true;
            this.label_calificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calificacion.Location = new System.Drawing.Point(253, 594);
            this.label_calificacion.Name = "label_calificacion";
            this.label_calificacion.Size = new System.Drawing.Size(124, 23);
            this.label_calificacion.TabIndex = 49;
            this.label_calificacion.Text = "Calificacion";
            // 
            // radioButton_add_favorito
            // 
            this.radioButton_add_favorito.AutoSize = true;
            this.radioButton_add_favorito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_add_favorito.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioButton_add_favorito.Location = new System.Drawing.Point(245, 490);
            this.radioButton_add_favorito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_add_favorito.Name = "radioButton_add_favorito";
            this.radioButton_add_favorito.Size = new System.Drawing.Size(141, 32);
            this.radioButton_add_favorito.TabIndex = 48;
            this.radioButton_add_favorito.TabStop = true;
            this.radioButton_add_favorito.Text = "Favoritos";
            this.radioButton_add_favorito.UseVisualStyleBackColor = true;
            this.radioButton_add_favorito.CheckedChanged += new System.EventHandler(this.radioButton_add_favorito_CheckedChanged);
            // 
            // button_add_cola_cancion
            // 
            this.button_add_cola_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_cola_cancion.Location = new System.Drawing.Point(319, 439);
            this.button_add_cola_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_cola_cancion.Name = "button_add_cola_cancion";
            this.button_add_cola_cancion.Size = new System.Drawing.Size(237, 44);
            this.button_add_cola_cancion.TabIndex = 47;
            this.button_add_cola_cancion.Text = "Añadir a la Cola";
            this.button_add_cola_cancion.UseVisualStyleBackColor = true;
            this.button_add_cola_cancion.Click += new System.EventHandler(this.button_add_cola_cancion_Click);
            // 
            // button_add_coment_cancion
            // 
            this.button_add_coment_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_coment_cancion.Location = new System.Drawing.Point(59, 439);
            this.button_add_coment_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_coment_cancion.Name = "button_add_coment_cancion";
            this.button_add_coment_cancion.Size = new System.Drawing.Size(237, 44);
            this.button_add_coment_cancion.TabIndex = 46;
            this.button_add_coment_cancion.Text = "Comentarios";
            this.button_add_coment_cancion.UseVisualStyleBackColor = true;
            this.button_add_coment_cancion.Click += new System.EventHandler(this.button_add_coment_cancion_Click);
            // 
            // label_cancion_descripcion
            // 
            this.label_cancion_descripcion.AutoSize = true;
            this.label_cancion_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancion_descripcion.Location = new System.Drawing.Point(43, 345);
            this.label_cancion_descripcion.Name = "label_cancion_descripcion";
            this.label_cancion_descripcion.Size = new System.Drawing.Size(109, 20);
            this.label_cancion_descripcion.TabIndex = 45;
            this.label_cancion_descripcion.Text = "Descripcion: ";
            // 
            // label_visitas_cancion
            // 
            this.label_visitas_cancion.AutoSize = true;
            this.label_visitas_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_visitas_cancion.Location = new System.Drawing.Point(447, 306);
            this.label_visitas_cancion.Name = "label_visitas_cancion";
            this.label_visitas_cancion.Size = new System.Drawing.Size(70, 20);
            this.label_visitas_cancion.TabIndex = 44;
            this.label_visitas_cancion.Text = "Visitas: ";
            // 
            // label_calificacion_cancion
            // 
            this.label_calificacion_cancion.AutoSize = true;
            this.label_calificacion_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calificacion_cancion.Location = new System.Drawing.Point(240, 309);
            this.label_calificacion_cancion.Name = "label_calificacion_cancion";
            this.label_calificacion_cancion.Size = new System.Drawing.Size(49, 20);
            this.label_calificacion_cancion.TabIndex = 43;
            this.label_calificacion_cancion.Text = "Nota:";
            // 
            // pictureBox_calificacion_cancion
            // 
            this.pictureBox_calificacion_cancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_calificacion_cancion.Image")));
            this.pictureBox_calificacion_cancion.Location = new System.Drawing.Point(173, 294);
            this.pictureBox_calificacion_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_calificacion_cancion.Name = "pictureBox_calificacion_cancion";
            this.pictureBox_calificacion_cancion.Size = new System.Drawing.Size(49, 39);
            this.pictureBox_calificacion_cancion.TabIndex = 42;
            this.pictureBox_calificacion_cancion.TabStop = false;
            // 
            // pictureBox_vistas_cancion
            // 
            this.pictureBox_vistas_cancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_vistas_cancion.Image")));
            this.pictureBox_vistas_cancion.Location = new System.Drawing.Point(387, 290);
            this.pictureBox_vistas_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_vistas_cancion.Name = "pictureBox_vistas_cancion";
            this.pictureBox_vistas_cancion.Size = new System.Drawing.Size(49, 39);
            this.pictureBox_vistas_cancion.TabIndex = 41;
            this.pictureBox_vistas_cancion.TabStop = false;
            // 
            // label_info_cancion_estudio
            // 
            this.label_info_cancion_estudio.AutoSize = true;
            this.label_info_cancion_estudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_cancion_estudio.Location = new System.Drawing.Point(304, 226);
            this.label_info_cancion_estudio.Name = "label_info_cancion_estudio";
            this.label_info_cancion_estudio.Size = new System.Drawing.Size(70, 20);
            this.label_info_cancion_estudio.TabIndex = 40;
            this.label_info_cancion_estudio.Text = "Estudio:";
            // 
            // label_info_cancion_duracion
            // 
            this.label_info_cancion_duracion.AutoSize = true;
            this.label_info_cancion_duracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_cancion_duracion.Location = new System.Drawing.Point(304, 255);
            this.label_info_cancion_duracion.Name = "label_info_cancion_duracion";
            this.label_info_cancion_duracion.Size = new System.Drawing.Size(82, 20);
            this.label_info_cancion_duracion.TabIndex = 39;
            this.label_info_cancion_duracion.Text = "Duracion:";
            // 
            // label_info_genero_cancion
            // 
            this.label_info_genero_cancion.AutoSize = true;
            this.label_info_genero_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_genero_cancion.Location = new System.Drawing.Point(304, 199);
            this.label_info_genero_cancion.Name = "label_info_genero_cancion";
            this.label_info_genero_cancion.Size = new System.Drawing.Size(69, 20);
            this.label_info_genero_cancion.TabIndex = 38;
            this.label_info_genero_cancion.Text = "Genero:";
            // 
            // label_cancion_info_album
            // 
            this.label_cancion_info_album.AutoSize = true;
            this.label_cancion_info_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancion_info_album.Location = new System.Drawing.Point(304, 174);
            this.label_cancion_info_album.Name = "label_cancion_info_album";
            this.label_cancion_info_album.Size = new System.Drawing.Size(61, 20);
            this.label_cancion_info_album.TabIndex = 37;
            this.label_cancion_info_album.Text = "Album:";
            // 
            // label_cancion_Artistas
            // 
            this.label_cancion_Artistas.AutoSize = true;
            this.label_cancion_Artistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancion_Artistas.Location = new System.Drawing.Point(299, 71);
            this.label_cancion_Artistas.Name = "label_cancion_Artistas";
            this.label_cancion_Artistas.Size = new System.Drawing.Size(72, 20);
            this.label_cancion_Artistas.TabIndex = 36;
            this.label_cancion_Artistas.Text = "Artistas:";
            // 
            // pictureBox_foto_cancion
            // 
            this.pictureBox_foto_cancion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_foto_cancion.Location = new System.Drawing.Point(39, 66);
            this.pictureBox_foto_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_foto_cancion.Name = "pictureBox_foto_cancion";
            this.pictureBox_foto_cancion.Size = new System.Drawing.Size(219, 197);
            this.pictureBox_foto_cancion.TabIndex = 35;
            this.pictureBox_foto_cancion.TabStop = false;
            // 
            // label_info_nombre_cancion
            // 
            this.label_info_nombre_cancion.AutoSize = true;
            this.label_info_nombre_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label_info_nombre_cancion.Location = new System.Drawing.Point(35, 16);
            this.label_info_nombre_cancion.Name = "label_info_nombre_cancion";
            this.label_info_nombre_cancion.Size = new System.Drawing.Size(218, 29);
            this.label_info_nombre_cancion.TabIndex = 34;
            this.label_info_nombre_cancion.Text = "Nombre Cancion";
            // 
            // label_error_add_video
            // 
            this.label_error_add_video.AutoSize = true;
            this.label_error_add_video.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_add_video.ForeColor = System.Drawing.Color.DarkRed;
            this.label_error_add_video.Location = new System.Drawing.Point(341, 15);
            this.label_error_add_video.Name = "label_error_add_video";
            this.label_error_add_video.Size = new System.Drawing.Size(244, 17);
            this.label_error_add_video.TabIndex = 36;
            this.label_error_add_video.Text = "Algun archivo indicado no existe";
            this.label_error_add_video.Visible = false;
            // 
            // label_error_add_actor
            // 
            this.label_error_add_actor.AutoSize = true;
            this.label_error_add_actor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_add_actor.ForeColor = System.Drawing.Color.DarkRed;
            this.label_error_add_actor.Location = new System.Drawing.Point(384, 284);
            this.label_error_add_actor.Name = "label_error_add_actor";
            this.label_error_add_actor.Size = new System.Drawing.Size(201, 17);
            this.label_error_add_actor.TabIndex = 35;
            this.label_error_add_actor.Text = "Hay un dato mal ingresado";
            this.label_error_add_actor.Visible = false;
            // 
            // label_error_video_director
            // 
            this.label_error_video_director.AutoSize = true;
            this.label_error_video_director.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_video_director.ForeColor = System.Drawing.Color.DarkRed;
            this.label_error_video_director.Location = new System.Drawing.Point(384, 185);
            this.label_error_video_director.Name = "label_error_video_director";
            this.label_error_video_director.Size = new System.Drawing.Size(201, 17);
            this.label_error_video_director.TabIndex = 34;
            this.label_error_video_director.Text = "Hay un dato mal ingresado";
            this.label_error_video_director.Visible = false;
            // 
            // pictureboxAtras_nuevovid
            // 
            this.pictureboxAtras_nuevovid.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxAtras_nuevovid.Image = global::Spotflex.Properties.Resources._25618;
            this.pictureboxAtras_nuevovid.Location = new System.Drawing.Point(27, 2);
            this.pictureboxAtras_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureboxAtras_nuevovid.Name = "pictureboxAtras_nuevovid";
            this.pictureboxAtras_nuevovid.Size = new System.Drawing.Size(88, 39);
            this.pictureboxAtras_nuevovid.TabIndex = 33;
            this.pictureboxAtras_nuevovid.TabStop = false;
            this.pictureboxAtras_nuevovid.Click += new System.EventHandler(this.pictureboxAtras_nuevovid_Click);
            // 
            // btnExaminar_nuevovid
            // 
            this.btnExaminar_nuevovid.Location = new System.Drawing.Point(471, 586);
            this.btnExaminar_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExaminar_nuevovid.Name = "btnExaminar_nuevovid";
            this.btnExaminar_nuevovid.Size = new System.Drawing.Size(120, 28);
            this.btnExaminar_nuevovid.TabIndex = 32;
            this.btnExaminar_nuevovid.Text = "Examinar";
            this.btnExaminar_nuevovid.UseVisualStyleBackColor = true;
            this.btnExaminar_nuevovid.Click += new System.EventHandler(this.btnExaminar_nuevovid_Click);
            // 
            // pictureBoxFoto_NuevoVid
            // 
            this.pictureBoxFoto_NuevoVid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxFoto_NuevoVid.Location = new System.Drawing.Point(245, 489);
            this.pictureBoxFoto_NuevoVid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFoto_NuevoVid.Name = "pictureBoxFoto_NuevoVid";
            this.pictureBoxFoto_NuevoVid.Size = new System.Drawing.Size(107, 94);
            this.pictureBoxFoto_NuevoVid.TabIndex = 31;
            this.pictureBoxFoto_NuevoVid.TabStop = false;
            this.pictureBoxFoto_NuevoVid.Click += new System.EventHandler(this.pictureBox_NuevoVid_Click);
            // 
            // textBoxDirecorio_nuevovid
            // 
            this.textBoxDirecorio_nuevovid.Location = new System.Drawing.Point(244, 588);
            this.textBoxDirecorio_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDirecorio_nuevovid.Name = "textBoxDirecorio_nuevovid";
            this.textBoxDirecorio_nuevovid.ReadOnly = true;
            this.textBoxDirecorio_nuevovid.Size = new System.Drawing.Size(221, 22);
            this.textBoxDirecorio_nuevovid.TabIndex = 30;
            // 
            // richTextBoxDescripcion_Nuevovid
            // 
            this.richTextBoxDescripcion_Nuevovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescripcion_Nuevovid.Location = new System.Drawing.Point(244, 435);
            this.richTextBoxDescripcion_Nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescripcion_Nuevovid.Name = "richTextBoxDescripcion_Nuevovid";
            this.richTextBoxDescripcion_Nuevovid.Size = new System.Drawing.Size(416, 46);
            this.richTextBoxDescripcion_Nuevovid.TabIndex = 29;
            this.richTextBoxDescripcion_Nuevovid.Text = "";
            // 
            // textBoxGenero_nuevovid
            // 
            this.textBoxGenero_nuevovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGenero_nuevovid.Location = new System.Drawing.Point(246, 391);
            this.textBoxGenero_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGenero_nuevovid.Name = "textBoxGenero_nuevovid";
            this.textBoxGenero_nuevovid.Size = new System.Drawing.Size(463, 22);
            this.textBoxGenero_nuevovid.TabIndex = 28;
            // 
            // lblDirectorio_nuevovid
            // 
            this.lblDirectorio_nuevovid.AutoSize = true;
            this.lblDirectorio_nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorio_nuevovid.Location = new System.Drawing.Point(53, 586);
            this.lblDirectorio_nuevovid.Name = "lblDirectorio_nuevovid";
            this.lblDirectorio_nuevovid.Size = new System.Drawing.Size(92, 20);
            this.lblDirectorio_nuevovid.TabIndex = 27;
            this.lblDirectorio_nuevovid.Text = "Directorio";
            // 
            // lblPortada_nuevovid
            // 
            this.lblPortada_nuevovid.AutoSize = true;
            this.lblPortada_nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortada_nuevovid.Location = new System.Drawing.Point(56, 489);
            this.lblPortada_nuevovid.Name = "lblPortada_nuevovid";
            this.lblPortada_nuevovid.Size = new System.Drawing.Size(74, 20);
            this.lblPortada_nuevovid.TabIndex = 26;
            this.lblPortada_nuevovid.Text = "Portada";
            // 
            // lblDescripcion_Nuevovid
            // 
            this.lblDescripcion_Nuevovid.AutoSize = true;
            this.lblDescripcion_Nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion_Nuevovid.Location = new System.Drawing.Point(56, 434);
            this.lblDescripcion_Nuevovid.Name = "lblDescripcion_Nuevovid";
            this.lblDescripcion_Nuevovid.Size = new System.Drawing.Size(109, 20);
            this.lblDescripcion_Nuevovid.TabIndex = 25;
            this.lblDescripcion_Nuevovid.Text = "Descripcion";
            // 
            // lblGeneros_nuevovid
            // 
            this.lblGeneros_nuevovid.AutoSize = true;
            this.lblGeneros_nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneros_nuevovid.Location = new System.Drawing.Point(56, 391);
            this.lblGeneros_nuevovid.Name = "lblGeneros_nuevovid";
            this.lblGeneros_nuevovid.Size = new System.Drawing.Size(78, 20);
            this.lblGeneros_nuevovid.TabIndex = 24;
            this.lblGeneros_nuevovid.Text = "Generos";
            // 
            // checkBoxMActores_nuevovid
            // 
            this.checkBoxMActores_nuevovid.AutoSize = true;
            this.checkBoxMActores_nuevovid.Location = new System.Drawing.Point(471, 247);
            this.checkBoxMActores_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMActores_nuevovid.Name = "checkBoxMActores_nuevovid";
            this.checkBoxMActores_nuevovid.Size = new System.Drawing.Size(41, 21);
            this.checkBoxMActores_nuevovid.TabIndex = 23;
            this.checkBoxMActores_nuevovid.Text = "M";
            this.checkBoxMActores_nuevovid.UseVisualStyleBackColor = true;
            this.checkBoxMActores_nuevovid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxMActores_nuevovid_MouseClick);
            // 
            // checkBoxHActor_nuevovid
            // 
            this.checkBoxHActor_nuevovid.AutoSize = true;
            this.checkBoxHActor_nuevovid.Location = new System.Drawing.Point(425, 247);
            this.checkBoxHActor_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHActor_nuevovid.Name = "checkBoxHActor_nuevovid";
            this.checkBoxHActor_nuevovid.Size = new System.Drawing.Size(40, 21);
            this.checkBoxHActor_nuevovid.TabIndex = 22;
            this.checkBoxHActor_nuevovid.Text = "H";
            this.checkBoxHActor_nuevovid.UseVisualStyleBackColor = true;
            this.checkBoxHActor_nuevovid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxHActor_nuevovid_MouseClick);
            // 
            // textBoxEdadActor_nuevovid
            // 
            this.textBoxEdadActor_nuevovid.Location = new System.Drawing.Point(248, 247);
            this.textBoxEdadActor_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEdadActor_nuevovid.Name = "textBoxEdadActor_nuevovid";
            this.textBoxEdadActor_nuevovid.Size = new System.Drawing.Size(99, 22);
            this.textBoxEdadActor_nuevovid.TabIndex = 21;
            // 
            // textBoxNombreActor_nuevovid
            // 
            this.textBoxNombreActor_nuevovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreActor_nuevovid.Location = new System.Drawing.Point(244, 212);
            this.textBoxNombreActor_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombreActor_nuevovid.Name = "textBoxNombreActor_nuevovid";
            this.textBoxNombreActor_nuevovid.Size = new System.Drawing.Size(465, 22);
            this.textBoxNombreActor_nuevovid.TabIndex = 20;
            // 
            // lblSexoActores_nuevovid
            // 
            this.lblSexoActores_nuevovid.AutoSize = true;
            this.lblSexoActores_nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoActores_nuevovid.Location = new System.Drawing.Point(351, 247);
            this.lblSexoActores_nuevovid.Name = "lblSexoActores_nuevovid";
            this.lblSexoActores_nuevovid.Size = new System.Drawing.Size(70, 20);
            this.lblSexoActores_nuevovid.TabIndex = 19;
            this.lblSexoActores_nuevovid.Text = "III)Sexo";
            // 
            // lblNombreActores_nuevovid
            // 
            this.lblNombreActores_nuevovid.AutoSize = true;
            this.lblNombreActores_nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreActores_nuevovid.Location = new System.Drawing.Point(145, 217);
            this.lblNombreActores_nuevovid.Name = "lblNombreActores_nuevovid";
            this.lblNombreActores_nuevovid.Size = new System.Drawing.Size(86, 20);
            this.lblNombreActores_nuevovid.TabIndex = 18;
            this.lblNombreActores_nuevovid.Text = "I)Nombre";
            // 
            // lblEdadActores_Nuevovid
            // 
            this.lblEdadActores_Nuevovid.AutoSize = true;
            this.lblEdadActores_Nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadActores_Nuevovid.Location = new System.Drawing.Point(145, 247);
            this.lblEdadActores_Nuevovid.Name = "lblEdadActores_Nuevovid";
            this.lblEdadActores_Nuevovid.Size = new System.Drawing.Size(68, 20);
            this.lblEdadActores_Nuevovid.TabIndex = 17;
            this.lblEdadActores_Nuevovid.Text = "II)Edad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Añadir otro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblActores_nuevoVid
            // 
            this.lblActores_nuevoVid.AutoSize = true;
            this.lblActores_nuevoVid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActores_nuevoVid.Location = new System.Drawing.Point(56, 210);
            this.lblActores_nuevoVid.Name = "lblActores_nuevoVid";
            this.lblActores_nuevoVid.Size = new System.Drawing.Size(73, 20);
            this.lblActores_nuevoVid.TabIndex = 15;
            this.lblActores_nuevoVid.Text = "Actores";
            // 
            // textBoxEstudio_nuevovid
            // 
            this.textBoxEstudio_nuevovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEstudio_nuevovid.Location = new System.Drawing.Point(245, 310);
            this.textBoxEstudio_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEstudio_nuevovid.Name = "textBoxEstudio_nuevovid";
            this.textBoxEstudio_nuevovid.Size = new System.Drawing.Size(464, 22);
            this.textBoxEstudio_nuevovid.TabIndex = 14;
            // 
            // dateTimePickerNuevoVid
            // 
            this.dateTimePickerNuevoVid.Location = new System.Drawing.Point(245, 345);
            this.dateTimePickerNuevoVid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNuevoVid.Name = "dateTimePickerNuevoVid";
            this.dateTimePickerNuevoVid.Size = new System.Drawing.Size(267, 22);
            this.dateTimePickerNuevoVid.TabIndex = 13;
            // 
            // lblFechaPublicacionNuevoVid
            // 
            this.lblFechaPublicacionNuevoVid.AutoSize = true;
            this.lblFechaPublicacionNuevoVid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPublicacionNuevoVid.Location = new System.Drawing.Point(53, 351);
            this.lblFechaPublicacionNuevoVid.Name = "lblFechaPublicacionNuevoVid";
            this.lblFechaPublicacionNuevoVid.Size = new System.Drawing.Size(185, 20);
            this.lblFechaPublicacionNuevoVid.TabIndex = 12;
            this.lblFechaPublicacionNuevoVid.Text = "Fecha de Publicacion";
            // 
            // lblEstudio_nuevovid
            // 
            this.lblEstudio_nuevovid.AutoSize = true;
            this.lblEstudio_nuevovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudio_nuevovid.Location = new System.Drawing.Point(53, 320);
            this.lblEstudio_nuevovid.Name = "lblEstudio_nuevovid";
            this.lblEstudio_nuevovid.Size = new System.Drawing.Size(71, 20);
            this.lblEstudio_nuevovid.TabIndex = 11;
            this.lblEstudio_nuevovid.Text = "Estudio";
            // 
            // btnAñadirOtro_direcvid
            // 
            this.btnAñadirOtro_direcvid.Location = new System.Drawing.Point(245, 178);
            this.btnAñadirOtro_direcvid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirOtro_direcvid.Name = "btnAñadirOtro_direcvid";
            this.btnAñadirOtro_direcvid.Size = new System.Drawing.Size(137, 28);
            this.btnAñadirOtro_direcvid.TabIndex = 10;
            this.btnAñadirOtro_direcvid.Text = "Añadir otro";
            this.btnAñadirOtro_direcvid.UseVisualStyleBackColor = true;
            this.btnAñadirOtro_direcvid.Click += new System.EventHandler(this.btnAñadirOtro_direcvid_Click);
            // 
            // checkBoxM_direcvid
            // 
            this.checkBoxM_direcvid.AutoSize = true;
            this.checkBoxM_direcvid.Location = new System.Drawing.Point(471, 146);
            this.checkBoxM_direcvid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxM_direcvid.Name = "checkBoxM_direcvid";
            this.checkBoxM_direcvid.Size = new System.Drawing.Size(41, 21);
            this.checkBoxM_direcvid.TabIndex = 9;
            this.checkBoxM_direcvid.Text = "M";
            this.checkBoxM_direcvid.UseVisualStyleBackColor = true;
            this.checkBoxM_direcvid.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBoxM_direcvid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxM_direcvid_MouseClick);
            // 
            // checkbtnHdirec_vid
            // 
            this.checkbtnHdirec_vid.AutoSize = true;
            this.checkbtnHdirec_vid.Location = new System.Drawing.Point(425, 146);
            this.checkbtnHdirec_vid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbtnHdirec_vid.Name = "checkbtnHdirec_vid";
            this.checkbtnHdirec_vid.Size = new System.Drawing.Size(40, 21);
            this.checkbtnHdirec_vid.TabIndex = 8;
            this.checkbtnHdirec_vid.Text = "H";
            this.checkbtnHdirec_vid.UseVisualStyleBackColor = true;
            this.checkbtnHdirec_vid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkbtnHdirec_vid_MouseClick);
            // 
            // textBoxEdadDirector_nuevovid
            // 
            this.textBoxEdadDirector_nuevovid.Location = new System.Drawing.Point(245, 143);
            this.textBoxEdadDirector_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEdadDirector_nuevovid.Name = "textBoxEdadDirector_nuevovid";
            this.textBoxEdadDirector_nuevovid.Size = new System.Drawing.Size(99, 22);
            this.textBoxEdadDirector_nuevovid.TabIndex = 7;
            // 
            // textBoxnombreDirector_nuevovid
            // 
            this.textBoxnombreDirector_nuevovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxnombreDirector_nuevovid.Location = new System.Drawing.Point(244, 108);
            this.textBoxnombreDirector_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombreDirector_nuevovid.Name = "textBoxnombreDirector_nuevovid";
            this.textBoxnombreDirector_nuevovid.Size = new System.Drawing.Size(393, 22);
            this.textBoxnombreDirector_nuevovid.TabIndex = 6;
            // 
            // textBoxtitulo_nuevovid
            // 
            this.textBoxtitulo_nuevovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtitulo_nuevovid.Location = new System.Drawing.Point(246, 68);
            this.textBoxtitulo_nuevovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtitulo_nuevovid.Name = "textBoxtitulo_nuevovid";
            this.textBoxtitulo_nuevovid.Size = new System.Drawing.Size(414, 22);
            this.textBoxtitulo_nuevovid.TabIndex = 5;
            // 
            // lblSexo_direc_vid
            // 
            this.lblSexo_direc_vid.AutoSize = true;
            this.lblSexo_direc_vid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo_direc_vid.Location = new System.Drawing.Point(351, 145);
            this.lblSexo_direc_vid.Name = "lblSexo_direc_vid";
            this.lblSexo_direc_vid.Size = new System.Drawing.Size(70, 20);
            this.lblSexo_direc_vid.TabIndex = 4;
            this.lblSexo_direc_vid.Text = "III)Sexo";
            // 
            // lblEdad_direc_vid
            // 
            this.lblEdad_direc_vid.AutoSize = true;
            this.lblEdad_direc_vid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad_direc_vid.Location = new System.Drawing.Point(145, 145);
            this.lblEdad_direc_vid.Name = "lblEdad_direc_vid";
            this.lblEdad_direc_vid.Size = new System.Drawing.Size(68, 20);
            this.lblEdad_direc_vid.TabIndex = 3;
            this.lblEdad_direc_vid.Text = "II)Edad";
            // 
            // lblNombre_direc_vid
            // 
            this.lblNombre_direc_vid.AutoSize = true;
            this.lblNombre_direc_vid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_direc_vid.Location = new System.Drawing.Point(145, 110);
            this.lblNombre_direc_vid.Name = "lblNombre_direc_vid";
            this.lblNombre_direc_vid.Size = new System.Drawing.Size(86, 20);
            this.lblNombre_direc_vid.TabIndex = 2;
            this.lblNombre_direc_vid.Text = "I)Nombre";
            // 
            // lblDirector_vid
            // 
            this.lblDirector_vid.AutoSize = true;
            this.lblDirector_vid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector_vid.Location = new System.Drawing.Point(53, 110);
            this.lblDirector_vid.Name = "lblDirector_vid";
            this.lblDirector_vid.Size = new System.Drawing.Size(77, 20);
            this.lblDirector_vid.TabIndex = 1;
            this.lblDirector_vid.Text = "Director";
            // 
            // lblTitulo_vid
            // 
            this.lblTitulo_vid.AutoSize = true;
            this.lblTitulo_vid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_vid.Location = new System.Drawing.Point(53, 47);
            this.lblTitulo_vid.Name = "lblTitulo_vid";
            this.lblTitulo_vid.Size = new System.Drawing.Size(56, 20);
            this.lblTitulo_vid.TabIndex = 0;
            this.lblTitulo_vid.Text = "Titulo";
            // 
            // lblEjemploVideo
            // 
            this.lblEjemploVideo.AutoSize = true;
            this.lblEjemploVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemploVideo.Location = new System.Drawing.Point(139, 394);
            this.lblEjemploVideo.Name = "lblEjemploVideo";
            this.lblEjemploVideo.Size = new System.Drawing.Size(99, 16);
            this.lblEjemploVideo.TabIndex = 38;
            this.lblEjemploVideo.Text = "(pop,rick,etc)";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::Spotflex.Properties.Resources.sky;
            this.panel3.Controls.Add(this.Volver_de_Borrar_VidYCan);
            this.panel3.Controls.Add(this.panel_label_borrar_video);
            this.panel3.Controls.Add(this.panel_label_borrar_Cancion);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(547, 417);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 274);
            this.panel3.TabIndex = 57;
            this.panel3.Visible = false;
            // 
            // Volver_de_Borrar_VidYCan
            // 
            this.Volver_de_Borrar_VidYCan.Image = ((System.Drawing.Image)(resources.GetObject("Volver_de_Borrar_VidYCan.Image")));
            this.Volver_de_Borrar_VidYCan.Location = new System.Drawing.Point(11, 630);
            this.Volver_de_Borrar_VidYCan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Volver_de_Borrar_VidYCan.Name = "Volver_de_Borrar_VidYCan";
            this.Volver_de_Borrar_VidYCan.Size = new System.Drawing.Size(87, 53);
            this.Volver_de_Borrar_VidYCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Volver_de_Borrar_VidYCan.TabIndex = 4;
            this.Volver_de_Borrar_VidYCan.TabStop = false;
            this.Volver_de_Borrar_VidYCan.Click += new System.EventHandler(this.Volver_de_Borrar_VidYCan_Click);
            // 
            // panel_label_borrar_video
            // 
            this.panel_label_borrar_video.BackColor = System.Drawing.Color.DarkRed;
            this.panel_label_borrar_video.Controls.Add(this.label5);
            this.panel_label_borrar_video.Location = new System.Drawing.Point(1, 322);
            this.panel_label_borrar_video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_label_borrar_video.Name = "panel_label_borrar_video";
            this.panel_label_borrar_video.Size = new System.Drawing.Size(745, 38);
            this.panel_label_borrar_video.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Videos Subidas";
            // 
            // panel_label_borrar_Cancion
            // 
            this.panel_label_borrar_Cancion.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_label_borrar_Cancion.Controls.Add(this.label4);
            this.panel_label_borrar_Cancion.Location = new System.Drawing.Point(3, 0);
            this.panel_label_borrar_Cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_label_borrar_Cancion.Name = "panel_label_borrar_Cancion";
            this.panel_label_borrar_Cancion.Size = new System.Drawing.Size(733, 38);
            this.panel_label_borrar_Cancion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Canciones Subidas";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(0, 358);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1010, 268);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(3, 42);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 281);
            this.panel4.TabIndex = 0;
            // 
            // label_add_genero
            // 
            this.label_add_genero.AutoSize = true;
            this.label_add_genero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_genero.Location = new System.Drawing.Point(45, 368);
            this.label_add_genero.Name = "label_add_genero";
            this.label_add_genero.Size = new System.Drawing.Size(78, 20);
            this.label_add_genero.TabIndex = 33;
            this.label_add_genero.Text = "Generos";
            // 
            // pictureBox_back_create_music
            // 
            this.pictureBox_back_create_music.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_back_create_music.Image")));
            this.pictureBox_back_create_music.Location = new System.Drawing.Point(17, 50);
            this.pictureBox_back_create_music.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_back_create_music.Name = "pictureBox_back_create_music";
            this.pictureBox_back_create_music.Size = new System.Drawing.Size(59, 47);
            this.pictureBox_back_create_music.TabIndex = 31;
            this.pictureBox_back_create_music.TabStop = false;
            this.pictureBox_back_create_music.Click += new System.EventHandler(this.pictureBox_back_create_music_Click);
            // 
            // button_add_more_artists
            // 
            this.button_add_more_artists.Location = new System.Drawing.Point(237, 222);
            this.button_add_more_artists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_more_artists.Name = "button_add_more_artists";
            this.button_add_more_artists.Size = new System.Drawing.Size(129, 28);
            this.button_add_more_artists.TabIndex = 30;
            this.button_add_more_artists.Text = "Añadir otro";
            this.button_add_more_artists.UseVisualStyleBackColor = true;
            this.button_add_more_artists.Click += new System.EventHandler(this.button_add_more_artists_Click);
            // 
            // checkBox_sexo_mujer
            // 
            this.checkBox_sexo_mujer.AutoSize = true;
            this.checkBox_sexo_mujer.Location = new System.Drawing.Point(487, 183);
            this.checkBox_sexo_mujer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_sexo_mujer.Name = "checkBox_sexo_mujer";
            this.checkBox_sexo_mujer.Size = new System.Drawing.Size(41, 21);
            this.checkBox_sexo_mujer.TabIndex = 28;
            this.checkBox_sexo_mujer.Text = "M";
            this.checkBox_sexo_mujer.UseVisualStyleBackColor = true;
            this.checkBox_sexo_mujer.CheckedChanged += new System.EventHandler(this.checkBox_sexo_mujer_CheckedChanged);
            // 
            // checkBox_sexo_hombre
            // 
            this.checkBox_sexo_hombre.AutoSize = true;
            this.checkBox_sexo_hombre.Location = new System.Drawing.Point(416, 183);
            this.checkBox_sexo_hombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_sexo_hombre.Name = "checkBox_sexo_hombre";
            this.checkBox_sexo_hombre.Size = new System.Drawing.Size(40, 21);
            this.checkBox_sexo_hombre.TabIndex = 27;
            this.checkBox_sexo_hombre.Text = "H";
            this.checkBox_sexo_hombre.UseVisualStyleBackColor = true;
            this.checkBox_sexo_hombre.CheckedChanged += new System.EventHandler(this.checkBox_sexo_hombre_CheckedChanged);
            // 
            // textBox_add_edad_artista
            // 
            this.textBox_add_edad_artista.Location = new System.Drawing.Point(237, 183);
            this.textBox_add_edad_artista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_edad_artista.Name = "textBox_add_edad_artista";
            this.textBox_add_edad_artista.Size = new System.Drawing.Size(68, 22);
            this.textBox_add_edad_artista.TabIndex = 26;
            // 
            // label_add_artista_sexo
            // 
            this.label_add_artista_sexo.AutoSize = true;
            this.label_add_artista_sexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_artista_sexo.Location = new System.Drawing.Point(325, 185);
            this.label_add_artista_sexo.Name = "label_add_artista_sexo";
            this.label_add_artista_sexo.Size = new System.Drawing.Size(74, 20);
            this.label_add_artista_sexo.TabIndex = 25;
            this.label_add_artista_sexo.Text = "iii) Sexo";
            // 
            // label_add_edad_artista_cancion
            // 
            this.label_add_edad_artista_cancion.AutoSize = true;
            this.label_add_edad_artista_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_edad_artista_cancion.Location = new System.Drawing.Point(125, 185);
            this.label_add_edad_artista_cancion.Name = "label_add_edad_artista_cancion";
            this.label_add_edad_artista_cancion.Size = new System.Drawing.Size(72, 20);
            this.label_add_edad_artista_cancion.TabIndex = 24;
            this.label_add_edad_artista_cancion.Text = "ii) Edad";
            // 
            // richTextBox_add_descripcion_cancion
            // 
            this.richTextBox_add_descripcion_cancion.Location = new System.Drawing.Point(239, 402);
            this.richTextBox_add_descripcion_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_add_descripcion_cancion.Name = "richTextBox_add_descripcion_cancion";
            this.richTextBox_add_descripcion_cancion.Size = new System.Drawing.Size(324, 47);
            this.richTextBox_add_descripcion_cancion.TabIndex = 23;
            this.richTextBox_add_descripcion_cancion.Text = "";
            // 
            // button_examinar_directorio
            // 
            this.button_examinar_directorio.Location = new System.Drawing.Point(453, 629);
            this.button_examinar_directorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_examinar_directorio.Name = "button_examinar_directorio";
            this.button_examinar_directorio.Size = new System.Drawing.Size(116, 32);
            this.button_examinar_directorio.TabIndex = 21;
            this.button_examinar_directorio.Text = "Examinar";
            this.button_examinar_directorio.UseVisualStyleBackColor = true;
            this.button_examinar_directorio.Click += new System.EventHandler(this.button_examinar_directorio_Click);
            // 
            // textBox_add_directorio_cancion
            // 
            this.textBox_add_directorio_cancion.Location = new System.Drawing.Point(179, 634);
            this.textBox_add_directorio_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_directorio_cancion.Name = "textBox_add_directorio_cancion";
            this.textBox_add_directorio_cancion.ReadOnly = true;
            this.textBox_add_directorio_cancion.Size = new System.Drawing.Size(243, 22);
            this.textBox_add_directorio_cancion.TabIndex = 20;
            // 
            // button_examinar_letra
            // 
            this.button_examinar_letra.Location = new System.Drawing.Point(453, 582);
            this.button_examinar_letra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_examinar_letra.Name = "button_examinar_letra";
            this.button_examinar_letra.Size = new System.Drawing.Size(116, 32);
            this.button_examinar_letra.TabIndex = 19;
            this.button_examinar_letra.Text = "Examinar";
            this.button_examinar_letra.UseVisualStyleBackColor = true;
            this.button_examinar_letra.Click += new System.EventHandler(this.button_examinar_letra_Click);
            // 
            // textBox_add_letra_cancion
            // 
            this.textBox_add_letra_cancion.Location = new System.Drawing.Point(179, 587);
            this.textBox_add_letra_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_letra_cancion.Name = "textBox_add_letra_cancion";
            this.textBox_add_letra_cancion.ReadOnly = true;
            this.textBox_add_letra_cancion.Size = new System.Drawing.Size(243, 22);
            this.textBox_add_letra_cancion.TabIndex = 18;
            // 
            // pictureBox_add_portada_cancion
            // 
            this.pictureBox_add_portada_cancion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_portada_cancion.BackgroundImage")));
            this.pictureBox_add_portada_cancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_portada_cancion.Image")));
            this.pictureBox_add_portada_cancion.Location = new System.Drawing.Point(188, 468);
            this.pictureBox_add_portada_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_add_portada_cancion.Name = "pictureBox_add_portada_cancion";
            this.pictureBox_add_portada_cancion.Size = new System.Drawing.Size(125, 111);
            this.pictureBox_add_portada_cancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_add_portada_cancion.TabIndex = 17;
            this.pictureBox_add_portada_cancion.TabStop = false;
            this.pictureBox_add_portada_cancion.Click += new System.EventHandler(this.pictureBox_add_portada_cancion_Click);
            // 
            // dateTimePicker_add_fecha_publicacion_cancion
            // 
            this.dateTimePicker_add_fecha_publicacion_cancion.Location = new System.Drawing.Point(240, 330);
            this.dateTimePicker_add_fecha_publicacion_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_add_fecha_publicacion_cancion.Name = "dateTimePicker_add_fecha_publicacion_cancion";
            this.dateTimePicker_add_fecha_publicacion_cancion.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker_add_fecha_publicacion_cancion.TabIndex = 15;
            // 
            // textBox_add_estudio_cancion
            // 
            this.textBox_add_estudio_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_add_estudio_cancion.Location = new System.Drawing.Point(237, 291);
            this.textBox_add_estudio_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_estudio_cancion.Name = "textBox_add_estudio_cancion";
            this.textBox_add_estudio_cancion.Size = new System.Drawing.Size(472, 22);
            this.textBox_add_estudio_cancion.TabIndex = 14;
            // 
            // textBox_add_album_artist
            // 
            this.textBox_add_album_artist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_add_album_artist.Location = new System.Drawing.Point(238, 259);
            this.textBox_add_album_artist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_album_artist.Name = "textBox_add_album_artist";
            this.textBox_add_album_artist.Size = new System.Drawing.Size(471, 22);
            this.textBox_add_album_artist.TabIndex = 13;
            // 
            // textBox_add_nombre_artista_cancion
            // 
            this.textBox_add_nombre_artista_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_add_nombre_artista_cancion.Location = new System.Drawing.Point(237, 142);
            this.textBox_add_nombre_artista_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_nombre_artista_cancion.Name = "textBox_add_nombre_artista_cancion";
            this.textBox_add_nombre_artista_cancion.Size = new System.Drawing.Size(472, 22);
            this.textBox_add_nombre_artista_cancion.TabIndex = 12;
            // 
            // textBox_add_titulo_cancion
            // 
            this.textBox_add_titulo_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_add_titulo_cancion.Location = new System.Drawing.Point(237, 97);
            this.textBox_add_titulo_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_titulo_cancion.Name = "textBox_add_titulo_cancion";
            this.textBox_add_titulo_cancion.Size = new System.Drawing.Size(472, 22);
            this.textBox_add_titulo_cancion.TabIndex = 11;
            // 
            // label_add_directorio_cancion
            // 
            this.label_add_directorio_cancion.AutoSize = true;
            this.label_add_directorio_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_directorio_cancion.Location = new System.Drawing.Point(45, 636);
            this.label_add_directorio_cancion.Name = "label_add_directorio_cancion";
            this.label_add_directorio_cancion.Size = new System.Drawing.Size(92, 20);
            this.label_add_directorio_cancion.TabIndex = 10;
            this.label_add_directorio_cancion.Text = "Directorio";
            // 
            // label_add_letra_cancion
            // 
            this.label_add_letra_cancion.AutoSize = true;
            this.label_add_letra_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_letra_cancion.Location = new System.Drawing.Point(45, 590);
            this.label_add_letra_cancion.Name = "label_add_letra_cancion";
            this.label_add_letra_cancion.Size = new System.Drawing.Size(52, 20);
            this.label_add_letra_cancion.TabIndex = 9;
            this.label_add_letra_cancion.Text = "Letra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Portada";
            // 
            // label_add_descripcion_cancion
            // 
            this.label_add_descripcion_cancion.AutoSize = true;
            this.label_add_descripcion_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_descripcion_cancion.Location = new System.Drawing.Point(47, 402);
            this.label_add_descripcion_cancion.Name = "label_add_descripcion_cancion";
            this.label_add_descripcion_cancion.Size = new System.Drawing.Size(109, 20);
            this.label_add_descripcion_cancion.TabIndex = 7;
            this.label_add_descripcion_cancion.Text = "Descripcion";
            // 
            // label_add_fecha_cancion
            // 
            this.label_add_fecha_cancion.AutoSize = true;
            this.label_add_fecha_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_fecha_cancion.Location = new System.Drawing.Point(45, 330);
            this.label_add_fecha_cancion.Name = "label_add_fecha_cancion";
            this.label_add_fecha_cancion.Size = new System.Drawing.Size(185, 20);
            this.label_add_fecha_cancion.TabIndex = 6;
            this.label_add_fecha_cancion.Text = "Fecha de Publicacion";
            // 
            // label_add_estudio_cancion
            // 
            this.label_add_estudio_cancion.AutoSize = true;
            this.label_add_estudio_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_estudio_cancion.Location = new System.Drawing.Point(45, 295);
            this.label_add_estudio_cancion.Name = "label_add_estudio_cancion";
            this.label_add_estudio_cancion.Size = new System.Drawing.Size(71, 20);
            this.label_add_estudio_cancion.TabIndex = 5;
            this.label_add_estudio_cancion.Text = "Estudio";
            // 
            // label_add_album_cancion
            // 
            this.label_add_album_cancion.AutoSize = true;
            this.label_add_album_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_album_cancion.Location = new System.Drawing.Point(45, 263);
            this.label_add_album_cancion.Name = "label_add_album_cancion";
            this.label_add_album_cancion.Size = new System.Drawing.Size(62, 20);
            this.label_add_album_cancion.TabIndex = 4;
            this.label_add_album_cancion.Text = "Album";
            // 
            // label_add_Artistas_cancion
            // 
            this.label_add_Artistas_cancion.AutoSize = true;
            this.label_add_Artistas_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_Artistas_cancion.Location = new System.Drawing.Point(43, 149);
            this.label_add_Artistas_cancion.Name = "label_add_Artistas_cancion";
            this.label_add_Artistas_cancion.Size = new System.Drawing.Size(170, 20);
            this.label_add_Artistas_cancion.TabIndex = 3;
            this.label_add_Artistas_cancion.Text = "Artistas     i)Nombre";
            // 
            // label_add_titulo_cancion
            // 
            this.label_add_titulo_cancion.AutoSize = true;
            this.label_add_titulo_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_titulo_cancion.Location = new System.Drawing.Point(43, 100);
            this.label_add_titulo_cancion.Name = "label_add_titulo_cancion";
            this.label_add_titulo_cancion.Size = new System.Drawing.Size(56, 20);
            this.label_add_titulo_cancion.TabIndex = 2;
            this.label_add_titulo_cancion.Text = "Titulo";
            // 
            // panel_title_add_cancion
            // 
            this.panel_title_add_cancion.BackColor = System.Drawing.Color.Green;
            this.panel_title_add_cancion.Controls.Add(this.panelAgregarunVid);
            this.panel_title_add_cancion.Controls.Add(this.pictureBox_add_song_to_data);
            this.panel_title_add_cancion.Controls.Add(this.label_add_cancion);
            this.panel_title_add_cancion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_add_cancion.Location = new System.Drawing.Point(0, 0);
            this.panel_title_add_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_title_add_cancion.Name = "panel_title_add_cancion";
            this.panel_title_add_cancion.Size = new System.Drawing.Size(744, 42);
            this.panel_title_add_cancion.TabIndex = 0;
            this.panel_title_add_cancion.Visible = false;
            // 
            // panelAgregarunVid
            // 
            this.panelAgregarunVid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAgregarunVid.BackColor = System.Drawing.Color.DarkRed;
            this.panelAgregarunVid.Controls.Add(this.panel_fijar_info_cancion);
            this.panelAgregarunVid.Controls.Add(this.pictureBoxAgregarElVIdeo_enNuevoVId);
            this.panelAgregarunVid.Controls.Add(this.lblAgregarNuevoVid);
            this.panelAgregarunVid.Location = new System.Drawing.Point(0, -2);
            this.panelAgregarunVid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAgregarunVid.Name = "panelAgregarunVid";
            this.panelAgregarunVid.Size = new System.Drawing.Size(749, 46);
            this.panelAgregarunVid.TabIndex = 2;
            // 
            // panel_fijar_info_cancion
            // 
            this.panel_fijar_info_cancion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_fijar_info_cancion.Controls.Add(this.pictureBox_atras_cancion);
            this.panel_fijar_info_cancion.Controls.Add(this.label_mensaje_cancion_descargada);
            this.panel_fijar_info_cancion.Location = new System.Drawing.Point(0, 2);
            this.panel_fijar_info_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_fijar_info_cancion.Name = "panel_fijar_info_cancion";
            this.panel_fijar_info_cancion.Size = new System.Drawing.Size(755, 44);
            this.panel_fijar_info_cancion.TabIndex = 35;
            this.panel_fijar_info_cancion.Visible = false;
            // 
            // pictureBox_atras_cancion
            // 
            this.pictureBox_atras_cancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_atras_cancion.Image")));
            this.pictureBox_atras_cancion.Location = new System.Drawing.Point(27, 2);
            this.pictureBox_atras_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_atras_cancion.Name = "pictureBox_atras_cancion";
            this.pictureBox_atras_cancion.Size = new System.Drawing.Size(75, 43);
            this.pictureBox_atras_cancion.TabIndex = 0;
            this.pictureBox_atras_cancion.TabStop = false;
            this.pictureBox_atras_cancion.Click += new System.EventHandler(this.pictureBox_atras_cancion_Click);
            // 
            // label_mensaje_cancion_descargada
            // 
            this.label_mensaje_cancion_descargada.AutoSize = true;
            this.label_mensaje_cancion_descargada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensaje_cancion_descargada.ForeColor = System.Drawing.Color.Green;
            this.label_mensaje_cancion_descargada.Location = new System.Drawing.Point(376, 16);
            this.label_mensaje_cancion_descargada.Name = "label_mensaje_cancion_descargada";
            this.label_mensaje_cancion_descargada.Size = new System.Drawing.Size(226, 18);
            this.label_mensaje_cancion_descargada.TabIndex = 56;
            this.label_mensaje_cancion_descargada.Text = "Se ha descargado la cancion";
            this.label_mensaje_cancion_descargada.Visible = false;
            // 
            // pictureBoxAgregarElVIdeo_enNuevoVId
            // 
            this.pictureBoxAgregarElVIdeo_enNuevoVId.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAgregarElVIdeo_enNuevoVId.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAgregarElVIdeo_enNuevoVId.ErrorImage")));
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAgregarElVIdeo_enNuevoVId.Image")));
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Location = new System.Drawing.Point(689, 0);
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Name = "pictureBoxAgregarElVIdeo_enNuevoVId";
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Size = new System.Drawing.Size(60, 46);
            this.pictureBoxAgregarElVIdeo_enNuevoVId.TabIndex = 34;
            this.pictureBoxAgregarElVIdeo_enNuevoVId.TabStop = false;
            this.pictureBoxAgregarElVIdeo_enNuevoVId.Click += new System.EventHandler(this.pictureBoxAgregarElVIdeo_enNuevoVId_Click);
            // 
            // lblAgregarNuevoVid
            // 
            this.lblAgregarNuevoVid.AutoSize = true;
            this.lblAgregarNuevoVid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblAgregarNuevoVid.Location = new System.Drawing.Point(27, 11);
            this.lblAgregarNuevoVid.Name = "lblAgregarNuevoVid";
            this.lblAgregarNuevoVid.Size = new System.Drawing.Size(275, 29);
            this.lblAgregarNuevoVid.TabIndex = 33;
            this.lblAgregarNuevoVid.Text = "Agregar Nuevo Video";
            // 
            // pictureBox_add_song_to_data
            // 
            this.pictureBox_add_song_to_data.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_add_song_to_data.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_song_to_data.Image")));
            this.pictureBox_add_song_to_data.Location = new System.Drawing.Point(701, 0);
            this.pictureBox_add_song_to_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_add_song_to_data.Name = "pictureBox_add_song_to_data";
            this.pictureBox_add_song_to_data.Size = new System.Drawing.Size(43, 42);
            this.pictureBox_add_song_to_data.TabIndex = 1;
            this.pictureBox_add_song_to_data.TabStop = false;
            this.pictureBox_add_song_to_data.Click += new System.EventHandler(this.pictureBox_add_song_to_data_Click);
            // 
            // label_add_cancion
            // 
            this.label_add_cancion.AutoSize = true;
            this.label_add_cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_cancion.Location = new System.Drawing.Point(5, 4);
            this.label_add_cancion.Name = "label_add_cancion";
            this.label_add_cancion.Size = new System.Drawing.Size(300, 25);
            this.label_add_cancion.TabIndex = 0;
            this.label_add_cancion.Text = "Datos de la cancion a agregar";
            // 
            // label_error_add_artista
            // 
            this.label_error_add_artista.AutoSize = true;
            this.label_error_add_artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_add_artista.ForeColor = System.Drawing.Color.DarkRed;
            this.label_error_add_artista.Location = new System.Drawing.Point(372, 228);
            this.label_error_add_artista.Name = "label_error_add_artista";
            this.label_error_add_artista.Size = new System.Drawing.Size(210, 17);
            this.label_error_add_artista.TabIndex = 32;
            this.label_error_add_artista.Text = "La edad esta mal ingresada";
            this.label_error_add_artista.Visible = false;
            // 
            // label_error_add_cancion
            // 
            this.label_error_add_cancion.AutoSize = true;
            this.label_error_add_cancion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_add_cancion.ForeColor = System.Drawing.Color.Red;
            this.label_error_add_cancion.Location = new System.Drawing.Point(339, 66);
            this.label_error_add_cancion.Name = "label_error_add_cancion";
            this.label_error_add_cancion.Size = new System.Drawing.Size(244, 17);
            this.label_error_add_cancion.TabIndex = 37;
            this.label_error_add_cancion.Text = "Algun archivo indicado no existe";
            this.label_error_add_cancion.Visible = false;
            // 
            // lblEjemploCanciones
            // 
            this.lblEjemploCanciones.AutoSize = true;
            this.lblEjemploCanciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.lblEjemploCanciones.Location = new System.Drawing.Point(125, 368);
            this.lblEjemploCanciones.Name = "lblEjemploCanciones";
            this.lblEjemploCanciones.Size = new System.Drawing.Size(103, 16);
            this.lblEjemploCanciones.TabIndex = 38;
            this.lblEjemploCanciones.Text = "(pop,rock,etc)";
            // 
            // textBox_add_generos_cancion
            // 
            this.textBox_add_generos_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_add_generos_cancion.Location = new System.Drawing.Point(237, 366);
            this.textBox_add_generos_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_add_generos_cancion.Name = "textBox_add_generos_cancion";
            this.textBox_add_generos_cancion.Size = new System.Drawing.Size(472, 22);
            this.textBox_add_generos_cancion.TabIndex = 34;
            // 
            // label_info_tipo_usuario
            // 
            this.label_info_tipo_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info_tipo_usuario.AutoSize = true;
            this.label_info_tipo_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_tipo_usuario.Location = new System.Drawing.Point(36, 350);
            this.label_info_tipo_usuario.Name = "label_info_tipo_usuario";
            this.label_info_tipo_usuario.Size = new System.Drawing.Size(175, 23);
            this.label_info_tipo_usuario.TabIndex = 23;
            this.label_info_tipo_usuario.Text = "Tipo de Usuario: ";
            // 
            // label_infoPrivate
            // 
            this.label_infoPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_infoPrivate.AutoSize = true;
            this.label_infoPrivate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoPrivate.Location = new System.Drawing.Point(36, 286);
            this.label_infoPrivate.Name = "label_infoPrivate";
            this.label_infoPrivate.Size = new System.Drawing.Size(121, 23);
            this.label_infoPrivate.TabIndex = 22;
            this.label_infoPrivate.Text = "Privacidad:";
            // 
            // label_info_Nombre
            // 
            this.label_info_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info_Nombre.AutoSize = true;
            this.label_info_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_Nombre.Location = new System.Drawing.Point(36, 167);
            this.label_info_Nombre.Name = "label_info_Nombre";
            this.label_info_Nombre.Size = new System.Drawing.Size(100, 23);
            this.label_info_Nombre.TabIndex = 21;
            this.label_info_Nombre.Text = "Nombre: ";
            // 
            // label_infoEdad
            // 
            this.label_infoEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_infoEdad.AutoSize = true;
            this.label_infoEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoEdad.Location = new System.Drawing.Point(36, 225);
            this.label_infoEdad.Name = "label_infoEdad";
            this.label_infoEdad.Size = new System.Drawing.Size(67, 23);
            this.label_infoEdad.TabIndex = 20;
            this.label_infoEdad.Text = "Edad:";
            // 
            // label_infoSeguidores
            // 
            this.label_infoSeguidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_infoSeguidores.AutoSize = true;
            this.label_infoSeguidores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoSeguidores.Location = new System.Drawing.Point(36, 407);
            this.label_infoSeguidores.Name = "label_infoSeguidores";
            this.label_infoSeguidores.Size = new System.Drawing.Size(128, 23);
            this.label_infoSeguidores.TabIndex = 19;
            this.label_infoSeguidores.Text = "Seguidores:";
            // 
            // pictureBox_backtoconfig
            // 
            this.pictureBox_backtoconfig.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtoconfig.Image")));
            this.pictureBox_backtoconfig.Location = new System.Drawing.Point(17, 25);
            this.pictureBox_backtoconfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_backtoconfig.Name = "pictureBox_backtoconfig";
            this.pictureBox_backtoconfig.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_backtoconfig.TabIndex = 18;
            this.pictureBox_backtoconfig.TabStop = false;
            this.pictureBox_backtoconfig.Click += new System.EventHandler(this.pictureBox_backtoconfig_Click);
            // 
            // label_error_config
            // 
            this.label_error_config.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error_config.AutoSize = true;
            this.label_error_config.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_config.ForeColor = System.Drawing.Color.Red;
            this.label_error_config.Location = new System.Drawing.Point(77, 309);
            this.label_error_config.Name = "label_error_config";
            this.label_error_config.Size = new System.Drawing.Size(569, 17);
            this.label_error_config.TabIndex = 19;
            this.label_error_config.Text = "Hay un dato mal ingresado o el nuevo nickname ya existe, revise nuevamente";
            this.label_error_config.Visible = false;
            // 
            // label_ver_info
            // 
            this.label_ver_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ver_info.AutoSize = true;
            this.label_ver_info.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ver_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ver_info.Location = new System.Drawing.Point(44, 530);
            this.label_ver_info.Name = "label_ver_info";
            this.label_ver_info.Size = new System.Drawing.Size(164, 20);
            this.label_ver_info.TabIndex = 18;
            this.label_ver_info.Text = "Ver mi Informacion";
            this.label_ver_info.Click += new System.EventHandler(this.label_ver_info_Click);
            // 
            // pictureBox_Back1
            // 
            this.pictureBox_Back1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Back1.Image")));
            this.pictureBox_Back1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox_Back1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Back1.Name = "pictureBox_Back1";
            this.pictureBox_Back1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_Back1.TabIndex = 17;
            this.pictureBox_Back1.TabStop = false;
            this.pictureBox_Back1.Click += new System.EventHandler(this.pictureBox_Back1_Click);
            // 
            // label_borrar_usuario
            // 
            this.label_borrar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_borrar_usuario.AutoSize = true;
            this.label_borrar_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_borrar_usuario.ForeColor = System.Drawing.Color.DarkRed;
            this.label_borrar_usuario.Location = new System.Drawing.Point(44, 574);
            this.label_borrar_usuario.Name = "label_borrar_usuario";
            this.label_borrar_usuario.Size = new System.Drawing.Size(130, 20);
            this.label_borrar_usuario.TabIndex = 16;
            this.label_borrar_usuario.Text = "Borrar Usuario";
            this.label_borrar_usuario.Click += new System.EventHandler(this.label_borrar_usuario_Click);
            // 
            // button_cambiar_free
            // 
            this.button_cambiar_free.Location = new System.Drawing.Point(336, 431);
            this.button_cambiar_free.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cambiar_free.Name = "button_cambiar_free";
            this.button_cambiar_free.Size = new System.Drawing.Size(116, 30);
            this.button_cambiar_free.TabIndex = 15;
            this.button_cambiar_free.Text = "Gratuito";
            this.button_cambiar_free.UseVisualStyleBackColor = true;
            this.button_cambiar_free.Click += new System.EventHandler(this.button_cambiar_free_Click);
            // 
            // button_cmabiar_premium
            // 
            this.button_cmabiar_premium.Location = new System.Drawing.Point(477, 431);
            this.button_cmabiar_premium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cmabiar_premium.Name = "button_cmabiar_premium";
            this.button_cmabiar_premium.Size = new System.Drawing.Size(116, 30);
            this.button_cmabiar_premium.TabIndex = 14;
            this.button_cmabiar_premium.Text = "Premium";
            this.button_cmabiar_premium.UseVisualStyleBackColor = true;
            this.button_cmabiar_premium.Click += new System.EventHandler(this.button_cmabiar_premium_Click);
            // 
            // label_cambiar_plan
            // 
            this.label_cambiar_plan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_plan.AutoSize = true;
            this.label_cambiar_plan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_plan.Location = new System.Drawing.Point(44, 431);
            this.label_cambiar_plan.Name = "label_cambiar_plan";
            this.label_cambiar_plan.Size = new System.Drawing.Size(236, 22);
            this.label_cambiar_plan.TabIndex = 13;
            this.label_cambiar_plan.Text = "Cambiar Plan de Usuario";
            // 
            // button_guardar_cambios
            // 
            this.button_guardar_cambios.Location = new System.Drawing.Point(221, 265);
            this.button_guardar_cambios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_guardar_cambios.Name = "button_guardar_cambios";
            this.button_guardar_cambios.Size = new System.Drawing.Size(229, 30);
            this.button_guardar_cambios.TabIndex = 12;
            this.button_guardar_cambios.Text = "Guardar Cambios";
            this.button_guardar_cambios.UseVisualStyleBackColor = true;
            this.button_guardar_cambios.Click += new System.EventHandler(this.button_guardar_cambios_Click);
            // 
            // button_cambiarPrivado
            // 
            this.button_cambiarPrivado.Location = new System.Drawing.Point(477, 350);
            this.button_cambiarPrivado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cambiarPrivado.Name = "button_cambiarPrivado";
            this.button_cambiarPrivado.Size = new System.Drawing.Size(116, 30);
            this.button_cambiarPrivado.TabIndex = 11;
            this.button_cambiarPrivado.Text = "Privado";
            this.button_cambiarPrivado.UseVisualStyleBackColor = true;
            this.button_cambiarPrivado.Click += new System.EventHandler(this.button_cambiarPrivado_Click);
            // 
            // button_cambiar_publico
            // 
            this.button_cambiar_publico.Location = new System.Drawing.Point(336, 350);
            this.button_cambiar_publico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cambiar_publico.Name = "button_cambiar_publico";
            this.button_cambiar_publico.Size = new System.Drawing.Size(116, 30);
            this.button_cambiar_publico.TabIndex = 10;
            this.button_cambiar_publico.Text = "Publico";
            this.button_cambiar_publico.UseVisualStyleBackColor = true;
            this.button_cambiar_publico.Click += new System.EventHandler(this.button_cambiar_publico_Click);
            // 
            // label_cambiar_tipoUsuario
            // 
            this.label_cambiar_tipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_tipoUsuario.AutoSize = true;
            this.label_cambiar_tipoUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_tipoUsuario.Location = new System.Drawing.Point(44, 348);
            this.label_cambiar_tipoUsuario.Name = "label_cambiar_tipoUsuario";
            this.label_cambiar_tipoUsuario.Size = new System.Drawing.Size(236, 22);
            this.label_cambiar_tipoUsuario.TabIndex = 9;
            this.label_cambiar_tipoUsuario.Text = "Cambiar Tipo de Usuario";
            // 
            // textBox_cambiar_edad
            // 
            this.textBox_cambiar_edad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cambiar_edad.Location = new System.Drawing.Point(205, 224);
            this.textBox_cambiar_edad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cambiar_edad.Name = "textBox_cambiar_edad";
            this.textBox_cambiar_edad.Size = new System.Drawing.Size(432, 22);
            this.textBox_cambiar_edad.TabIndex = 8;
            // 
            // textBox_cambiar_nombre
            // 
            this.textBox_cambiar_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cambiar_nombre.Location = new System.Drawing.Point(205, 186);
            this.textBox_cambiar_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cambiar_nombre.Name = "textBox_cambiar_nombre";
            this.textBox_cambiar_nombre.Size = new System.Drawing.Size(432, 22);
            this.textBox_cambiar_nombre.TabIndex = 7;
            // 
            // textBox_cambiar_clave
            // 
            this.textBox_cambiar_clave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cambiar_clave.Location = new System.Drawing.Point(205, 148);
            this.textBox_cambiar_clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cambiar_clave.Name = "textBox_cambiar_clave";
            this.textBox_cambiar_clave.Size = new System.Drawing.Size(432, 22);
            this.textBox_cambiar_clave.TabIndex = 6;
            // 
            // textBox_cambiarNick
            // 
            this.textBox_cambiarNick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cambiarNick.Location = new System.Drawing.Point(205, 107);
            this.textBox_cambiarNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cambiarNick.Name = "textBox_cambiarNick";
            this.textBox_cambiarNick.Size = new System.Drawing.Size(432, 22);
            this.textBox_cambiarNick.TabIndex = 5;
            // 
            // label_cambiar_Edad
            // 
            this.label_cambiar_Edad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_Edad.AutoSize = true;
            this.label_cambiar_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_Edad.Location = new System.Drawing.Point(77, 226);
            this.label_cambiar_Edad.Name = "label_cambiar_Edad";
            this.label_cambiar_Edad.Size = new System.Drawing.Size(47, 20);
            this.label_cambiar_Edad.TabIndex = 4;
            this.label_cambiar_Edad.Text = "Edad";
            // 
            // label_cambiar_nombre
            // 
            this.label_cambiar_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_nombre.AutoSize = true;
            this.label_cambiar_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_nombre.Location = new System.Drawing.Point(77, 186);
            this.label_cambiar_nombre.Name = "label_cambiar_nombre";
            this.label_cambiar_nombre.Size = new System.Drawing.Size(68, 20);
            this.label_cambiar_nombre.TabIndex = 3;
            this.label_cambiar_nombre.Text = "Nombre";
            // 
            // label_cambiar_password
            // 
            this.label_cambiar_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_password.AutoSize = true;
            this.label_cambiar_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_password.Location = new System.Drawing.Point(77, 148);
            this.label_cambiar_password.Name = "label_cambiar_password";
            this.label_cambiar_password.Size = new System.Drawing.Size(95, 20);
            this.label_cambiar_password.TabIndex = 2;
            this.label_cambiar_password.Text = "Contraseña";
            // 
            // label_cambiar_nickname
            // 
            this.label_cambiar_nickname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_nickname.AutoSize = true;
            this.label_cambiar_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_nickname.Location = new System.Drawing.Point(77, 113);
            this.label_cambiar_nickname.Name = "label_cambiar_nickname";
            this.label_cambiar_nickname.Size = new System.Drawing.Size(83, 20);
            this.label_cambiar_nickname.TabIndex = 1;
            this.label_cambiar_nickname.Text = "Nickname";
            // 
            // label_cambiar_datos
            // 
            this.label_cambiar_datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cambiar_datos.AutoSize = true;
            this.label_cambiar_datos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambiar_datos.Location = new System.Drawing.Point(44, 64);
            this.label_cambiar_datos.Name = "label_cambiar_datos";
            this.label_cambiar_datos.Size = new System.Drawing.Size(249, 22);
            this.label_cambiar_datos.TabIndex = 0;
            this.label_cambiar_datos.Text = "Cambiar Datos de Usuario";
            // 
            // BorrarVidYCan
            // 
            this.BorrarVidYCan.AutoSize = true;
            this.BorrarVidYCan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.BorrarVidYCan.ForeColor = System.Drawing.Color.DarkRed;
            this.BorrarVidYCan.Location = new System.Drawing.Point(44, 620);
            this.BorrarVidYCan.Name = "BorrarVidYCan";
            this.BorrarVidYCan.Size = new System.Drawing.Size(227, 20);
            this.BorrarVidYCan.TabIndex = 59;
            this.BorrarVidYCan.Text = "Borrar Canciones y Videos";
            this.BorrarVidYCan.Click += new System.EventHandler(this.BorrarVidYCan_Click);
            // 
            // panel_buscador
            // 
            this.panel_buscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_buscador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_buscador.Controls.Add(this.panel1);
            this.panel_buscador.Controls.Add(this.panel_info);
            this.panel_buscador.Controls.Add(this.picture_buscar);
            this.panel_buscador.Controls.Add(this.button_buscar_filtro);
            this.panel_buscador.Controls.Add(this.textBox_Buscar);
            this.panel_buscador.Location = new System.Drawing.Point(1, 2);
            this.panel_buscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_buscador.MinimumSize = new System.Drawing.Size(741, 34);
            this.panel_buscador.Name = "panel_buscador";
            this.panel_buscador.Size = new System.Drawing.Size(741, 34);
            this.panel_buscador.TabIndex = 0;
            this.panel_buscador.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(237, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 57);
            this.panel1.TabIndex = 33;
            // 
            // panel_info
            // 
            this.panel_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_info.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_info.Location = new System.Drawing.Point(3, 34);
            this.panel_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(740, 683);
            this.panel_info.TabIndex = 2;
            // 
            // picture_buscar
            // 
            this.picture_buscar.Image = ((System.Drawing.Image)(resources.GetObject("picture_buscar.Image")));
            this.picture_buscar.Location = new System.Drawing.Point(367, 5);
            this.picture_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_buscar.Name = "picture_buscar";
            this.picture_buscar.Size = new System.Drawing.Size(33, 27);
            this.picture_buscar.TabIndex = 1;
            this.picture_buscar.TabStop = false;
            this.picture_buscar.Click += new System.EventHandler(this.picture_buscar_Click);
            // 
            // button_buscar_filtro
            // 
            this.button_buscar_filtro.BackgroundImage = global::Spotflex.Properties.Resources.back;
            this.button_buscar_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_buscar_filtro.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_buscar_filtro.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_buscar_filtro.Location = new System.Drawing.Point(544, 0);
            this.button_buscar_filtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_buscar_filtro.Name = "button_buscar_filtro";
            this.button_buscar_filtro.Size = new System.Drawing.Size(197, 34);
            this.button_buscar_filtro.TabIndex = 1;
            this.button_buscar_filtro.Text = "Busqueda Avanzada";
            this.button_buscar_filtro.UseVisualStyleBackColor = true;
            this.button_buscar_filtro.Click += new System.EventHandler(this.button_buscar_filtro_Click);
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(16, 7);
            this.textBox_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(344, 22);
            this.textBox_Buscar.TabIndex = 0;
            // 
            // panel_secc_video
            // 
            this.panel_secc_video.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_secc_video.BackColor = System.Drawing.Color.Maroon;
            this.panel_secc_video.Controls.Add(this.pictureBox_add_video);
            this.panel_secc_video.Controls.Add(this.label_indicador_Videos);
            this.panel_secc_video.Location = new System.Drawing.Point(0, 369);
            this.panel_secc_video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_secc_video.Name = "panel_secc_video";
            this.panel_secc_video.Size = new System.Drawing.Size(745, 39);
            this.panel_secc_video.TabIndex = 3;
            // 
            // pictureBox_add_video
            // 
            this.pictureBox_add_video.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_add_video.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_video.Image")));
            this.pictureBox_add_video.Location = new System.Drawing.Point(689, 0);
            this.pictureBox_add_video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_add_video.Name = "pictureBox_add_video";
            this.pictureBox_add_video.Size = new System.Drawing.Size(56, 39);
            this.pictureBox_add_video.TabIndex = 2;
            this.pictureBox_add_video.TabStop = false;
            this.pictureBox_add_video.Click += new System.EventHandler(this.pictureBox_add_video_Click);
            // 
            // label_indicador_Videos
            // 
            this.label_indicador_Videos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_indicador_Videos.AutoSize = true;
            this.label_indicador_Videos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_indicador_Videos.Location = new System.Drawing.Point(43, 9);
            this.label_indicador_Videos.Name = "label_indicador_Videos";
            this.label_indicador_Videos.Size = new System.Drawing.Size(197, 25);
            this.label_indicador_Videos.TabIndex = 1;
            this.label_indicador_Videos.Text = "Videos Disponibles";
            // 
            // panel_galeria_videos
            // 
            this.panel_galeria_videos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_galeria_videos.AutoScroll = true;
            this.panel_galeria_videos.BackgroundImage = global::Spotflex.Properties.Resources.GaleriaFV;
            this.panel_galeria_videos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_galeria_videos.Location = new System.Drawing.Point(1, 409);
            this.panel_galeria_videos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_galeria_videos.Name = "panel_galeria_videos";
            this.panel_galeria_videos.Size = new System.Drawing.Size(747, 308);
            this.panel_galeria_videos.TabIndex = 2;
            this.panel_galeria_videos.Visible = false;
            // 
            // panel_galeria_canciones
            // 
            this.panel_galeria_canciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_galeria_canciones.AutoScroll = true;
            this.panel_galeria_canciones.BackgroundImage = global::Spotflex.Properties.Resources.GaleriaFC;
            this.panel_galeria_canciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_galeria_canciones.Location = new System.Drawing.Point(0, 74);
            this.panel_galeria_canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_galeria_canciones.Name = "panel_galeria_canciones";
            this.panel_galeria_canciones.Size = new System.Drawing.Size(747, 292);
            this.panel_galeria_canciones.TabIndex = 1;
            this.panel_galeria_canciones.Visible = false;
            // 
            // panel_secc_cancion
            // 
            this.panel_secc_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_secc_cancion.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_secc_cancion.Controls.Add(this.pictureBox_add_music);
            this.panel_secc_cancion.Controls.Add(this.label_indicador_Canciones_Disp);
            this.panel_secc_cancion.Location = new System.Drawing.Point(0, 38);
            this.panel_secc_cancion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_secc_cancion.Name = "panel_secc_cancion";
            this.panel_secc_cancion.Size = new System.Drawing.Size(745, 41);
            this.panel_secc_cancion.TabIndex = 2;
            this.panel_secc_cancion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_secc_cancion_Paint);
            // 
            // pictureBox_add_music
            // 
            this.pictureBox_add_music.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_add_music.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_music.Image")));
            this.pictureBox_add_music.Location = new System.Drawing.Point(689, 0);
            this.pictureBox_add_music.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_add_music.Name = "pictureBox_add_music";
            this.pictureBox_add_music.Size = new System.Drawing.Size(56, 41);
            this.pictureBox_add_music.TabIndex = 1;
            this.pictureBox_add_music.TabStop = false;
            this.pictureBox_add_music.Click += new System.EventHandler(this.pictureBox_add_music_Click);
            // 
            // label_indicador_Canciones_Disp
            // 
            this.label_indicador_Canciones_Disp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_indicador_Canciones_Disp.AutoSize = true;
            this.label_indicador_Canciones_Disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_indicador_Canciones_Disp.Location = new System.Drawing.Point(23, 9);
            this.label_indicador_Canciones_Disp.Name = "label_indicador_Canciones_Disp";
            this.label_indicador_Canciones_Disp.Size = new System.Drawing.Size(233, 25);
            this.label_indicador_Canciones_Disp.TabIndex = 0;
            this.label_indicador_Canciones_Disp.Text = "Canciones Disponibles";
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.FotoPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.BackgroundImage")));
            this.FotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FotoPerfil.ErrorImage = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.ErrorImage")));
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.InitialImage")));
            this.FotoPerfil.Location = new System.Drawing.Point(39, 12);
            this.FotoPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(176, 176);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPerfil.TabIndex = 0;
            this.FotoPerfil.TabStop = false;
            this.FotoPerfil.Click += new System.EventHandler(this.FotoPerfil_Click);
            // 
            // label_error_registro
            // 
            this.label_error_registro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error_registro.AutoSize = true;
            this.label_error_registro.BackColor = System.Drawing.Color.Transparent;
            this.label_error_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_registro.ForeColor = System.Drawing.Color.Red;
            this.label_error_registro.Location = new System.Drawing.Point(160, 510);
            this.label_error_registro.Name = "label_error_registro";
            this.label_error_registro.Size = new System.Drawing.Size(693, 20);
            this.label_error_registro.TabIndex = 22;
            this.label_error_registro.Text = "Hay casillas vacias o hay elementos de un formato incorrecto, intentelo de nuevo";
            this.label_error_registro.Visible = false;
            // 
            // button_registrar
            // 
            this.button_registrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registrar.Location = new System.Drawing.Point(543, 544);
            this.button_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_registrar.Name = "button_registrar";
            this.button_registrar.Size = new System.Drawing.Size(245, 46);
            this.button_registrar.TabIndex = 21;
            this.button_registrar.Text = "Registrar";
            this.button_registrar.UseVisualStyleBackColor = true;
            this.button_registrar.Click += new System.EventHandler(this.button_registrar_Click);
            // 
            // button_regresar
            // 
            this.button_regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.Location = new System.Drawing.Point(191, 544);
            this.button_regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(253, 46);
            this.button_regresar.TabIndex = 20;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = true;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // error_edad
            // 
            this.error_edad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_edad.AutoSize = true;
            this.error_edad.BackColor = System.Drawing.Color.Transparent;
            this.error_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_edad.ForeColor = System.Drawing.Color.Red;
            this.error_edad.Location = new System.Drawing.Point(813, 183);
            this.error_edad.Name = "error_edad";
            this.error_edad.Size = new System.Drawing.Size(20, 25);
            this.error_edad.TabIndex = 19;
            this.error_edad.Text = "*";
            this.error_edad.Visible = false;
            // 
            // error_plan_usuario
            // 
            this.error_plan_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_plan_usuario.AutoSize = true;
            this.error_plan_usuario.BackColor = System.Drawing.Color.Transparent;
            this.error_plan_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_plan_usuario.ForeColor = System.Drawing.Color.Red;
            this.error_plan_usuario.Location = new System.Drawing.Point(813, 261);
            this.error_plan_usuario.Name = "error_plan_usuario";
            this.error_plan_usuario.Size = new System.Drawing.Size(20, 25);
            this.error_plan_usuario.TabIndex = 18;
            this.error_plan_usuario.Text = "*";
            this.error_plan_usuario.Visible = false;
            // 
            // error_plan_sesion
            // 
            this.error_plan_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_plan_sesion.AutoSize = true;
            this.error_plan_sesion.BackColor = System.Drawing.Color.Transparent;
            this.error_plan_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_plan_sesion.ForeColor = System.Drawing.Color.Red;
            this.error_plan_sesion.Location = new System.Drawing.Point(813, 322);
            this.error_plan_sesion.Name = "error_plan_sesion";
            this.error_plan_sesion.Size = new System.Drawing.Size(20, 25);
            this.error_plan_sesion.TabIndex = 17;
            this.error_plan_sesion.Text = "*";
            this.error_plan_sesion.Visible = false;
            // 
            // error_nickname
            // 
            this.error_nickname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_nickname.AutoSize = true;
            this.error_nickname.BackColor = System.Drawing.Color.Transparent;
            this.error_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_nickname.ForeColor = System.Drawing.Color.Red;
            this.error_nickname.Location = new System.Drawing.Point(813, 385);
            this.error_nickname.Name = "error_nickname";
            this.error_nickname.Size = new System.Drawing.Size(20, 25);
            this.error_nickname.TabIndex = 16;
            this.error_nickname.Text = "*";
            this.error_nickname.Visible = false;
            // 
            // error_clave
            // 
            this.error_clave.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.error_clave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_clave.AutoSize = true;
            this.error_clave.BackColor = System.Drawing.Color.Transparent;
            this.error_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_clave.ForeColor = System.Drawing.Color.Red;
            this.error_clave.Location = new System.Drawing.Point(812, 458);
            this.error_clave.Name = "error_clave";
            this.error_clave.Size = new System.Drawing.Size(20, 25);
            this.error_clave.TabIndex = 15;
            this.error_clave.Text = "*";
            this.error_clave.Visible = false;
            // 
            // error_nombre
            // 
            this.error_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_nombre.AutoSize = true;
            this.error_nombre.BackColor = System.Drawing.Color.Transparent;
            this.error_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(813, 103);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(20, 25);
            this.error_nombre.TabIndex = 14;
            this.error_nombre.Text = "*";
            this.error_nombre.Visible = false;
            // 
            // textBox_IngreseClave
            // 
            this.textBox_IngreseClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IngreseClave.Location = new System.Drawing.Point(481, 458);
            this.textBox_IngreseClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IngreseClave.Name = "textBox_IngreseClave";
            this.textBox_IngreseClave.Size = new System.Drawing.Size(308, 22);
            this.textBox_IngreseClave.TabIndex = 13;
            // 
            // textBox_IngreseNick
            // 
            this.textBox_IngreseNick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IngreseNick.Location = new System.Drawing.Point(481, 385);
            this.textBox_IngreseNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IngreseNick.Name = "textBox_IngreseNick";
            this.textBox_IngreseNick.Size = new System.Drawing.Size(308, 22);
            this.textBox_IngreseNick.TabIndex = 12;
            // 
            // button_Premium
            // 
            this.button_Premium.Location = new System.Drawing.Point(677, 322);
            this.button_Premium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Premium.Name = "button_Premium";
            this.button_Premium.Size = new System.Drawing.Size(111, 25);
            this.button_Premium.TabIndex = 11;
            this.button_Premium.Text = "Premium";
            this.button_Premium.UseVisualStyleBackColor = true;
            this.button_Premium.Click += new System.EventHandler(this.button_Premium_Click);
            // 
            // button_Gratuito
            // 
            this.button_Gratuito.Location = new System.Drawing.Point(481, 322);
            this.button_Gratuito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Gratuito.Name = "button_Gratuito";
            this.button_Gratuito.Size = new System.Drawing.Size(111, 25);
            this.button_Gratuito.TabIndex = 10;
            this.button_Gratuito.Text = "Gratuito";
            this.button_Gratuito.UseVisualStyleBackColor = true;
            this.button_Gratuito.Click += new System.EventHandler(this.button_Gratuito_Click);
            // 
            // button_privado
            // 
            this.button_privado.Location = new System.Drawing.Point(677, 257);
            this.button_privado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_privado.Name = "button_privado";
            this.button_privado.Size = new System.Drawing.Size(111, 25);
            this.button_privado.TabIndex = 9;
            this.button_privado.Text = "Privado";
            this.button_privado.UseVisualStyleBackColor = true;
            this.button_privado.Click += new System.EventHandler(this.button_privado_Click);
            // 
            // button_publico
            // 
            this.button_publico.Location = new System.Drawing.Point(481, 257);
            this.button_publico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_publico.Name = "button_publico";
            this.button_publico.Size = new System.Drawing.Size(111, 25);
            this.button_publico.TabIndex = 8;
            this.button_publico.Text = "Publico";
            this.button_publico.UseVisualStyleBackColor = true;
            this.button_publico.Click += new System.EventHandler(this.button_publico_Click);
            // 
            // textBox_Ingrese_Edad
            // 
            this.textBox_Ingrese_Edad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ingrese_Edad.Location = new System.Drawing.Point(481, 181);
            this.textBox_Ingrese_Edad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Ingrese_Edad.Name = "textBox_Ingrese_Edad";
            this.textBox_Ingrese_Edad.Size = new System.Drawing.Size(308, 22);
            this.textBox_Ingrese_Edad.TabIndex = 7;
            // 
            // textBox_Ingrese_Nombre
            // 
            this.textBox_Ingrese_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ingrese_Nombre.Location = new System.Drawing.Point(481, 103);
            this.textBox_Ingrese_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Ingrese_Nombre.Name = "textBox_Ingrese_Nombre";
            this.textBox_Ingrese_Nombre.Size = new System.Drawing.Size(308, 22);
            this.textBox_Ingrese_Nombre.TabIndex = 6;
            // 
            // label_tipo_usuario
            // 
            this.label_tipo_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tipo_usuario.AutoSize = true;
            this.label_tipo_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_tipo_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo_usuario.ForeColor = System.Drawing.Color.Green;
            this.label_tipo_usuario.Location = new System.Drawing.Point(192, 254);
            this.label_tipo_usuario.Name = "label_tipo_usuario";
            this.label_tipo_usuario.Size = new System.Drawing.Size(239, 23);
            this.label_tipo_usuario.TabIndex = 5;
            this.label_tipo_usuario.Text = "Elija su tipo de usuario: ";
            // 
            // label_premium_user
            // 
            this.label_premium_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_premium_user.AutoSize = true;
            this.label_premium_user.BackColor = System.Drawing.Color.Transparent;
            this.label_premium_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_premium_user.ForeColor = System.Drawing.Color.Green;
            this.label_premium_user.Location = new System.Drawing.Point(219, 320);
            this.label_premium_user.Name = "label_premium_user";
            this.label_premium_user.Size = new System.Drawing.Size(201, 23);
            this.label_premium_user.TabIndex = 4;
            this.label_premium_user.Text = "Elija plan de sesion:";
            // 
            // label_ingrese_nickname
            // 
            this.label_ingrese_nickname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ingrese_nickname.AutoSize = true;
            this.label_ingrese_nickname.BackColor = System.Drawing.Color.Transparent;
            this.label_ingrese_nickname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingrese_nickname.ForeColor = System.Drawing.Color.Green;
            this.label_ingrese_nickname.Location = new System.Drawing.Point(203, 382);
            this.label_ingrese_nickname.Name = "label_ingrese_nickname";
            this.label_ingrese_nickname.Size = new System.Drawing.Size(218, 23);
            this.label_ingrese_nickname.TabIndex = 3;
            this.label_ingrese_nickname.Text = "Ingrese su nickname:";
            // 
            // label_ingrese_clave
            // 
            this.label_ingrese_clave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ingrese_clave.AutoSize = true;
            this.label_ingrese_clave.BackColor = System.Drawing.Color.Transparent;
            this.label_ingrese_clave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingrese_clave.ForeColor = System.Drawing.Color.Green;
            this.label_ingrese_clave.Location = new System.Drawing.Point(180, 455);
            this.label_ingrese_clave.Name = "label_ingrese_clave";
            this.label_ingrese_clave.Size = new System.Drawing.Size(240, 23);
            this.label_ingrese_clave.TabIndex = 2;
            this.label_ingrese_clave.Text = "Ingrese su contraseña: ";
            // 
            // label_ingrese_nombre
            // 
            this.label_ingrese_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ingrese_nombre.AutoSize = true;
            this.label_ingrese_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_ingrese_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingrese_nombre.ForeColor = System.Drawing.Color.Green;
            this.label_ingrese_nombre.Location = new System.Drawing.Point(220, 106);
            this.label_ingrese_nombre.Name = "label_ingrese_nombre";
            this.label_ingrese_nombre.Size = new System.Drawing.Size(200, 23);
            this.label_ingrese_nombre.TabIndex = 0;
            this.label_ingrese_nombre.Text = "Ingrese su nombre:";
            // 
            // label_ingrese_edad
            // 
            this.label_ingrese_edad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ingrese_edad.AutoSize = true;
            this.label_ingrese_edad.BackColor = System.Drawing.Color.Transparent;
            this.label_ingrese_edad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingrese_edad.ForeColor = System.Drawing.Color.Green;
            this.label_ingrese_edad.Location = new System.Drawing.Point(245, 183);
            this.label_ingrese_edad.Name = "label_ingrese_edad";
            this.label_ingrese_edad.Size = new System.Drawing.Size(174, 23);
            this.label_ingrese_edad.TabIndex = 1;
            this.label_ingrese_edad.Text = "Ingrese su edad:";
            // 
            // MensajeAcceso
            // 
            this.MensajeAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MensajeAcceso.AutoSize = true;
            this.MensajeAcceso.BackColor = System.Drawing.Color.Transparent;
            this.MensajeAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeAcceso.ForeColor = System.Drawing.Color.Red;
            this.MensajeAcceso.Location = new System.Drawing.Point(371, 343);
            this.MensajeAcceso.Name = "MensajeAcceso";
            this.MensajeAcceso.Size = new System.Drawing.Size(313, 25);
            this.MensajeAcceso.TabIndex = 7;
            this.MensajeAcceso.Text = "Usuario o Contraseña invalidos";
            this.MensajeAcceso.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(375, 481);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(287, 71);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Volver al inicio";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // BotonInicio
            // 
            this.BotonInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInicio.Location = new System.Drawing.Point(375, 380);
            this.BotonInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(287, 71);
            this.BotonInicio.TabIndex = 5;
            this.BotonInicio.Text = "Iniciar Sesion";
            this.BotonInicio.UseVisualStyleBackColor = true;
            this.BotonInicio.Click += new System.EventHandler(this.LoginUserClick);
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordText.Location = new System.Drawing.Point(481, 287);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(265, 22);
            this.PasswordText.TabIndex = 4;
            // 
            // NicknameText
            // 
            this.NicknameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NicknameText.Location = new System.Drawing.Point(481, 229);
            this.NicknameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NicknameText.Name = "NicknameText";
            this.NicknameText.Size = new System.Drawing.Size(265, 22);
            this.NicknameText.TabIndex = 3;
            this.NicknameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NicknameText_KeyDown);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.PasswordLabel.Location = new System.Drawing.Point(285, 287);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(146, 28);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NicknameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.NicknameLabel.Location = new System.Drawing.Point(303, 226);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(128, 28);
            this.NicknameLabel.TabIndex = 0;
            this.NicknameLabel.Text = "Nickname";
            // 
            // Form1
            // 
            this.AcceptButton = this.BotonInicio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel_iniciar_sesion);
            this.Controls.Add(this.button_crear_sesion);
            this.Controls.Add(this.button_iniciar_sesion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form1";
            this.Text = "Spotflex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_iniciar_sesion.ResumeLayout(false);
            this.panel_iniciar_sesion.PerformLayout();
            this.panel_crear_sesion.ResumeLayout(false);
            this.panel_crear_sesion.PerformLayout();
            this.panel_datos_usuario.ResumeLayout(false);
            this.panel_datos_usuario.PerformLayout();
            this.panel_comentarios_cancion.ResumeLayout(false);
            this.panel_comentarios_cancion.PerformLayout();
            this.panel_resultado_busqueda_general.ResumeLayout(false);
            this.panel_resultado_busqueda_general.PerformLayout();
            this.panel_usuario_buscado.ResumeLayout(false);
            this.panel_usuario_buscado.PerformLayout();
            this.panel_info_artista.ResumeLayout(false);
            this.panel_info_artista.PerformLayout();
            this.panelReproducirVideo.ResumeLayout(false);
            this.panelReproducirVideo.PerformLayout();
            this.panel_busqueda_avanzada.ResumeLayout(false);
            this.panel_busqueda_avanzada.PerformLayout();
            this.panel_playlist.ResumeLayout(false);
            this.panel_playlist.PerformLayout();
            this.panel_resultado_busqueda_avanzada.ResumeLayout(false);
            this.panel_resultado_busqueda_avanzada.PerformLayout();
            this.ReproducirPlaylist.ResumeLayout(false);
            this.ReproducirPlaylist.PerformLayout();
            this.panel_favoritos.ResumeLayout(false);
            this.panel_favoritos.PerformLayout();
            this.panelComentarios_Video.ResumeLayout(false);
            this.panelComentarios_Video.PerformLayout();
            this.panel_Eliminar_Playlist.ResumeLayout(false);
            this.panel_de_rankings.ResumeLayout(false);
            this.panel_de_rankings.PerformLayout();
            this.panel_Ranking_de_Canciones.ResumeLayout(false);
            this.panel_Ranking_de_Canciones.PerformLayout();
            this.panelRecomendaciones.ResumeLayout(false);
            this.panelRecomendaciones.PerformLayout();
            this.panel_eliminar_usuario.ResumeLayout(false);
            this.panel_eliminar_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_eliminar_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogoRecomendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroceder_Recomendaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volver_Ranking_video_y_canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Ranking_Video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Ranking_Musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolverDeBorrarPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_favs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tus_favoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volver_a_Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor_de_Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_busqueda_especifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_atras_playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Video_Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Cancion_Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_reproductor_Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Portada_VideoAlReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstrellaVideo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxregresar_desde_reproducirvideo)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reproducri_vid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto_perfil_usuario_buscado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_busqueda_general)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_comentarios_cancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recomendaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_see_ranking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Favoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_playlist)).EndInit();
            this.panel_galeria.ResumeLayout(false);
            this.panel_ajustes.ResumeLayout(false);
            this.panel_ajustes.PerformLayout();
            this.panel_informacion.ResumeLayout(false);
            this.panel_informacion.PerformLayout();
            this.panel_datos_add_cancion.ResumeLayout(false);
            this.panel_datos_add_cancion.PerformLayout();
            this.panel_De_Agregar_Video.ResumeLayout(false);
            this.panel_De_Agregar_Video.PerformLayout();
            this.panel_info_cancion.ResumeLayout(false);
            this.panel_info_cancion.PerformLayout();
            this.panel_fijar_add_cancion.ResumeLayout(false);
            this.panel_fijar_reproducir_cancion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reproducir_cancion)).EndInit();
            this.panel_reproductor_cancion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorCancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_5star_Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_4star_Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3star_Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2star_Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1star_Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_calificacion_cancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vistas_cancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto_cancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAtras_nuevovid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto_NuevoVid)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Volver_de_Borrar_VidYCan)).EndInit();
            this.panel_label_borrar_video.ResumeLayout(false);
            this.panel_label_borrar_video.PerformLayout();
            this.panel_label_borrar_Cancion.ResumeLayout(false);
            this.panel_label_borrar_Cancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back_create_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_portada_cancion)).EndInit();
            this.panel_title_add_cancion.ResumeLayout(false);
            this.panel_title_add_cancion.PerformLayout();
            this.panelAgregarunVid.ResumeLayout(false);
            this.panelAgregarunVid.PerformLayout();
            this.panel_fijar_info_cancion.ResumeLayout(false);
            this.panel_fijar_info_cancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atras_cancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarElVIdeo_enNuevoVId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_song_to_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoconfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back1)).EndInit();
            this.panel_buscador.ResumeLayout(false);
            this.panel_buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_buscar)).EndInit();
            this.panel_secc_video.ResumeLayout(false);
            this.panel_secc_video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_video)).EndInit();
            this.panel_secc_cancion.ResumeLayout(false);
            this.panel_secc_cancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_iniciar_sesion;
        private System.Windows.Forms.Button button_crear_sesion;
        private System.Windows.Forms.Panel panel_iniciar_sesion;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox NicknameText;
        private System.Windows.Forms.Label MensajeAcceso;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel_crear_sesion;
        private System.Windows.Forms.Label label_ingrese_nombre;
        private System.Windows.Forms.Label label_tipo_usuario;
        private System.Windows.Forms.Label label_premium_user;
        private System.Windows.Forms.Label label_ingrese_nickname;
        private System.Windows.Forms.Label label_ingrese_clave;
        private System.Windows.Forms.TextBox textBox_IngreseClave;
        private System.Windows.Forms.TextBox textBox_IngreseNick;
        private System.Windows.Forms.Label error_nickname;
        private System.Windows.Forms.Label error_clave;
        private System.Windows.Forms.Button button_registrar;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.Label label_error_registro;
        private System.Windows.Forms.Panel panel_datos_usuario;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.Label label_NombreUsuario;
        private Label error_edad;
        private Label error_plan_usuario;
        private Label error_plan_sesion;
        private Label error_nombre;
        private Button button_Premium;
        private Button button_Gratuito;
        private Button button_privado;
        private Button button_publico;
        private TextBox textBox_Ingrese_Edad;
        private TextBox textBox_Ingrese_Nombre;
        private Label label_ingrese_edad;
        private Panel panel_galeria;
        private Panel panel_buscador;
        private Button button_buscar_filtro;
        private TextBox textBox_Buscar;
        private PictureBox picture_buscar;
        private PictureBox pictureBox_playlist;
        private Label label_Favoritos;
        private Label label_Playlist_Usuario;
        private PictureBox pictureBox_Favoritos;
        private Label Opciones;
        private Label label_cerrar_sesion;
        private Panel panel_galeria_videos;
        private Panel panel_galeria_canciones;
        private Panel panel_secc_video;
        private Panel panel_secc_cancion;
        private Label label_indicador_Videos;
        private Label label_indicador_Canciones_Disp;
        private Panel panel_info;
        private Panel panel_ajustes;
        private Label label_cambiar_Edad;
        private Label label_cambiar_nombre;
        private Label label_cambiar_password;
        private Label label_cambiar_nickname;
        private Label label_cambiar_datos;
        private Button button_cambiarPrivado;
        private Button button_cambiar_publico;
        private Label label_cambiar_tipoUsuario;
        private TextBox textBox_cambiar_edad;
        private TextBox textBox_cambiar_nombre;
        private TextBox textBox_cambiar_clave;
        private TextBox textBox_cambiarNick;
        private Button button_guardar_cambios;
        private Label label_cambiar_plan;
        private Label label_borrar_usuario;
        private Button button_cambiar_free;
        private Button button_cmabiar_premium;
        private PictureBox pictureBox_Back1;
        private Label label_ver_info;
        private Label label_error_config;
        private Panel panel_informacion;
        private PictureBox pictureBox_backtoconfig;
        private Label label_info_tipo_usuario;
        private Label label_infoPrivate;
        private Label label_info_Nombre;
        private Label label_infoEdad;
        private Label label_infoSeguidores;
        private PictureBox pictureBox_add_video;
        private PictureBox pictureBox_add_music;
        private Panel panel_datos_add_cancion;
        private Label label_add_album_cancion;
        private Label label_add_Artistas_cancion;
        private Label label_add_titulo_cancion;
        private Panel panel_fijar_add_cancion;
        private Panel panel_title_add_cancion;
        private Label label_add_cancion;
        private Label label_add_estudio_cancion;
        private Label label_add_fecha_cancion;
        private Label label_add_descripcion_cancion;
        private DateTimePicker dateTimePicker_add_fecha_publicacion_cancion;
        private TextBox textBox_add_estudio_cancion;
        private TextBox textBox_add_album_artist;
        private TextBox textBox_add_nombre_artista_cancion;
        private TextBox textBox_add_titulo_cancion;
        private Label label_add_directorio_cancion;
        private Label label_add_letra_cancion;
        private Label label1;
        private PictureBox pictureBox_add_portada_cancion;
        private Button button_examinar_directorio;
        private TextBox textBox_add_directorio_cancion;
        private Button button_examinar_letra;
        private TextBox textBox_add_letra_cancion;
        private RichTextBox richTextBox_add_descripcion_cancion;
        private Button button_add_more_artists;
        private CheckBox checkBox_sexo_mujer;
        private CheckBox checkBox_sexo_hombre;
        private TextBox textBox_add_edad_artista;
        private Label label_add_artista_sexo;
        private Label label_add_edad_artista_cancion;
        private PictureBox pictureBox_back_create_music;
        private PictureBox pictureBox_add_song_to_data;
        private Label label_error_add_artista;
        private TextBox textBox_add_generos_cancion;
        private Label label_add_genero;
        private Panel panel_De_Agregar_Video;
        private Label lblTitulo_vid;
        private Label lblDirector_vid;
        private CheckBox checkBoxM_direcvid;
        private CheckBox checkbtnHdirec_vid;
        private TextBox textBoxEdadDirector_nuevovid;
        private TextBox textBoxnombreDirector_nuevovid;
        private TextBox textBoxtitulo_nuevovid;
        private Label lblSexo_direc_vid;
        private Label lblEdad_direc_vid;
        private Label lblNombre_direc_vid;
        private Button btnExaminar_nuevovid;
        private PictureBox pictureBoxFoto_NuevoVid;
        private TextBox textBoxDirecorio_nuevovid;
        private RichTextBox richTextBoxDescripcion_Nuevovid;
        private TextBox textBoxGenero_nuevovid;
        private Label lblDirectorio_nuevovid;
        private Label lblPortada_nuevovid;
        private Label lblDescripcion_Nuevovid;
        private Label lblGeneros_nuevovid;
        private CheckBox checkBoxMActores_nuevovid;
        private CheckBox checkBoxHActor_nuevovid;
        private TextBox textBoxEdadActor_nuevovid;
        private TextBox textBoxNombreActor_nuevovid;
        private Label lblSexoActores_nuevovid;
        private Label lblNombreActores_nuevovid;
        private Label lblEdadActores_Nuevovid;
        private Button button1;
        private Label lblActores_nuevoVid;
        private TextBox textBoxEstudio_nuevovid;
        private DateTimePicker dateTimePickerNuevoVid;
        private Label lblFechaPublicacionNuevoVid;
        private Label lblEstudio_nuevovid;
        private Button btnAñadirOtro_direcvid;
        private Panel panelAgregarunVid;
        private Label lblAgregarNuevoVid;
        private Panel panel1;
        private PictureBox pictureboxAtras_nuevovid;
        private PictureBox pictureBoxAgregarElVIdeo_enNuevoVId;
        private Label label_error_add_actor;
        private Label label_error_video_director;
        private Label label_error_add_video;
        private Label label_error_add_cancion;
        private Panel panel_info_cancion;
        private Label label_info_cancion_estudio;
        private Label label_info_cancion_duracion;
        private Label label_info_genero_cancion;
        private Label label_cancion_info_album;
        private Label label_cancion_Artistas;
        private PictureBox pictureBox_foto_cancion;
        private Label label_info_nombre_cancion;
        private Panel panel_fijar_info_cancion;
        private PictureBox pictureBox_atras_cancion;
        private Label label_recomendaciones;
        private Label label_ranking;
        private Label label_visitas_cancion;
        private Label label_calificacion_cancion;
        private PictureBox pictureBox_calificacion_cancion;
        private PictureBox pictureBox_vistas_cancion;
        private Label label_cancion_descripcion;
        private PictureBox pictureBox_reproducir_cancion;
        private Panel panel_fijar_reproducir_cancion;
        private Label label_calificacion;
        private RadioButton radioButton_add_favorito;
        private Button button_add_cola_cancion;
        private Button button_add_coment_cancion;
        private PictureBox pictureBox_5star_Canciones;
        private PictureBox pictureBox_4star_Canciones;
        private PictureBox pictureBox_3star_Canciones;
        private PictureBox pictureBox_2star_Canciones;
        private PictureBox pictureBox_1star_Canciones;
        private PictureBox pictureBox_download;
        private Panel panel2;
        private Panel panel_reproductor_cancion;
        private AxWMPLib.AxWindowsMediaPlayer ReproductorCancion;
        private Label label_mensaje_cancion_descargada;
        private Label label_size_cancion;
        private PictureBox pictureBox_salir;

        private Label BorrarVidYCan;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;

        private PictureBox pictureBox_recomendaciones;
        private PictureBox pictureBox_see_ranking;
        private Label lblEjemploVideo;
        private Label lblEjemploCanciones;
        private Panel panel_comentarios_cancion;
        private Button button_comentar_cancion;
        private RichTextBox richTextBox_caja_de_comentarios;
        private Label label_subtitulo_comentarios_Cancion;
        private PictureBox pictureBox_atras_comentarios_cancion;
        private Panel panel_resultado_busqueda_general;
        private Label label_resultados_busquedas_general;
        private PictureBox pictureBox_atras_busqueda_general;
        private Panel panel_usuario_buscado;
        private Label label_info_usuario;
        private Button button_seguir_usuario;
        private Label label_seguidores;
        private Label label_nickname_usuario;
        private PictureBox pictureBox_foto_perfil_usuario_buscado;
        private PictureBox pictureBox1;
        private Label label_archivos_subidos_por_usuario;
        private Panel panel_info_artista;
        private Label label_info_edad_Artista;
        private Label label_info_ocupacion_artista;
        private Label label_info_nombre_artista;
        private PictureBox pictureBox2;
        private Label label_trabajo_artistas;
        private Button button_seguir_artista;
        private Label label_info_artista_seguidores;
        private Panel panelReproducirVideo;
        private PictureBox pictureBoxregresar_desde_reproducirvideo;
        private PictureBox pictureBox_Reproducri_vid;
        private PictureBox pictureBoxEstrellaVideo5;
        private PictureBox pictureBoxEstrellaVideo4;
        private PictureBox pictureBoxEstrellaVideo3;
        private PictureBox pictureBoxEstrellaVideo2;
        private PictureBox pictureBoxEstrellaVideo1;
        private Label lblCalificacion_ReproducirVideo;
        private Button btnAñadirALaCola_ReproducirVideo;
        private Button btn_Comentarios_ReproducirVideo;
        private Label lblDescripcionReproducirVideo;
        private Label lblVisitasReproducirVideo;
        private Label lblNotaReproducirvideo;
        private Label lblDuracionReproducirvideo;
        private Label lblEstudioReproducirVideo;
        private Label lblGeneroReproducirVideo;
        private Label lblActores_reproducirvideo;
        private Label lblDirectores_ReproducirVideo;
        private Label lblTituloDelVideoAReproducir;
        private PictureBox pictureBox_Portada_VideoAlReproducir;
        private RadioButton radioButtonFavoritoNuevoVideo;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel_reproductor_Video;
        private Panel panel7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer ReproductorVideo;
        private PictureBox pictureBox5;
        private Panel panel_busqueda_avanzada;
        private Label label_busqueda_genero_persona;
        private Label label_busqueda_edad_personas;
        private Label label_busqueda_personas_involucradas_nombre;
        private Label label_busqueda_personas_involucradas;
        private Label label_busqueda_palabras_clave_hint;
        private Label label_busqueda_palabras_clave;
        private TextBox textBox_palabras_clave_buscar;
        private CheckBox checkBox_buscar_hombre;
        private Label label_hint_edad_persona;
        private TextBox textBox_edad_personas_buscar;
        private TextBox textBox_nombre_personas_buscar;
        private Label label_hint_nombre_busqueda;
        private Label label_busqueda_duracion;
        private CheckBox checkBox_buscar_mujer;
        private Button button2;
        private Button button_busqueda_or;
        private Label label_hint_genero_busqueda;
        private TextBox textBox_genero_busqueda;
        private Label label_genero_busqueda;
        private Label label_hint_busqueda_duracion;
        private TextBox textBox_buscar_Calidad;
        private Label label_busqueda_calidad;
        private Label label_buscar_hint_duracion;
        private TextBox textBox_buscar_duracion;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Panel panel_playlist;
        private Panel panel_playlist_mostrar;
        private CheckedListBox Check_Videos_agregar_playlist;
        private CheckedListBox Check_Canciones_agregar_playlist;
        private PictureBox Add_Cancion_Playlist;
        private PictureBox Add_Video_Playlist;
        private Label Nombre_Playlist_de_Videos;
        private Label Nombre_Playlist_de_Canciones;
        private TextBox textBox_Nombre_playlist_videos;
        private TextBox textBox_Nombre_playlist_canciones;
        private Panel panel_resultado_busqueda_avanzada;
        private Label label_resultado_busqueda_especifica;
        private PictureBox pictureBox_atras_busqueda_especifica;
        private Panel ReproducirPlaylist;
        private Label label2;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor_de_Playlist;
        private PictureBox picturebox_atras_playlist;
        private PictureBox Volver_a_Playlist;
        private Panel panel_favoritos;
        private Label label_tus_favoritos;
        private PictureBox pictureBox_tus_favoritos;
        private PictureBox pictureBox_atras_favs;
        private Panel panelComentarios_Video;
        private Label labelComentarios_Video;
        private Button buttonComentar_Video;
        private RichTextBox richTextBoxComentar_Video;
        private PictureBox pictureBox9;
        private Label Eliminar_Playlist;
        private Panel panel_Eliminar_Playlist;
        private Panel panel_de_rankings;
        private Panel panel_Ranking_de_Canciones;
        private Panel panel_Mostrar_Ranking_Canciones;
        private Label label_ranking_canciones;
        private PictureBox pictureBox10;
        private Label label3;
        private PictureBox pictureBox12;
        private PictureBox Mostrar_Ranking_Video;
        private Label Musica;
        private PictureBox Mostrar_Ranking_Musica;
        private Label Ranking;
        private PictureBox VolverDeBorrarPlaylist;
        private Panel Mis_Playlist_Eliminar;
        private PictureBox Volver_Ranking_video_y_canciones;
        private Panel panel_label_borrar_video;
        private Label label5;
        private Panel panel_label_borrar_Cancion;
        private Label label4;
        private Panel panel6;
        private Panel panelRecomendaciones;
        private PictureBox pictureBoxRetroceder_Recomendaciones;
        private PictureBox picturelogoRecomendados;
        private Label labelRecomendados;
        private Label labelText4;
        private Label labelText3;
        private Label labelText2;
        private Label labelText1;
        private Label labelText5;
        private Panel panel_eliminar_usuario;
        private PictureBox pictureBox_atras_eliminar_usuario;
        private Label label_eliminar_usuario;
        private PictureBox Volver_de_Borrar_VidYCan;
        private Label label6;
        private TextBox textBox_buscar_ranking;
        private Label label7;
    }
}

