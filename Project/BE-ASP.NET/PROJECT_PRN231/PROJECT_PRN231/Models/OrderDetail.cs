using System;
using System.Collections.Generic;

namespace PROJECT_PRN231.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Status { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
