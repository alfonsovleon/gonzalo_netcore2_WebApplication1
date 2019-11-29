using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Model;

namespace WebApplication1.EntityFrameworkData.Mappings
{
    public class DelegacionMapping: BaseEntityMapping<Delegacion>
    {
        public override void Configure(EntityTypeBuilder<Delegacion> builder)
        {
            base.Configure(builder);
            builder.Property(delegacion => delegacion.Code).IsRequired();
            builder.Property(delegacion => delegacion.Name).IsRequired();            
        }
    }
}
