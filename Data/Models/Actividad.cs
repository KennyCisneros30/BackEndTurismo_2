using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Actividad
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Image { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Active { get; set; }
}
