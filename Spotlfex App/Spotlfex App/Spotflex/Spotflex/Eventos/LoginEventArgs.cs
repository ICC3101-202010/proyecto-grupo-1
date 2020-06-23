using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class LoginEventArgs : EventArgs
    {
        //En este evento quiero enviar mi usuario y mi clave
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
