using Tienda.Abstraccion.Repositorio;
using Tienda.DTO.ClienteDTO;
using Tienda.DTO.DetProductoDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Repositorio
{
    public class RepositorioDetProducto : IRepositorioDetProducto
    {

        private readonly TiendaContext _context;

        public RepositorioDetProducto(TiendaContext context)
        {
            _context = context;
        }




        public DetProducto Create(CrearDetProductoDto crearDetProductoDto)
        {
            var detProducto = new DetProducto
            {
                Producto =crearDetProductoDto.Producto,
                Factura =crearDetProductoDto.Factura,
                Cantidad =crearDetProductoDto.Cantidad,
                Subtotal =crearDetProductoDto.Subtotal,
                ModifiedDateTime =crearDetProductoDto.ModifiedDateTime
            };
            _context.DetProductos.Add(detProducto); 
            _context.SaveChanges();
            return detProducto;
        }

        public void Delete(int id)
        {
            DetProducto detProducto = GetById(id);
            _context.Remove(detProducto);
            _context.SaveChanges();

        }

        public DetProducto GetById(int id)
        {
            return _context.DetProductos.Where(c => c.DetProductoId == id).FirstOrDefault();
        }

        public List<DetProducto> GetDetProductos()
        {
           return [.. _context.DetProductos];
        }

        public DetProducto Update(int id, ActualizarDetProductoDto actualizarDetProductoDto)
        {
            var detProductoExiste = GetById(id);

            detProductoExiste.Producto = actualizarDetProductoDto.Producto;
            detProductoExiste.Factura = actualizarDetProductoDto.Factura;
            detProductoExiste.Cantidad = actualizarDetProductoDto.Cantidad;
            detProductoExiste.Subtotal = actualizarDetProductoDto.Subtotal;
            detProductoExiste.ModifiedDateTime = actualizarDetProductoDto.ModifiedDateTime;

            _context.Update(detProductoExiste);
            _context.SaveChanges();
            var detProductoActualizado = GetById(id);
            return detProductoActualizado;
            
        }
    }
}
