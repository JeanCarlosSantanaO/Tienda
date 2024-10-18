using Tienda.DTO.FacturaDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Repositorio
{
    public interface IRepositorioFactura
    {
        List<Factura> GetFactura();
        Factura GetById(int id);
        Factura Create(CrearFacturaDto crearFacturaDto);
        Factura Update(int id, ActualizarFacturaDto actualizarFacturaDto);
        void Delete(int id);
    }
}
