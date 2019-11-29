using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Articulo
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string barcode { get; set; }
        public int id { get; set; }
        public List<Unidad> Unidades { get; set; }
    }
}
