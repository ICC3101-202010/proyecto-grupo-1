using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class FollowEventArgs : EventArgs
    {
        public string user_new_follower { get; set; }
        public string user_following { get; set; }
    }
}
