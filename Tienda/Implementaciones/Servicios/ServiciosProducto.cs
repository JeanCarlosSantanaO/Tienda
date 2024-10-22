using Tienda.Abstraccion.Repositorio;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.ProductoDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Servicios
{
    public class ServiciosProducto : IServiciosProducto
    {
        private readonly IRepositorioProducto repositorioProducto;

        public ServiciosProducto(IRepositorioProducto repositorio)
        {
            repositorioProducto = repositorio;
        }



        public ProductoDto Create(CrearProductoDto crearProductoDto)
        {
           var producto = repositorioProducto.Create(crearProductoDto);
            var productoDto = new ProductoDto
            {
                Nombre=producto.Nombre,
                Descripcion=producto.Descripcion,
                Categoria=producto.Categoria,
                Precio=producto.Precio,
                Inventario=producto.Inventario,
                Foto=producto.Foto,
                ModifiedDateTime=producto.ModifiedDateTime
            };
            return productoDto;
        }

        public void Delete(int id)
        {
            repositorioProducto.Delete(id);
        }

        public Producto GetById(int id)
        {
            return repositorioProducto.GetById(id);
        }

        public List<ProductoDto> GetProducto()
        {
            var productos = repositorioProducto.GetProductos();
            var productoDto = new List<ProductoDto>();
            foreach (Producto producto in productos)
            {
                var nproducto = new ProductoDto
                {
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    Categoria = producto.Categoria,
                    Precio = producto.Precio,
                    Inventario = producto.Inventario,
                    Foto = producto.Foto,
                    ModifiedDateTime = producto.ModifiedDateTime
                };
                productoDto.Add(nproducto);
            }
            return productoDto;
            
        }

        public ProductoDto Update(int id, ActualizarProductoDto actualizarProductoDto)
        {
            var producto = repositorioProducto.Update(id, actualizarProductoDto);
            var productoDto = new ProductoDto
            {
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Categoria = producto.Categoria,
                Precio = producto.Precio,
                Inventario = producto.Inventario,
                Foto = producto.Foto,
                ModifiedDateTime = producto.ModifiedDateTime
            };
            return productoDto;
        }
    }
}
