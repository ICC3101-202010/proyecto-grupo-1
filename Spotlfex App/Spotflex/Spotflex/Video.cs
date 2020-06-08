using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex
{
    [Serializable()]
    public class Video : Multimedia
    {
        private int calidad;
        private List<Personas> persona_video = new List<Personas>();

        public Video(int duracion, string titulo, string fecha_inclusion, long size, string estudio,
            string carpeta_archivo, string fecha_publicacion, string descripcion, string portada, int numero_reproducciones,
            List<Usuario> usuarios_comentan, List<Usuario> usuarios_califican, List<string> comentarios, List<int> ranking,
            List<string> genero, List<Usuario> seguidores, int calidad, List<Personas> persona_video) : base( duracion, titulo, 
            fecha_inclusion, size, estudio, carpeta_archivo, fecha_publicacion, descripcion, 
            portada, numero_reproducciones, usuarios_comentan, usuarios_califican, comentarios, ranking,
            genero, seguidores)
        {
            this.Calidad = calidad;
            this.Persona_video = persona_video;
        }

        public int Calidad { get => calidad; set => calidad = value; }
        public List<Personas> Persona_video { get => persona_video; set => persona_video = value; }


    }
}
