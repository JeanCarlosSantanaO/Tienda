namespace Tienda.DTO.FacturaDTO
{
    public class ActualizarFacturaDto
    {
        public int Cliente { get; set; }

        public decimal Total { get; set; }

        public int Productos { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
