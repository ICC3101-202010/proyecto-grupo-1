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
    class ControladorPlaylist
    {
        List<Playlist> playlists = new List<Playlist>();
        Form1 appform;
        public ControladorPlaylist(Form appform)
        {
            InicioPlayList();
            this.appform = appform as Form1;

            this.appform.SaveData += OnSaveData;
            this.appform.GeneralFindPlaylist += OnGeneralSearchPlaylist;
            this.appform.GeneratePlaylist += OnGeneratePlaylist;
            this.appform.UserPlaylists += OnUserPlaylists;
            this.appform.SaveData += OnSaveData;
            this.appform.get_Playlist += On_get_Playlist;
            this.appform.Delete_Playlist += OnDelete_Playlist;
        }

        public void InicioPlayList()
        {
            string path_play = @System.IO.Directory.GetCurrentDirectory() + "\\Playlist.bin";
            if (File.Exists(path_play))
            {

                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Playlist.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {

                    int p = (int)formatter2.Deserialize(stream2);

                    for (int i = 0; i < p; i++)
                    {

                        Playlist obj = (Playlist)formatter2.Deserialize(stream2);
                        playlists.Add(obj);

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
                    Stream stream = new FileStream("Playlist.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, playlists.Count());
                    for (int i = 0; i < playlists.Count(); i++)
                    {
                        formatter.Serialize(stream, playlists[i]);

                    }
                    stream.Close();
                }

            }
        }
        public List<Playlist> On_get_Playlist(object source, AddPlaylistEventArgs e)
        {
            return playlists;
        }
        public void OnGeneralSearchPlaylist(object source, SearchDataEventArgs e)
        {
            foreach(Playlist data in playlists)
            {
                if (data.Name.ToUpper().Contains(e.palabra_clave.ToUpper()) && data.Priv == false)
                {
                    e.nombre_buscado.Add(data.Name);
                    e.priv_buscadas.Add(data.Priv);
                }
            }
        }
        public void OnGeneratePlaylist(object source, AddPlaylistEventArgs e )
        {
            Playlist play = new Playlist(e.names,e.canciones,e.videos,e.seguidores,e.privado,e.foto);
            playlists.Add(play);
            OnSaveData(appform, new EventArgs());
        }
        public Playlist OnUserPlaylists(object source, AddPlaylistEventArgs e)
        {
            foreach(Playlist play in playlists)
            {
                if(play.Name == e.names)
                {
                    return play;
                }
            }
            return null;

        }
        public void OnDelete_Playlist(object source, AddPlaylistEventArgs e)
        {
            List<Playlist> Remove = new List<Playlist>();
            foreach (Playlist play in playlists)
            {
                if (play.Name == e.names)
                {
                    Remove.Add(play);
                }
            }
            foreach (Playlist play2 in Remove)
            {
                playlists.Remove(play2);
            }

            OnSaveData(appform, new EventArgs());
        }


        public void OnSaveData(object source, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream5 = new FileStream("Playlist.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream5, playlists.Count());
            for (int i = 0; i < playlists.Count(); i++)
            {
                formatter.Serialize(stream5, playlists[i]);
            }
            stream5.Close();
        }
    }
}
