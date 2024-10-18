using Tienda.DTO.DetProductoDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Servicios
{
    public interface IServiciosDetProducto
    {
        List<DetProductoDto> GetDetProducto();
        DetProducto GetById(int id);
        DetProductoDto Create(CrearDetProductoDto crearDetProductoDto);
        DetProductoDto Update(int id,ActualizarDetProductoDto actualizarDetProductoDto);
        void Delete(int id);

    }
}
