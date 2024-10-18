using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.ProductoDTO;

namespace Tienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IServiciosProducto serviciosProducto;

        public ProductoController(IServiciosProducto servicios)
        {
           serviciosProducto = servicios;
        }

        [HttpGet]
        public IActionResult GetProducto()
        {
            var result = serviciosProducto.GetProducto();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = serviciosProducto.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearProductoDto crearProductoDto)
        {
            var result = serviciosProducto.Create(crearProductoDto);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarProductoDto actualizarProductoDto)
        {
            var result = serviciosProducto.Update(id, actualizarProductoDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            serviciosProducto.Delete(id);
            return Ok();
        }
    }
}
