using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Usuario
    {

        private string Nombre { get; set; }
        private int Edad { get; set; }
        private bool TipoDeUsuario { get; set; }
        private bool Premium { get; set; }
        private string Nickname { get; set; }
        private string Contraseña { get; set; }
        private string ColorDeFuente { get; set; }
        private string ColorDeInterfaz { get; set; }
        private List<string> GenerosQueSigue = new List<string>();
        private List<string> CantantesQueSigue = new List<string>();
        private List<string> Favoritos = new List<string>();
        private List<string> Recomendaciones = new List<string>();
        private List<string> NombresDeUsuario = new List<string>();
        private List<string> ListaContraseñas = new List<string>();


        public Usuario(string name,int years,bool usertipe,bool premi, string sobrenombre,string pasword)
        {
            Nombre = name;
            Edad = years;
            TipoDeUsuario = usertipe;
            Premium = premi;
            Nickname = sobrenombre;
            Contraseña = pasword;
        }

        public Usuario()
        {
        }
        public void AddUserNick(string nick, string contraseña)//añade nombre y constraseña a sus listas
        {
            NombresDeUsuario.Add(nick);
            ListaContraseñas.Add(contraseña);
        }

        public int comprobarusuario(string nom, string contra)
        {
            for (int i = 0; i <= NombresDeUsuario.Count(); i++)
            {
                if (NombresDeUsuario[i] == nom && NombresDeUsuario[i] == contra)
                {
                    return 1;
                }
            }
                return 0;
        }
    }
}
