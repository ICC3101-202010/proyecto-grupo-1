using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex
{
    [Serializable()]
    public class Multimedia
    {
        protected int duracion;
        protected string titulo;
        protected string fecha_inclusion;
        protected long size;
        protected string estudio;
        protected string carpeta_archivo;
        protected string fecha_publicacion;
        protected string descripcion;
        protected int numero_reproducciones;
        protected string portada;

        protected List<Usuario> usuarios_comentan;
        protected List<Usuario> usuarios_califican;
        protected List<string> comentarios;
        protected List<int> ranking;
        protected List<string> genero;
        protected List<Usuario> seguidores;

        public Multimedia(int duracion, string titulo, string fecha_inclusion, long size, string estudio, 
            string carpeta_archivo, string fecha_publicacion, string descripcion, string portada, int numero_reproducciones,
            List<Usuario> usuarios_comentan, List<Usuario> usuarios_califican, List<string> comentarios, List<int> ranking,
            List<string> genero, List<Usuario> seguidores)
        {
            this.duracion = duracion;
            this.titulo = titulo;
            this.fecha_inclusion = fecha_inclusion;
            this.size = size;
            this.estudio = estudio;
            this.carpeta_archivo = carpeta_archivo;
            this.fecha_publicacion = fecha_publicacion;
            this.descripcion = descripcion;
            this.portada = portada;
            this.numero_reproducciones = numero_reproducciones;
            this.usuarios_comentan = usuarios_comentan;
            this.usuarios_califican = usuarios_califican;
            this.comentarios = comentarios;
            this.ranking = ranking;
            this.genero = genero;
            this.seguidores = seguidores;
        }

        public int Duracion { get => duracion; set => duracion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Fecha_inclusion { get => fecha_inclusion; set => fecha_inclusion = value; }
        public long Size { get => size; set => size = value; }
        public string Estudio { get => estudio; set => estudio = value; }
        public string Carpeta_archivo { get => carpeta_archivo; set => carpeta_archivo = value; }
        public string Fecha_publicacion { get => fecha_publicacion; set => fecha_publicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Portada { get => portada; set => portada = value; }
        public int Numero_reproducciones { get => numero_reproducciones; set => numero_reproducciones = value; }
        public List<int> Ranking { get => ranking; set => ranking = value; }
        public List<string> Genero { get => genero; set => genero = value; }
        public List<Usuario> Seguidores { get => seguidores; set => seguidores = value; }
        public List<Usuario> Usuarios_califican { get => usuarios_califican; set => usuarios_califican = value; }
        public List<string> Comentarios { get => comentarios; set => comentarios = value; }
        public List<Usuario> Usuarios_comentan { get => usuarios_comentan; set => usuarios_comentan = value; }






        public void Ranked(int estrellas)
        {
            this.Ranking.Add(estrellas);
        }

        public decimal Get_Mean_Tier()
        {
            long suma = 0;
            foreach (int data in Ranking)
            {
                suma += data;
            }
            try
            {
                return suma / Convert.ToDecimal(Ranking.Count());
            }
            catch
            {
                return 0;
            }
        }




    }
}
