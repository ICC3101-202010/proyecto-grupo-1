using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public abstract class  Multimedia
    {   
        protected int Duracion;
        protected string Titulo;
        protected string Fecha_Inclusion;
        protected List<string> Ranking;
        protected string Size;
        protected List<string> Genero;
        protected string Estudio;
        protected string Path;
        protected string Fecha_publicacion;
        protected string Descripcion;
        protected int Numero_reproducciones;
        protected List<string> Comentarios;

        public int duracion { get => Duracion; set => Duracion = value; }
        public string titulo { get => Titulo; set => Titulo = value; }
        public string fecha_inclusion { get => Fecha_Inclusion; set => Fecha_Inclusion = value; }
        public List<string> ranking { get => Ranking; set => Ranking = value; }
        public string size { get => Size; set => Size = value; }
        public List<string> genero { get => Genero; set => Genero = value; }
        public string estudio { get => Estudio; set => Estudio = value; }
        public string path { get => Path; set => Path = value; }
        public string fecha_publicacion { get => Fecha_publicacion; set => Fecha_publicacion = value; }
        public string descripcion { get => Descripcion; set => Descripcion = value; }
        public int numero_reproducciones { get => Numero_reproducciones; set => Numero_reproducciones = value; }
        public List<string> comentarios { get => Comentarios; set => Comentarios = value; }

        public Multimedia(int Duracion, string Titulo, string Fecha_Inclusion, List<string> Ranking, string Size, List<string> Genero,
            string Estudio, string Path, string Fecha_publicacion, string Descripcion, int Numero_reproducciones, List<string> Comentarios)
        {
            this.Duracion = Duracion;
            this.Titulo = Titulo;
            this.Fecha_Inclusion = Fecha_Inclusion;
            this.Ranking = Ranking;
            this.Size = Size;
            this.Genero = Genero;
            this.Estudio = Estudio;
            this.Path = Path;
            this.Fecha_publicacion = Fecha_publicacion;
            this.Descripcion = Descripcion;
            this.Numero_reproducciones = Numero_reproducciones;
            this.Comentarios = Comentarios;

        }

        public virtual void agregar_comentarios(string comentario)
        {

        }

        public virtual void reproduccion(string archivo)
        {

        }
    }
}
