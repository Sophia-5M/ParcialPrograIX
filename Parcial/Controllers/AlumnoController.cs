using Microsoft.AspNetCore.Mvc;
using Parcial.Models;
using Parcial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {

        // GET: api/<AlumnoController>
        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> Get()
        {
            var clienteService = new AlumnoService();
            {
                var cliente = clienteService.GetClient();
                if (cliente != null)
                {
                    return Ok(cliente);
                }
                return NotFound("Mensaje: There are no clients");
            }
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            var alumnoService = new AlumnoService();
            {
                var alumno = alumnoService.GetClientById(id);
                if (alumno != null)
                {
                    return Ok(alumno);
                }
                return NotFound("Mensaje: There is no student with ID: " + id);
            }
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
