using Spotflex.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotflex
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 appform = new Form1();
            ControladorPersona ctrl_persona = new ControladorPersona(appform);
            ControladorCancion ctrl_cancion = new ControladorCancion(appform, ctrl_persona);

            ControladorMultimedia ctrl_multi = new ControladorMultimedia(appform);            
            ControladorPlaylist ctrl_playlist = new ControladorPlaylist(appform);
            ControladorVideo ctrl_video = new ControladorVideo(appform, ctrl_persona);
            ControladorUsuario ctrl_user = new ControladorUsuario(appform, ctrl_persona,ctrl_cancion, ctrl_video);

            Application.Run(appform);

        }
    }
}
