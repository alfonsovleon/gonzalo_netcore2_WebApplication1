using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Model;

namespace WebApplication1.EntityFrameworkData.Mappings
{
    public class UnidadMapping:BaseEntityMapping<Unidad>
    {
        public override void Configure(EntityTypeBuilder<Unidad> builder)
        {
            base.Configure(builder);
            builder.Property(unidad => unidad.IdAlmacen).IsRequired();
            builder.Property(unidad => unidad.IdArticulo).IsRequired();
            builder.Property(unidad => unidad.Stock).IsRequired();
            builder.HasOne<Almacen>(unidad => unidad.Almacen).WithMany(almacen => almacen.Unidades).HasForeignKey(unidad => unidad.IdAlmacen);
            builder.HasOne<Articulo>(unidad => unidad.Articulo).WithMany(articulo => articulo.Unidades).HasForeignKey(unidad => unidad.IdArticulo);


        }

      
    }
}
