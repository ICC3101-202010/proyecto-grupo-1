using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Usuario
    {

        private string Nombre;
        private int Edad;
        private bool TipoDeUsuario;
        private bool Premium;
        private string Nickname;
        private string Contraseña;
        private string ColorDeFuente;
        private string ColorDeInterfaz;
        private List<string> GenerosQueSigue = new List<string>();
        private List<string> CantantesQueSigue = new List<string>();
        private List<string> Favoritos = new List<string>();
        private List<string> Recomendaciones = new List<string>();
        private List<string> NombresDeUsuario = new List<string>();
        private List<string> ListaContraseñas = new List<string>();

        public string nombre { get => Nombre; set => Nombre = value; }
        public int edad { get => Edad; set => Edad = value; }
        public bool tipodeusuario { get => TipoDeUsuario; set => TipoDeUsuario = value; }
        public bool premium { get => Premium; set => Premium = value; }
        public string nickname { get => Nickname; set => Nickname = value; }
        public string contraseña { get => Contraseña; set => Contraseña = value; }
        public string colordefuente { get => ColorDeFuente; set => ColorDeFuente = value; }
        public string colordeinterfaz { get => ColorDeInterfaz; set => ColorDeInterfaz = value; }


        public List<string> generosquesigue { get => GenerosQueSigue; set => GenerosQueSigue = value; }
        public List<string> cantantesquesigue { get => CantantesQueSigue; set => CantantesQueSigue = value; }
        public List<string> favoritos { get => Favoritos; set => Favoritos = value; }
        public List<string> recomendaciones { get => Recomendaciones; set => Recomendaciones = value; }
        public List<string> nombresdeusuario { get => NombresDeUsuario; set => NombresDeUsuario = value; }
        public List<string> listacontraseñas { get => ListaContraseñas; set => ListaContraseñas = value; }

        public Usuario(string name,int years,bool usertipe,bool premi, string sobrenombre,string pasword)
        {
            nombre = name;
            edad = years;
            tipodeusuario = usertipe;
            Premium = premi;
            nickname = sobrenombre;
            contraseña = pasword;
        }

        public Usuario()
        {
        }





    }
}
