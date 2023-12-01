using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmn3unidad
{
    internal class Nodo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AñoLanzamiento { get; set; }
        public Nodo Siguiente { get; set; } 
    }
}
