namespace Tienda.DTO.ClienteDTO
{
    public class ActualizarClienteDto
    {

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string Email { get; set; } = null!;

        public bool Member { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
