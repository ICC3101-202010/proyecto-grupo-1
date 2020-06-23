using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class ChangePhotoEventArgs : EventArgs
    {
        public string Nickname { get; set; }
        public string PhotoFile { get; set; }
        public string OldPhotoFile { get; set; }
    }
}
