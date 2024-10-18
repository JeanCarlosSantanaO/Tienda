using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.ClienteDTO;

namespace Tienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IServiciosCliente serviciosCliente;

        public ClienteController(IServiciosCliente servicios)
        {
            serviciosCliente = servicios;
        }

        [HttpGet]
        public IActionResult GetCliente() 
        {
            var result = serviciosCliente.GetCliente();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create(CrearClienteDto crearClienteDto)
        {
            var result = serviciosCliente.Create(crearClienteDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarClienteDto actualizarClienteDto)
        {
            var result = serviciosCliente.Update(id, actualizarClienteDto);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        { 
            var result = serviciosCliente.GetById(id);
            return Ok(result);
        
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        { 
            serviciosCliente.Delete(id);
            return Ok();
        }




    }
}
