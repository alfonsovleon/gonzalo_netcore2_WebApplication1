using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public class Delegacion
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int id { get; set; }
        public List<Almacen> Almacenes { get; set; }
    }
}
