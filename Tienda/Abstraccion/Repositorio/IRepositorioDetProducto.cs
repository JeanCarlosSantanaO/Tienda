using Tienda.DTO.DetProductoDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Repositorio
{
    public interface IRepositorioDetProducto
    {
        List<DetProducto> GetDetProductos();
        DetProducto GetById(int id);
        DetProducto Create(CrearDetProductoDto crearDetProductoDto);
        DetProducto Update(int id,ActualizarDetProductoDto actualizarDetProductoDto);
        void Delete(int id);
    }
}
