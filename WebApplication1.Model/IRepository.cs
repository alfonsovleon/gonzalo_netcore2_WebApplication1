using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication1.Model
{
    public interface IRepository<T> where T: BaseEntity
    {
        IQueryable<T> Table { get;  }
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
        T GetById(int id);
    }

}
