using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Model;

namespace WebApplication1.EntityFrameworkData.Mappings
{
    public class AlmacenMapping: BaseEntityMapping<Almacen>
    {
        public override void Configure(EntityTypeBuilder<Almacen> builder)
        {
            base.Configure(builder);
            builder.Property(almacen => almacen.Code).IsRequired();
            builder.Property(almacen => almacen.Name).IsRequired();
            builder.Property(almacen => almacen.Capacidad).IsRequired();
            builder.HasOne(almacen => almacen.Delegacion).WithMany(delegacion => delegacion.Almacenes).HasForeignKey(almacen => almacen.IdDelegacion);
        }
    }
}
