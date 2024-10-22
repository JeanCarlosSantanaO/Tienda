using Tienda.Abstraccion.Repositorio;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.FacturaDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Servicios
{
    public class ServiciosFactura : IServiciosFactura
    {
        private readonly IRepositorioFactura repositorioFactura;

        public ServiciosFactura(IRepositorioFactura repositorio)
        {
           repositorioFactura = repositorio;
        }



        public FacturaDto Create(CrearFacturaDto crearFacturaDto)
        {
            var factura = repositorioFactura.Create(crearFacturaDto);
            var facturaDto = new FacturaDto
            {
                Cliente = factura.Cliente,
                Total = factura.Total,
                Productos = factura.Productos,
                ModifiedDateTime = factura.ModifiedDateTime
            };
            return facturaDto;
        }

        public void Delete(int id)
        {
            repositorioFactura.Delete(id);
        }

        public Factura GetById(int id)
        {
           return repositorioFactura.GetById(id);
        }

        public List<FacturaDto> GetFactura()
        {
            var facturas = repositorioFactura.GetFactura();
            var facturaDto = new List<FacturaDto>();
            foreach ( Factura factura in facturas)
            {
                var nfacturaDto = new FacturaDto
                {

                    Cliente = factura.Cliente,
                    Total = factura.Total,
                    Productos = factura.Productos,
                    ModifiedDateTime = factura.ModifiedDateTime
                };
                facturaDto.Add(nfacturaDto);
            }
            return facturaDto;
        }

        public FacturaDto Update(int id, ActualizarFacturaDto actualizarFacturaDto)
        {
           var factura = repositorioFactura.Update(id, actualizarFacturaDto);
            var facturaDto = new FacturaDto
            {
                Cliente = factura.Cliente,
                Total = factura.Total,
                Productos = factura.Productos,
                ModifiedDateTime = factura.ModifiedDateTime
            };
            return facturaDto;
        }
    }
}
