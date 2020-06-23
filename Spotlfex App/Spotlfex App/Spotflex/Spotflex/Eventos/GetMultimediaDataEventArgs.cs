using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class GetMultimediaDataEventArgs : EventArgs
    {
        public List<string> name_songs { get; set; }
        public List<string> path_songs { get; set; }
        public List<string> name_videos { get; set; }
        public List<string> path_videos { get; set; }

    }
}
