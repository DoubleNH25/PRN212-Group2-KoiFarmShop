using System;
using System.Collections.Generic;

namespace KoiFarmShop.DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Role { get; set; }

    public byte? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();
}
