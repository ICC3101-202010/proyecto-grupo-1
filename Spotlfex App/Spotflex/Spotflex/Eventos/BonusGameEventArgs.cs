using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class BonusGameEventArgs : EventArgs
    {
        public string name_song { get; set; }
        public string song_url { get; set; }
    }
}
