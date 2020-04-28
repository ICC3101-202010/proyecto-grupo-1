using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public abstract class  Multimedia
    {   
        protected int Duracion { get; set; }
        protected string Titulo { get; set; }
        protected string Fecha_Inclusion { get; set; }
        protected string Size { get; set; }
        protected string Estudio { get; set; }
        protected string Path { get; set; }
        protected string Fecha_publicacion { get; set; }
        protected string Descripcion { get; set; }
        protected int Numero_reproducciones { get; set; }
        protected List<string> Comentarios;
        protected List<string> Ranking;
        protected List<string> Genero;


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


        public int Get_Duracion()
        {
            return this.Duracion;
        }

        public string Get_Titulo()
        {
            return this.Titulo;
        }

        public string Get_Fecha_Inclusion()
        {
            return this.Fecha_Inclusion;
        }

        public string Get_Size()
        {
            return this.Size;
        }

        public string Get_Estudio()
        {
            return this.Estudio;
        }

        public string Get_Path()
        {
            return this.Path;
        }

        public string Get_Fecha_Publicacion()
        {
            return this.Fecha_publicacion;
        }

        public string Get_Descripcion()
        {
            return this.Descripcion;
        }

        public int Get_Reproducciones()
        {
            return this.Numero_reproducciones;
        }

        public List<string> Get_Comentarios()
        {
            return this.Comentarios;
        }

        public List<string> Get_Ranking()
        {
            return this.Ranking;
        }

        public List<string> Get_Genero()
        {
            return this.Genero;
        }
    }

}
