using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Video : Multimedia
    {

        private string Calidad { get; set; }
        private List<string> Actores = new List<string>();
        List<string> Directores = new List<string>();

        public List<string> actores { get => Actores; set => Actores = value; }
        public string calidad { get => Calidad; set => Calidad = value; }

        public Video(int Duracion, string Titulo, string Fecha_Inclusion, List<string> Ranking, string Size, List<string> Genero,
            string Estudio, string Path, string Fecha_publicacion, string Descripcion, int Numero_reproducciones, List<string> Comentarios,
            string Calidad, List<string> Actores, List<string> Directores) : base( Duracion, Titulo,Fecha_Inclusion,
             Ranking, Size, Genero,  Estudio, Path, Fecha_publicacion, Descripcion,Numero_reproducciones, Comentarios)
        {
            this.Calidad = Calidad;
            this.Actores = Actores;
            this.Directores = Directores;
        }


        public string informacion(string objeto)
        {
            return "";
        }

        


    }
}
