using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Model
{
    public class Unidad: BaseEntity
    {
        public int IdAlmacen { get; set; }
        public virtual Almacen Almacen { get; set; }
        public int IdArticulo { get; set; }
        public virtual Articulo Articulo { get; set; }
        public int Stock { get; set; }
    }
}
