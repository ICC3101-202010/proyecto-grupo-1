using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class AddComentarioEventArgs : EventArgs
    {
        public Usuario user { get; set; }
        public string comentario { get; set; }

        public string Multimedia_Name { get; set; }
    }
}
