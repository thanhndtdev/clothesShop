using System;
using System.Collections.Generic;

namespace PROJECT_PRN231.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Subtotal { get; set; }

    public string? Size { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
