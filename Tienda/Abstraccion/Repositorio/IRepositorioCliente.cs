using Tienda.DTO.ClienteDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Repositorio
{
    public interface IRepositorioCliente
    {
        List<Cliente> GetCliente();
        Cliente GetById(int id);
        Cliente Create(CrearClienteDto crearClienteDto);
        Cliente Update(int id, ActualizarClienteDto actualizarClienteDto);
        void Delete(int id);
    }
}
