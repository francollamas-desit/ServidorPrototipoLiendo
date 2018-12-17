using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServidorPrototipoLiendo.Entidades;

namespace ServidorPrototipoLiendo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        // GET api/tareas
        [HttpGet]
        public ActionResult<IEnumerable<Tarea>> Get()
        {

            Tarea t1 = new Tarea { Titulo = "Tarea1", Descripcion = "Desc1", Ubicacion = new Posicion(100.5, 65.8) };
            Tarea t2 = new Tarea { Titulo = "Tarea2", Descripcion = "Desc2", Ubicacion = new Posicion(33.4, 14.8) };
            

            return Ok(new List<object>() {
                new { t1.Titulo, t1.Descripcion, t1.Ubicacion},
                new { t2.Titulo, t2.Descripcion, t2.Ubicacion}
            });
        }
    }
}