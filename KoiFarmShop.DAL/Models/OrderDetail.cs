using System;
using System.Collections.Generic;

namespace KoiFarmShop.DAL.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public byte? Status { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
    public string StatusDetailDescription
    {
        get
        {
            return Status switch
            {
                0 => "Cancel",
                1 => "Accepted",
                2 => "Pending",
                _ => "Unknown"
            };
        }
    }
}
