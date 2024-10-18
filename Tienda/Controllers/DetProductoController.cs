using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.DetProductoDTO;

namespace Tienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetProductoController : ControllerBase
    {


        private readonly IServiciosDetProducto serviciosDetProducto;

        public DetProductoController(IServiciosDetProducto servicios)
        {
            serviciosDetProducto = servicios;
        }

        [HttpGet]
        public ActionResult GetDetProducto() 
        {
            var result = serviciosDetProducto.GetDetProducto();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        { 
            var result = serviciosDetProducto.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearDetProductoDto crearDetProductoDto)
        {
            var result = serviciosDetProducto.Create(crearDetProductoDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarDetProductoDto actualizarDetProductoDto)
        {
            var result = serviciosDetProducto.Update(id, actualizarDetProductoDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        { 
            serviciosDetProducto.Delete(id);
            return Ok();
        }




    }
}
