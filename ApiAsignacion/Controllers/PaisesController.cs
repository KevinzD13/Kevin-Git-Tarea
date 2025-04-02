using ApiAsignacion.Interfaces;
using ApiAsignacion.Models;
using ApiAsignacion.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace ApiAsignacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {

        IPaises registro;

        public PaisesController(IPaises registro)
        {
            this.registro = registro;
        }
        [HttpGet("Mostrar Paises")]
        public IActionResult GetPaises()
        {

            return Ok(registro.MostrarPaises());
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PaisIn paisActualizado)
        {
            string result = registro.ActualizarPais(id, paisActualizado);
            if (result == "País actualizado exitosamente.")
            {
                return Ok(result);
            }
            return NotFound(result);
        }


        [HttpPost]
        public IActionResult Post([FromBody] PaisIn nuevoPais)
        {
            if (nuevoPais == null)
            {
                return BadRequest("El país no puede ser nulo.");
            }

            string result = registro.AgregarPais(nuevoPais);
            if (result == "País agregado exitosamente.")
            {
                return CreatedAtAction(nameof(GetPaises), new { id = nuevoPais.Id }, nuevoPais);
            }

            return BadRequest("No se pudo agregar el país.");
        }
    }

}


