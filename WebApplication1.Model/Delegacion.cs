using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Model
{
    public class Delegacion : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }        
        public virtual ICollection<Almacen> Almacenes { get; set; }
    }
}
