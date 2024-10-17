using System;
using System.Collections.Generic;

namespace Tienda.Modelos;

public partial class DetProducto
{
    public int DetProductoId { get; set; }

    public int Producto { get; set; }

    public int Factura { get; set; }

    public int Cantidad { get; set; }

    public decimal Subtotal { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Producto ProductoNavigation { get; set; } = null!;
}
