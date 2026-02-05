using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercaditoUTM.src.core.Entities
{
    public class Articulo
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string SKU { get; set; }
        public int Stock { get; set; }
        public string Marca { get; set; }
    }
}
