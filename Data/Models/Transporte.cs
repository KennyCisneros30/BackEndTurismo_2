using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Transporte
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Capacity { get; set; } = null!;

    public string Confort { get; set; } = null!;

    public string Image { get; set; } = null!;

    public decimal Price { get; set; }
}
