using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services.Stockcaje;

namespace WebApplication1.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class DelegacionesController: ControllerBase
    {
        private readonly ILogger<DelegacionesController> _logger;
        private readonly IDelegacionService _delegacionService;

        public DelegacionesController(ILogger<DelegacionesController> logger, IDelegacionService delegacionService)
        {
            _logger = logger;
            _delegacionService = delegacionService;
        }

        [HttpGet]
        public IEnumerable<Delegacion> Get(string querytext, int pagesize, int pagenumber)
        {
            var delegaciones = _delegacionService.Search(querytext, pagenumber, pagesize);
            List<Delegacion> result = delegaciones.Select(m => new Delegacion()
            {
                codigo = m.Code,
                id = m.Id,
                nombre = m.Name
            }).ToList();
            return result;
        }


    }
}
