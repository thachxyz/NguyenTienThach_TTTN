using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Brand
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Alias { get; set; }

    public string? BrandName { get; set; }

    public bool? Trash { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
