using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.EntityFrameworkData.Mappings;
using WebApplication1.Model;


namespace WebApplication1.EntityFrameworkData
{
    public class AlmacenesDBContext : DbContext
    {

        public AlmacenesDBContext(DbContextOptions<AlmacenesDBContext> options) : base(options)
        { }

        public new DbSet<T> Set<T>() where T : BaseEntity
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AlmacenMapping());
            modelBuilder.ApplyConfiguration(new ArticuloMapping());
            modelBuilder.ApplyConfiguration(new UnidadMapping());
            modelBuilder.ApplyConfiguration(new DelegacionMapping());

        }

       

    }
}
