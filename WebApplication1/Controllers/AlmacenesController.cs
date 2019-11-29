using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class AlmacenesController : ControllerBase
    {

        private readonly ILogger<AlmacenesController> _logger;

        public AlmacenesController(ILogger<AlmacenesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Almacen> Get()
        {
            return new List<Almacen>(){
                new Almacen() { nombre = "algo", codigo = "c1", id = 1 },new Almacen() { nombre = "algo2", codigo = "c2", id = 2 }
                ,new Almacen() { nombre = "algo3", codigo = "c3", id = 3 }
            };
        }
        [HttpGet("{id}")]
        public Almacen Get(int id)
        {
            Almacen model = new Almacen();
            //Comprobar si existe y obtener la informacion
            model.id = 1;
            model.nombre = "algo";
            model.codigo = "c1";
            //
            return model;
        }

        [HttpPost]
        public Almacen Post(Almacen model)
        {
            model.id = 4;
            return model;
        }

        [HttpPut("{id}")]
        public Almacen Put(int id, Almacen model)
        {
            //Comprobar si existe el registro
            Almacen modelPut = new Almacen();
            //Actualizar
            modelPut.id = id;
            modelPut.nombre = model.nombre;
            modelPut.codigo = model.codigo;
            //Retornar registro actualizado            
            return modelPut;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //Comprobar si existe el registro
            Almacen modelDel = new Almacen();
            //Eliminar el registro
            //
            return Ok();
        }
    }
}
