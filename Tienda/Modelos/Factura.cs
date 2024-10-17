using System;
using System.Collections.Generic;

namespace Tienda.Modelos;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int Cliente { get; set; }

    public decimal Total { get; set; }

    public int Productos { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual Cliente ClienteNavigation { get; set; } = null!;

    public virtual DetProducto ProductosNavigation { get; set; } = null!;
}
