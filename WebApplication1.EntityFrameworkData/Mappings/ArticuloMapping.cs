using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Model;

namespace WebApplication1.EntityFrameworkData.Mappings
{
    public class ArticuloMapping: BaseEntityMapping<Articulo>
    {
        public override void Configure(EntityTypeBuilder<Articulo> builder)
        {
            base.Configure(builder);
            builder.Property(articulo => articulo.Code).IsRequired();
            builder.Property(articulo => articulo.Name).IsRequired();
        }
    }
}
