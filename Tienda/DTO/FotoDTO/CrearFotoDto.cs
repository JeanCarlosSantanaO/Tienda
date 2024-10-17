namespace Tienda.DTO.FotoDTO
{
    public class CrearFotoDto
    {

        public string Nombre { get; set; } = null!;

        public string Url { get; set; } = null!;

        public string Categoria { get; set; } = null!;

        public DateTime ModifiedDateTime { get; set; }
    }
}
