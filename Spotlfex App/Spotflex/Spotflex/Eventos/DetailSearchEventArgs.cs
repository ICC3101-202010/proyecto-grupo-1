using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotflex.Eventos
{
    public class DetailSearchEventArgs : EventArgs
    {
        public List<string> nombres_claves { get; set; }
        public List<string> personas_claves { get; set; }
        public int edad_clave { get; set; }
        public int edad_condition { get; set; }
        public string genero_clave { get; set; }
        public int duration { get; set; }
        public int duration_condition { get; set; }
        public int calidad { get; set; }
        public int calidad_condition { get; set; }
        public List<string> categorias_clave { get; set; }
        public List<string> titulos_encontrados { get; set; }
        public List<string> fotos_encontradas { get; set; }
        public decimal ranking { get; set; }
        public int ranking_condition { get; set; }
    }
}

