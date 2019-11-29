using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Model;

namespace WebApplication1.Services.Stockcaje
{
    public interface IDelegacionService
    {
        Delegacion AddDelegacion(Delegacion delegacion);
        List<Delegacion> Search(string query, int pageNumber, int pageSize);
    }
}
