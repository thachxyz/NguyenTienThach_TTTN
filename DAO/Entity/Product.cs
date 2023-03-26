using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Product
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Alias { get; set; }

    public string? Detail { get; set; }

    public string NameProduct { get; set; } = null!;

    public double? Price { get; set; }

    public double? SalePrice { get; set; }

    public long? BrandId { get; set; }

    public long? CategoryId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<Image> Images { get; } = new List<Image>();
}
