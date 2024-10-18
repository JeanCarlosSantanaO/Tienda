using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.FacturaDTO;

namespace Tienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        private readonly IServiciosFactura serviciosFactura;

        public FacturaController(IServiciosFactura servicios)
        {
            serviciosFactura = servicios;

        }


        [HttpGet]
        public IActionResult GetFactura()
        {
            var result = serviciosFactura.GetFactura();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = serviciosFactura.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearFacturaDto crearFacturaDto)
        {
            var result = serviciosFactura.Create(crearFacturaDto);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarFacturaDto actualizarFacturaDto)
        {
            var result = serviciosFactura.Update(id, actualizarFacturaDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            serviciosFactura.Delete(id);
            return Ok();
        }



    }
}
