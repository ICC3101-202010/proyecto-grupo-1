using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    [Serializable()]
    public class Personas
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Sexo { get; set; }
        private string PuestoDeTrabajo { get; set; }
        private int Edad { get; set; }
        private List<Usuario> Seguidores { get; set; }


        public Personas(string nom,string ape ,string sex ,string puesto,int ed)
        {
            Nombre = nom;
            Apellido = ape;
            Sexo = sex;
            PuestoDeTrabajo = puesto;
            Edad = ed;
        }

        public void Seguir(Usuario usu)
        {
            int verificador = 1;
            foreach (Usuario data in Seguidores)
            {
                if (usu.Get_Nickname() == data.Get_Nickname())
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                Seguidores.Add(usu);
            }
            else
            {
                Console.WriteLine("No puedes seguir a esta persona");
            }
        }

        public void Informacion_Persona(List<Video> video, List<Canciones> cancion)
        {
            Console.Clear();
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Puesto de Trabajo: " + PuestoDeTrabajo);
            Console.WriteLine("Trabajos Realizados: ");
            int i = 1;
            foreach(Video data in video)
            {
                foreach(Personas staff in data.Get_Staff())
                {
                    if (Nombre == staff.Get_Name() && Apellido == staff.Get_LastName())
                    {
                        Console.WriteLine(i + " ) " + data.Get_Titulo());
                    }
                }
            }
            foreach (Canciones data in cancion)
            {
                foreach (Personas staff in data.Get_Artistas())
                {
                    if (Nombre == staff.Get_Name() && Apellido == staff.Get_LastName())
                    {
                        Console.WriteLine(i + " ) " + data.Get_Titulo());
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();

        }

        public string Get_Name()
        {
            return Nombre;
        }

        public string Get_LastName()
        {
            return Apellido;
        }

        public string Get_Sex()
        {
            return Sexo;
        }

        public string Get_Puesto()
        {
            return PuestoDeTrabajo;
        }

        public int Get_Edad()
        {
            return Edad;
        }
    }
}
