using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;

namespace Spotflex
{
    [Serializable()]
    public class Canciones : Multimedia
    {
        private string letra;
        private string album;
        private List<Personas> personas_cancion = new List<Personas>();

        public Canciones(int duracion, string titulo, string fecha_inclusion, long size, string estudio,
            string carpeta_archivo, string fecha_publicacion, string descripcion, string portada, int numero_reproducciones,
            List<Usuario> usuarios_comentan, List<Usuario> usuarios_califican, List<string> comentarios, List<int> ranking,
            List<string> genero, List<Usuario> seguidores, string letra, string album, List<Personas> personasCancion ) : 
            base(duracion, titulo, fecha_inclusion, size, estudio, carpeta_archivo, fecha_publicacion, descripcion,
            portada, numero_reproducciones, usuarios_comentan, usuarios_califican, comentarios, ranking,
            genero, seguidores)
        {
            Letra = letra;
            Album = album;
            Personas_cancion = personasCancion;

        }

        public string Letra { get => letra; set => letra = value; }
        public string Album { get => album; set => album = value; }
        public List<Personas> Personas_cancion { get => personas_cancion; set => personas_cancion = value; }



        public void Descargar_Cancion()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string C = Path.GetDirectoryName(carpeta_archivo);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            string subdir = path + "\\Descargas Spotflix";
            string subdir2 = @C;
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            string sourceFile = System.IO.Path.Combine(subdir2, @Path.GetFileName(carpeta_archivo));
            string destFile = System.IO.Path.Combine(subdir, @Path.GetFileName(carpeta_archivo));
            System.IO.File.Copy(sourceFile, destFile, true);

        }
    }
}
