using Tienda.DTO.ProductoDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Servicios
{
    public interface IServiciosProducto
    {
        List<ProductoDto> GetProducto();
        Producto GetById(int id);
        ProductoDto Create(CrearProductoDto crearProductoDto);
        ProductoDto Update(int id,ActualizarProductoDto actualizarProductoDto);
        void Delete(int id);
    }
}
