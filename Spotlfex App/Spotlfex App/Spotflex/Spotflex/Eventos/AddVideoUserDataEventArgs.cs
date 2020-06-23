using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class AddVideoUserDataEventArgs : EventArgs
    {
        public string Titulo { get; set; }
        public List<string> Nombre_Director { get; set; }
        public List<int> Edad_Director { get; set; }
        public List<string> Genero_Director { get; set; }
        public List<string> Nombre_Actor { get; set; }
        public List<int> Edad_Actor { get; set; }
        public List<string> Genero_Actor { get; set; }
        public string Estudio { get; set; }
        public string Fecha_Publicacion { get; set; }
        public string Fecha_Inclusion { get; set; }
        public int Calidad { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public string Portada_Path { get; set; }
        public string Video_Path { get; set; }
        public long Size { get; set; }
        public List<string> Generos { get; set; }
        public List<Personas> Staff { get; set; }
    }
}
