using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplication1.EntityFrameworkData
{
    public class EFRepository<RepoType> : IRepository<RepoType> where RepoType : BaseEntity
    {
        private readonly AlmacenesDBContext _context;
        private DbSet<RepoType> _entities;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Object context</param>
        public EFRepository(AlmacenesDBContext context)
        {
            this._context = context;
        }

        public RepoType GetById(int id)
        {
            return this.Entities.Find(id);
        }


        public RepoType Add(RepoType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Entities.Add(entity);
            UpdateTimeStamps();
            
            this._context.SaveChanges();
            return entity;
        }
        private void UpdateTimeStamps()
        {
            var createdEntities = _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Added);
            var updatedEntities = _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            foreach (var createdEntity in createdEntities)
            {
                var entity = (BaseEntity)createdEntity.Entity;
                entity.CreateDate = DateTime.UtcNow;
                entity.UpdateDate = DateTime.UtcNow;
            }
            foreach (var updatedEntity in updatedEntities)
            {
                var entity = (BaseEntity)updatedEntity.Entity;
                entity.UpdateDate = DateTime.UtcNow;
            }

        }

        public RepoType Update(RepoType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            UpdateTimeStamps();
            this._context.SaveChanges();
            return entity;
        }


        public void Delete(int id )
        {
            var entity = GetById(id);
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Entities.Remove(entity);

            this._context.SaveChanges();
        }

        public virtual IQueryable<RepoType> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private DbSet<RepoType> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<RepoType>();
                return _entities;
            }
        }

       
    }
}
