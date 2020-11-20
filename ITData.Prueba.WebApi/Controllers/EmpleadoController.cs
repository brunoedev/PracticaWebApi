using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITData.Prueba.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITData.Prueba.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly ApiContext _context;

        public EmpleadoController(ApiContext context)
        {
            this._context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado> GetEmpleado(int id)
        {
            var empleado = _context.Find<Empleado>(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;
        }

        [HttpPost]
        public ActionResult PostEmpleado(Empleado empleado)
        {
            _context.Empleado.Add(empleado);
            var res = _context.SaveChanges();

            if (res == 0)
            {
                return BadRequest("Error");
            }

            return Ok("Registro Correcto");
        }

        [HttpPut]
        public ActionResult PutEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                return BadRequest();
            }

            _context.Entry(empleado).State = EntityState.Modified;

            try
            {
                var res = _context.SaveChanges();

                if (res == 0)
                {
                    return BadRequest();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }

            return Ok();

        }

    }
}
