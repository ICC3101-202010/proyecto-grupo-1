using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotflex.Controladores
{
    [Serializable()]
    class ControladorImportacionExportacion
    {
        List<Importacion_Exportacion> impo_expo = new List<Importacion_Exportacion>();

        public ControladorImportacionExportacion(Form appform)
        {

        }
    }
}
