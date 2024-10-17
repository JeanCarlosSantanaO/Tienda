using System;
using System.Collections.Generic;

namespace Tienda.Modelos;

public partial class Foto
{
    public int FotoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public DateTime ModifiedDateTime { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
