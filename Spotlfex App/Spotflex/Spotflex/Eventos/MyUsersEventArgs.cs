using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class MyUsersEventArgs : EventArgs
    {
        public List<string> user_name { get; set; }

        public List<string> user_photo { get; set; }
    }
}
