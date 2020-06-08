using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class AddPlaylistEventArgs : EventArgs 
    {
        public string names { get; set; }
        public List<Canciones> canciones {get;set;}
        public List<Video> videos { get; set; }
        public List<Usuario> seguidores { get; set; }
        public bool privado { get; set; }
        public string foto { get; set; }

    }
}
