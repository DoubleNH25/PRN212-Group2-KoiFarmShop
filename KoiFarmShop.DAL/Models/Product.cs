using System;
using System.Collections.Generic;

namespace KoiFarmShop.DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int BreedId { get; set; }

    public string Name { get; set; } = null!;

    public int? SupplierId { get; set; }

    public string? Origin { get; set; }

    public string? Gender { get; set; }

    public DateOnly? BirthDay { get; set; }

    public decimal? Size { get; set; }

    public decimal? FeedAmountPerDay { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public byte? Status { get; set; }

    public virtual KoiBreed Breed { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Supplier? Supplier { get; set; }
}
