using System;
using System.Collections.Generic;

namespace KoiFarmShop.DAL.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public string? ShippingAddress { get; set; }

    public byte? Status { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();

    public virtual User User { get; set; } = null!;
}
