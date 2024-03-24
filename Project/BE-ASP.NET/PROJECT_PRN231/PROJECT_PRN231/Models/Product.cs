using System;
using System.Collections.Generic;

namespace PROJECT_PRN231.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? CategoryId { get; set; }

    public decimal? Price { get; set; }

    public int? StockQuantity { get; set; }

    public string? Image { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? CategoryNavigation { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
