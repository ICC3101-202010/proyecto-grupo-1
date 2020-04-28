using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario user = new Usuario();
            Almacenamiento almacenamiento = new Almacenamiento();
            Importacion_Exportacion impor_expo = new Importacion_Exportacion();

            int numcase = 0;
            while (numcase != 9)
            {

                Console.WriteLine("");
                Console.WriteLine("(1) Ingresar como usuario");
                Console.WriteLine("(2) Crear usuario");
                Console.WriteLine("(9) Salir del programa");
                string respuesta = Console.ReadLine();
                numcase = Convert.ToInt32(respuesta);

                switch (numcase)

                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese su nombre de usuario");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña");
                            string contra = Console.ReadLine();
                            int y = user.comprobarusuario(nom, contra);
                            if (y == 1)
                            {
                                //codigo dentro del programa
                            }
                            else
                                Console.WriteLine("Usuario o contraseña incorrecto");

                                    

                            break;
                        }
                    case 2:
                        {
                            bool boolperfil = false;
                            bool premier = false;
                            Console.WriteLine("Ingrese su nombre");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Ingrese su edad");
                            int edad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese si quiere un perfil publico o privado  (publico/privado)");
                            string perfil = Console.ReadLine();
                            Console.WriteLine("Sera un usuario premium? (si/no)");
                            string premium = Console.ReadLine();
                            Console.WriteLine("Ingrese su nickname");
                            string nick = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña");
                            string contra = Console.ReadLine();
                            if (perfil == "privado")
                                boolperfil = true;
                            if (premium == "si")
                                premier = true;
                            Usuario persona = new Usuario(nom,edad,boolperfil,premier,nick,contra);
                            almacenamiento.AgregarPersona(persona);
                            user.AddUserNick(nick,contra);
                            
                            break;
                        }
                    case 9:
                        {
                            numcase = 9;
                            break;
                        }
                    default:
                        Console.WriteLine("Ingrese opcion valida");
                        break;
                }
            }


        }
    }
}
