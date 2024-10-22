using Tienda.Abstraccion.Repositorio;
using Tienda.DTO.ProductoDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Repositorio
{
    public class RepositorioProducto :IRepositorioProducto
    {
        private readonly TiendaContext _context;

        public RepositorioProducto(TiendaContext context)
        {
            _context = context;
        }




        public Producto Create(CrearProductoDto crearProductoDto)
        {
            var producto = new Producto
            {
                Nombre = crearProductoDto.Nombre,
                Descripcion = crearProductoDto.Descripcion,
                Categoria = crearProductoDto.Categoria,
                Precio = crearProductoDto.Precio,
                Inventario = crearProductoDto.Inventario,
                Foto = crearProductoDto.Foto,
                ModifiedDateTime = crearProductoDto.ModifiedDateTime,
            };
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return producto;

        }

        public void Delete(int id)
        {
            Producto producto =GetById(id);
            _context.Remove(producto);
            _context.SaveChanges();
        }

        public Producto GetById(int id)
        {
            return _context.Productos.Where(c => c.ProductoId == id).FirstOrDefault();
        }

        public List<Producto> GetProductos()
        {
            return [.. _context.Productos];
        }

        public Producto Update(int id, ActualizarProductoDto actualizarProductoDto)
        {
           var productoExiste =GetById(id);

            productoExiste.Nombre =actualizarProductoDto.Nombre;
            productoExiste.Descripcion=actualizarProductoDto.Descripcion;
            productoExiste.Categoria=actualizarProductoDto.Categoria;
            productoExiste.Precio=actualizarProductoDto.Precio;
            productoExiste.Inventario=actualizarProductoDto.Inventario;
            productoExiste.Foto=actualizarProductoDto.Foto;
            productoExiste.ModifiedDateTime=actualizarProductoDto.ModifiedDateTime;

            _context.Update(productoExiste);
            _context.SaveChanges();
            var productoActualizado =GetById(id);
            return productoActualizado;
        }
    }
}
