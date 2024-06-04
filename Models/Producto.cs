using System;
using System.Collections.Generic;

namespace EvaluacionMVC.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripción { get; set; }

    public decimal Precio { get; set; }

    public int CantidadEnStock { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
