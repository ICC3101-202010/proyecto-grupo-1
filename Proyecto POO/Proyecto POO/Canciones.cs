using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Canciones : Multimedia
    {
        private string Letra { get; set; }
        private string GeneroCompositor { get; set; }
        private string GeneroCantante { get; set; }



        private List<string> Cantante = new List<string>();
        private List<string> Compositor = new List<string>();
        private List<string> GeneroMusical = new List<string>();
        private List<string> ComentariosDeLaCancion = new List<string>();



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
            return "El titulo de la cancion es: "+ Titulo  +";Cantada por "+ Cantante + ";La cancion dura "+ Duracion + 
                "\n;publicada por el estudio "+Estudio + ";Publicada en: "+Fecha_publicacion + ";Se a reproducido "+Numero_reproducciones + 
                "\n;Su ranking es "+Ranking;
        }

        public override void agregar_comentarios(string comentario)
        {
            ComentariosDeLaCancion.Add(comentario);
        }

        public string Get_Letra()
        {
            return this.Letra;
        }

        public string Get_Genero_Compositor()
        {
            return this.GeneroCompositor;
        }

        public string Get_Genero_Cantante()
        {
            return this.GeneroCantante;
        }

        public List<string> Get_Cantante()
        {
            return this.Cantante;
        }

        public List<string> Get_Compositor()
        {
            return this.Compositor;
        }

        public List<string> Get_Genero_Musical()
        {
            return this.GeneroMusical;
        }

        public List<string> Get_Comentarios_Cancion()
        {
            return this.ComentariosDeLaCancion;
        }


    }
}
