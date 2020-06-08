using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class SearchDataEventArgs : EventArgs
    {
        public string palabra_clave { get; set; }
        public List<string> nombre_buscado { get; set; }
        public List<string> fotos_buscadas { get; set; }
        public List<bool> priv_buscadas { get; set; }
        public List<string> criterios { get; set; } //Los criterios de busqueda son: palabras clave, persona involucrada (nombre, edad, sexo, trabajo), genero, resolucion, evaluacion (estas ultimas con mayor o menor a)
        //Formato de la lista (string de palabras clave, nombre persona involucrada, edad persona involucrada, sexo persona involucrada, trabajo persona involucrada, genero multimedia, resolucion video, criterio resolucion, ranking, criterio ranking)
    }
}
