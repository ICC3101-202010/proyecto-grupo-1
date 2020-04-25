using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Canciones : Multimedia
    {
        private string Letra;
        private string GeneroCompositor;
        private string GeneroCantante;
        
        public string letra { get => Letra; set => Letra = value; }
        public string generocompositor { get => GeneroCompositor; set => GeneroCompositor = value; }
        public string generocantente { get => GeneroCantante; set => GeneroCantante = value; }

        private List<string> Cantante = new List<string>();
        private List<string> Compositor = new List<string>();
        private List<string> GeneroMusical = new List<string>();

        public List<string> cantante { get => Cantante; set => Cantante = value; }
        public List<string> compositor { get => Compositor; set => Compositor = value; }
        public List<string> generomusical { get => GeneroMusical; set => GeneroMusical = value; }


        public Canciones(string Letra, string GeneroCompositor, string GeneroCantante,int Duracion, string Titulo, string Fecha_Inclusion, List<string> Ranking, string Size, List<string> Genero,
            string Estudio, string Path, string Fecha_publicacion, string Descripcion, int Numero_reproducciones, List<string> Comentarios,
            List<string> Cantante, List<string> Compositor, List<string> GeneroMusical) : base(Duracion, Titulo, Fecha_Inclusion,
            Ranking, Size, Genero, Estudio, Path, Fecha_publicacion, Descripcion, Numero_reproducciones, Comentarios)
        {
            this.Letra = Letra;
            this.GeneroCompositor = GeneroCompositor;
            this.GeneroCantante = GeneroCantante;
            this.Cantante = Cantante;
            this.Numero_reproducciones = Numero_reproducciones;
            this.GeneroMusical = GeneroMusical;
        }

        public string informacion()
        {
            return " ";
        }
        


    }
}
