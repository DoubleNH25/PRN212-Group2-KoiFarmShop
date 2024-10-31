using System;
using System.Collections.Generic;

namespace KoiFarmShop.DAL.Models;

public partial class Shipping
{
    public int ShippingId { get; set; }

    public int OrderId { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly? ShippingDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? ShippingMethod { get; set; }

    public string? Status { get; set; }

    public virtual User? Employee { get; set; }

    public virtual Order Order { get; set; } = null!;
}
