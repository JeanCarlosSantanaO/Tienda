namespace Tienda.DTO.FotoDTO
{
    public class FotoDto
    {
        public int FotoId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Url { get; set; } = null!;

        public string Categoria { get; set; } = null!;

        public DateTime ModifiedDateTime { get; set; }
    }
}
