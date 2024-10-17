namespace Tienda.DTO.DetProductoDTO
{
    public class CrearDetProductoDto
    {

        public int Producto { get; set; }

        public int Factura { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
