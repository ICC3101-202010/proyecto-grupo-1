using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    [Serializable()]
    public class Video : Multimedia
    {

        private int Calidad { get; set; }
        private List<Personas> PersonaVideo = new List<Personas>();
        


        public Video(int Duracion, string Titulo, string Fecha_Inclusion, List<int> Ranking, long Size, List<string> Genero,
            string Estudio, string CarpetaArchivo, string Fecha_publicacion, string Descripcion, int Numero_reproducciones, List<string> Comentarios,
            int Calidad, List<Personas> PersonaVideo,string Portada, List<Usuario> Seguidores) : base( Duracion, Titulo,Fecha_Inclusion,
             Ranking, Size, Genero,  Estudio, CarpetaArchivo, Fecha_publicacion, Descripcion,Numero_reproducciones, Comentarios,Portada, Seguidores)
        {
            
            this.Calidad = Calidad;
            this.PersonaVideo = PersonaVideo;

        }


        public void informacion()
        {
            string people = "";
            for (int i = 0; i < PersonaVideo.Count(); i++)
            {
                people += PersonaVideo[i].Get_Name() + " " + PersonaVideo[i].Get_LastName()+ ": "+ PersonaVideo[i].Get_Puesto()+" ";
            }
            Console.WriteLine( "El titulo del video es: " + Titulo + "\nPersonal del Video: " + people +
               "\nDuracion del Video: " + Duracion + "\nFecha de publicacion: " + Fecha_publicacion + "\nEstudio : " + Estudio+
                "\nSeguidores" + Seguidores.Count() + "\nReproducciones: " + Numero_reproducciones+ "\nRanking : " + Get_Mean_Tier());
            Console.WriteLine("Los comentarios del video son:");
            for (int i = 0; i < Comentarios.Count(); i++)
            {
                Console.WriteLine(Comentarios[i]);
            }
        }

        public int Get_Calidad()
        {
            return Calidad;
        }

        public List<Personas> Get_Staff()
        {
            return PersonaVideo;
        }




    }
}
