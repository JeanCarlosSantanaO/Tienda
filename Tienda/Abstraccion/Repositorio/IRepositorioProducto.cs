using Tienda.DTO.ProductoDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Repositorio
{
    public interface IRepositorioProducto
    {
        List<Producto> GetProductos();
        Producto GetById(int id);
        Producto Create(CrearProductoDto crearProductoDto);
        Producto Update(int id, ActualizarProductoDto actualizarProductoDto);
        void Delete(int id);
    }
}
