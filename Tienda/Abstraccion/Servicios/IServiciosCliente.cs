using Tienda.DTO.ClienteDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Servicios
{
    public interface IServiciosCliente
    {
        List<ClienteDto> GetCliente();
        Cliente GetById(int id);
        ClienteDto Create(CrearClienteDto crearClienteDto);
        ClienteDto Update(int id,ActualizarClienteDto actualizarClienteDto);
        void Delete(int id);
    }
}
