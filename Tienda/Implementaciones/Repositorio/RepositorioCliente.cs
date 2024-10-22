using Tienda.Abstraccion.Repositorio;
using Tienda.DTO.ClienteDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Repositorio
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly TiendaContext _context;

        public RepositorioCliente (TiendaContext context)
        {
           _context = context;
        }

        public Cliente Create(CrearClienteDto crearClienteDto)
        {
            var cliente = new Cliente
            {
                Nombre = crearClienteDto.Nombre,
                Apellido = crearClienteDto.Apellido,
                Direccion = crearClienteDto.Direccion,
                Telefono = crearClienteDto.Telefono,
                Email = crearClienteDto.Email,
                Member = crearClienteDto.Member,
                ModifiedDateTime = crearClienteDto.ModifiedDateTime
            };
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public void Delete(int id)
        {
            Cliente cliente = GetById(id);
            _context.Remove(cliente);
            _context.SaveChanges();
        }

        public Cliente GetById(int id)
        {
            return _context.Clientes.Where(c => c.ClienteId == id).FirstOrDefault();
        }

        public List<Cliente> GetCliente()
        {
            return [.. _context.Clientes];
        }

        public Cliente Update(int id, ActualizarClienteDto actualizarClienteDto)
        {
            var clienteExiste = GetById(id);

            clienteExiste.Nombre= actualizarClienteDto.Nombre ?? clienteExiste.Nombre;
            clienteExiste.Apellido=actualizarClienteDto.Apellido ?? clienteExiste.Apellido;
            clienteExiste.Direccion = actualizarClienteDto.Direccion ?? clienteExiste.Direccion;
            clienteExiste.Telefono=actualizarClienteDto.Telefono ?? clienteExiste.Telefono;
            clienteExiste.Email=actualizarClienteDto.Email ?? clienteExiste.Email;

            _context.Update(clienteExiste);
            _context.SaveChanges();
            var clienteActualizado =GetById(id);
            return clienteActualizado;

        }
    }
}
