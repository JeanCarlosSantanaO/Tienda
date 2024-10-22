using Tienda.Abstraccion.Repositorio;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.ClienteDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Servicios
{
    public class ServiciosCliente : IServiciosCliente
    {
        private readonly IRepositorioCliente repositorioCliente;

        public ServiciosCliente(IRepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }




        public ClienteDto Create(CrearClienteDto crearClienteDto)
        {
            var cliente = repositorioCliente.Create(crearClienteDto);
            var clientesDto = new ClienteDto
            {

                ClienteId = cliente.ClienteId,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Direccion = cliente.Direccion,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
                Member = cliente.Member,
                ModifiedDateTime = cliente.ModifiedDateTime
            };
            return clientesDto;
        }

        public void Delete(int id)
        {
            repositorioCliente.Delete(id);
        }

        public Cliente GetById(int id)
        {
            return repositorioCliente.GetById(id);
        }

        public List<ClienteDto> GetCliente()
        {
            var clientes = repositorioCliente.GetCliente();
            var clienteDto = new List<ClienteDto>();
            foreach (Cliente cliente in clientes)
            {
                var nclienteDto = new ClienteDto()
                {
                    ClienteId = cliente.ClienteId,
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Direccion = cliente.Direccion,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email,
                    Member = cliente.Member,
                    ModifiedDateTime = cliente.ModifiedDateTime
                };
                clienteDto.Add(nclienteDto);
            }
            return clienteDto;
        }

        public ClienteDto Update(int id, ActualizarClienteDto actualizarClienteDto)
        {
            var cliente= repositorioCliente.Update(id, actualizarClienteDto);
            var clienteDto = new ClienteDto
            {
                ClienteId = cliente.ClienteId,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Direccion = cliente.Direccion,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
                Member = cliente.Member,
                ModifiedDateTime = cliente.ModifiedDateTime
            };
            return clienteDto;
        }
    }
}
