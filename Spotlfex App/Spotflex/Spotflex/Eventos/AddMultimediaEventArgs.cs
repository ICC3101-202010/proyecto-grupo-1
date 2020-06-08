using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class AddMultimediaEventArgs: EventArgs
    {
        public Canciones Cancion { get; set; }
        public Video Video { get; set; }
        public string user { get; set; }
        public string name_multimedia_file { get; set; }
        public int rank { get; set; }
        public List<string> can_favs { get; set; }
        public List<string> can_foto_favs { get; set; }
        public List<string> vid_favs { get; set; }
        public List<string> vid_foto_favs { get; set; }


        public List<Canciones> can_Reco { get; set; }
        public List<Video> vid_Reco { get; set; }
    }
}
