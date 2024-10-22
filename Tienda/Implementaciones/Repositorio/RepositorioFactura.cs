using Tienda.Abstraccion.Repositorio;
using Tienda.DTO.FacturaDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Repositorio
{
    public class RepositorioFactura : IRepositorioFactura
    {
        private readonly TiendaContext _context;

        public RepositorioFactura(TiendaContext context)
        {
            _context = context;
        }



        public Factura Create(CrearFacturaDto crearFacturaDto)
        {
            var factura = new Factura
            {
                Cliente = crearFacturaDto.Cliente,
                Total = crearFacturaDto.Total,
                Productos = crearFacturaDto.Productos,
                ModifiedDateTime = crearFacturaDto.ModifiedDateTime
            };
            _context.Facturas.Add(factura);
            _context.SaveChanges();
            return factura;
        }

        public void Delete(int id)
        {
            Factura factura = GetById(id);
            _context.Remove(factura);
            _context.SaveChanges();
        }

        public Factura GetById(int id)
        {
            return _context.Facturas.Where(c => c.FacturaId == id).FirstOrDefault();
        }

        public List<Factura> GetFactura()
        {
            return [.. _context.Facturas];
        }

        public Factura Update(int id, ActualizarFacturaDto actualizarFacturaDto)
        {
            var facturaExiste = GetById(id);

            facturaExiste.Cliente = actualizarFacturaDto.Cliente;
            facturaExiste.Total = actualizarFacturaDto.Total;
            facturaExiste.Productos= actualizarFacturaDto.Productos;
            facturaExiste.ModifiedDateTime=actualizarFacturaDto.ModifiedDateTime;

            _context.Update(facturaExiste);
            _context.SaveChanges();
            var facturaActualizada = GetById(id);
            return facturaActualizada;
        }
    }
}
