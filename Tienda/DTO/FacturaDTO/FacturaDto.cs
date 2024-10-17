namespace Tienda.DTO.FacturaDTO
{
    public class FacturaDto
    {
        public int FacturaId { get; set; }

        public int Cliente { get; set; }

        public decimal Total { get; set; }

        public int Productos { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
