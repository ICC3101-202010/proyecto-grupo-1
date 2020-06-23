using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class ChangeUserDataEventArgs : EventArgs
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public int Edad { get; set; }
        public string Name { get; set; }
        public string OldNickname { get; set; }
    }
}
