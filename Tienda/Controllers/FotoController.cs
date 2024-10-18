using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.FotoDTO;

namespace Tienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotoController : ControllerBase
    {
        private readonly IServiciosFoto serviciosFoto;

        public FotoController(IServiciosFoto servicios)
        {
            serviciosFoto = servicios;
        }

        [HttpGet]
        public IActionResult GetFoto()
        {
            var result = serviciosFoto.GetFoto();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = serviciosFoto.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearFotoDto crearFotoDto)
        {
            var result = serviciosFoto.Create(crearFotoDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarFotoDto actualizarFotoDto)
        {
            var result = serviciosFoto.Update(id, actualizarFotoDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            serviciosFoto.Delete(id);
            return Ok();
        }


    }
}
