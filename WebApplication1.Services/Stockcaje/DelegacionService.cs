using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication1.Model;

namespace WebApplication1.Services.Stockcaje
{
    public class DelegacionService : IDelegacionService
    {
        private readonly IRepository<Delegacion> delegacionRepository;
        public DelegacionService(IRepository<Delegacion> delegacionRepository)
        {
            this.delegacionRepository = delegacionRepository;
        }
        public Delegacion AddDelegacion(Delegacion delegacion)
        {
            return delegacionRepository.Add(delegacion);
        }
        public List<Delegacion> Search(string query, int pageNumber, int pageSize)
        {
            return delegacionRepository.Table
                .Where(delegacion => delegacion.Name.Contains(query) || delegacion.Code.Contains(query))
                .OrderByDescending(delegacion => delegacion.UpdateDate)
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
    
}
