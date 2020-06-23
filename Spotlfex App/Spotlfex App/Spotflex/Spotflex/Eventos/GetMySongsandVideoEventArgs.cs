using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class GetMySongsandVideoEventArgs: EventArgs
    {
        public string artista { get; set; }
    }
}
