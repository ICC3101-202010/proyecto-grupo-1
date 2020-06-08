using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class AddSongUserDataEventArgs : EventArgs
    {
        public string Titulo { get; set; }
        public string Album { get; set; }
        public List<string> Nombre_Artistas { get; set; }
        public List<int> Edad_Artistas { get; set; }
        public List<string> Genero_Artistas { get; set; }
        public string Estudio { get; set; }
        public string Fecha_Publicacion { get; set; }
        public string Fecha_Inclusion { get; set; }
        public int Calidad { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public string Letra { get; set; }
        public string Portada_Path { get; set; }
        public string Song_Path { get; set; }
        public long Size { get; set; }
        public List<string> Generos { get; set; }
        public List<Personas> Staff { get; set; }

    }
}
