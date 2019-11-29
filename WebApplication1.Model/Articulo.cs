using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Model
{
    public class Articulo: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public virtual ICollection<Unidad> Unidades { get; set; }
    }
}
