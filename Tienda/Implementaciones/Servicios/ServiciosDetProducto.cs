using Tienda.Abstraccion.Repositorio;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.DetProductoDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Servicios
{
    public class ServiciosDetProducto : IServiciosDetProducto
    {
        private readonly IRepositorioDetProducto repositorioDetProducto;

        public ServiciosDetProducto(IRepositorioDetProducto repositorio)
        {
           repositorioDetProducto = repositorio;
        }




        public DetProductoDto Create(CrearDetProductoDto crearDetProductoDto)
        {
            var detProducto = repositorioDetProducto.Create(crearDetProductoDto);
            var detProductoDto = new DetProductoDto
            {
                Producto=detProducto.Producto,
                Factura=detProducto.Factura,
                Cantidad=detProducto.Cantidad,
                Subtotal=detProducto.Subtotal,
                ModifiedDateTime=detProducto.ModifiedDateTime
            };
            return detProductoDto;
        }

        public void Delete(int id)
        {
            repositorioDetProducto.Delete(id);
        }

        public DetProducto GetById(int id)
        {
            return repositorioDetProducto.GetById(id);
        }

        public List<DetProductoDto> GetDetProducto()
        {
            var detProductos = repositorioDetProducto.GetDetProductos();
            var detProductoDto = new List<DetProductoDto>();
            foreach (DetProducto detProducto in detProductos )
            {
                var ndetProducto = new DetProductoDto()
                {
                    Producto = detProducto.Producto,
                    Factura = detProducto.Factura,
                    Cantidad = detProducto.Cantidad,
                    Subtotal = detProducto.Subtotal,
                    ModifiedDateTime = detProducto.ModifiedDateTime
                };
                detProductoDto.Add(ndetProducto);
            }
            return detProductoDto;
        }

        public DetProductoDto Update(int id, ActualizarDetProductoDto actualizarDetProductoDto)
        {
            var detProducto =  repositorioDetProducto.Update(id, actualizarDetProductoDto);
            var detProductoDto = new DetProductoDto
            {
                Producto = detProducto.Producto,
                Factura = detProducto.Factura,
                Cantidad = detProducto.Cantidad,
                Subtotal = detProducto.Subtotal,
                ModifiedDateTime = detProducto.ModifiedDateTime
            };
            return detProductoDto;
        }
    }
}
