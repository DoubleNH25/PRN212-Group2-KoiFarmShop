using System;
using System.Collections.Generic;

namespace KoiFarmShop.DAL.Models;

public partial class KoiBreed
{
    public int BreedId { get; set; }

    public string BreedName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
