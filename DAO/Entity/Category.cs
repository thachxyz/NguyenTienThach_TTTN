using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Category
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Alias { get; set; }

    public string? CatName { get; set; }

    public bool? Trash { get; set; }

    public long? ParentCategory { get; set; }

    public virtual ICollection<Category> InverseParentCategoryNavigation { get; } = new List<Category>();

    public virtual Category? ParentCategoryNavigation { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
