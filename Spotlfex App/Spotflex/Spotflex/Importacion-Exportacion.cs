using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.InteropServices;

namespace Spotflex
{
    [Serializable()]
    public class Importacion_Exportacion
    {
        public void Importar_Cancion()
        {

        }

        public void Importar_Video()
        {

        }

        public void Descargar(Canciones cancion)
        {
            string workingDirectory = Environment.CurrentDirectory;
            //string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\DescargasSpotflix3";
            string C = Path.GetDirectoryName(cancion.Carpeta_archivo);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string subdir = @System.IO.Directory.GetCurrentDirectory() + "\\DescargasSpotflix3"; // bla bla
            string subdir2 = @C;
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            string sourceFile = System.IO.Path.Combine(subdir2, @Path.GetFileName(cancion.Carpeta_archivo));
            string destFile = System.IO.Path.Combine(subdir, @Path.GetFileName(cancion.Carpeta_archivo));
            System.IO.File.Copy(sourceFile, destFile, true);
        }
    }
}
