﻿namespace Tienda.DTO.ProductoDTO
{
    public class ProductoDto
    {
        public int ProductoId { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public string Categoria { get; set; } = null!;

        public decimal Precio { get; set; }

        public int Inventario { get; set; }

        public int Foto { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
