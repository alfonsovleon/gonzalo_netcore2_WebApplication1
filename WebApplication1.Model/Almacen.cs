using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Model
{
    public class Almacen: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Capacidad { get; set; }
        public int IdDelegacion { get; set; }
        public virtual Delegacion Delegacion { get; set; }
        public virtual ICollection<Unidad> Unidades { get; set; }
    }
}
