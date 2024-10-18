using Tienda.DTO.FacturaDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Servicios
{
    public interface IServiciosFactura
    {
        List<FacturaDto> GetFactura();
        Factura GetById(int id);
        FacturaDto Create(CrearFacturaDto crearFacturaDto);
        FacturaDto Update(int id,ActualizarFacturaDto actualizarFacturaDto);
        void Delete(int id);
    }
}
