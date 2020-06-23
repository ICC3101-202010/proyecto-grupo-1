using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex
{
    [Serializable()]
    public class Personas
    {
        private string nombre;
        private string apellido;
        private string sexo;
        private string puesto_de_trabajo;
        private int edad;
        private List<Usuario> seguidores = new List<Usuario>();

        public Personas(string nombre, string apellido, string sexo, string puesto_de_trabajo, int edad, List<Usuario> seguidores)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Puesto_de_trabajo = puesto_de_trabajo;
            this.Edad = edad;
            this.Seguidores = seguidores;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Puesto_de_trabajo { get => puesto_de_trabajo; set => puesto_de_trabajo = value; }
        public int Edad { get => edad; set => edad = value; }
        public List<Usuario> Seguidores { get => seguidores; set => seguidores = value; }



    }
}
