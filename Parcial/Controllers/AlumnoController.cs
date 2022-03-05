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
                var cliente = clienteService.GetAlumno();
                if (cliente != null)
                {
                    return Ok(cliente);
                }
                return NotFound("Mensaje: There are no students");
            }
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            var alumnoService = new AlumnoService();
            {
                var alumno = alumnoService.GetAlumnoByID(id);
                if (alumno != null)
                {
                    return Ok(alumno);
                }
                return NotFound("Mensaje: There is no student with ID: " + id);
            }
        }
    }
}
