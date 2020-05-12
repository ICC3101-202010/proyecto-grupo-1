using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Proyecto_POO
{
    [Serializable()]
    public class  Multimedia
    {   
        protected int Duracion { get; set; }
        protected string Titulo { get; set; }
        protected string Fecha_Inclusion { get; set; }
        protected long Size { get; set; }
        protected string Estudio { get; set; }
        protected string CarpetaArchivo { get; set; }

        protected string Fecha_publicacion { get; set; }
        protected string Descripcion { get; set; }
        protected string Portada { get; set; }
        protected int Numero_reproducciones { get; set; }
        protected List<string> Comentarios;
        protected List<int> Ranking;
        protected List<string> Genero;
        protected List<Usuario> Seguidores;
        protected int likes;

        public Multimedia( int Duracion, string Titulo, string Fecha_Inclusion, List<int> Ranking, long Size, List<string> Genero,
            string Estudio, string CarpetaArchivo, string Fecha_publicacion, string Descripcion, int Numero_reproducciones, List<string> Comentarios,string Portada,List<Usuario> Seguidores)
        {

            this.Duracion = Duracion;
            this.Titulo = Titulo;
            this.Fecha_Inclusion = Fecha_Inclusion;
            this.Ranking = Ranking;
            this.Size = Size;
            this.Genero = Genero;
            this.Estudio = Estudio;
            this.CarpetaArchivo = CarpetaArchivo;
            this.Fecha_publicacion = Fecha_publicacion;
            this.Descripcion = Descripcion;
            this.Numero_reproducciones = Numero_reproducciones;
            this.Comentarios = Comentarios;
            this.Portada = Portada;
            this.Seguidores = Seguidores;
        }


        public string Get_Portada()
        {
            return Portada;
        }
        public virtual void agregar_comentarios(string comentario)
        {
            Comentarios.Add(comentario);
        }

        public void seguir(Usuario usu)
        {
            int verificador = 1;
            if (Seguidores.Count() != 0)
            {
                foreach (Usuario data in Seguidores)
                {
                    if (data.Get_Nickname() == usu.Get_Nickname())
                    {
                        verificador = 0;
                    }
                }
            }
            if (verificador == 1)
            {
                Seguidores.Add(usu);
                Console.WriteLine("Ahora sigues a este archivo multimedia");
            }
            else
            {
                Console.WriteLine("Ya sigues a este archivo multimedia");
            }
        }


        public void Ranked( int estrellas)
        {
            this.Get_Ranking().Add(estrellas);

        }

        public decimal Get_Mean_Tier()
        {
            long suma = 0;
            foreach(int data in Ranking)
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

        public long Get_Size()
        {
            return this.Size;
        }

        public string Get_Estudio()
        {
            return this.Estudio;
        }

        public string Get_Carpeta_Archivo()
        {
            return this.CarpetaArchivo;
        }
        
        public void Cambiar_ubicacion(string nuevaubi)
        {
            CarpetaArchivo = nuevaubi;
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

        public List<int> Get_Ranking()
        {
            return this.Ranking;
        }

        public List<string> Get_Genero()
        {
            return this.Genero;
        }

        public List<Usuario> Get_Lista_Seguidores()
        {
            return this.Seguidores;
        }

        public void Sumar_Reproducciones()
        {
            Numero_reproducciones += 1;
        }

    }

}
