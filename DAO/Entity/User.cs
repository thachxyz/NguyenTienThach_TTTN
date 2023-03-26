using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class User
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? FullName { get; set; }

    public string? Pass { get; set; }

    public bool? Trash { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
    public virtual ICollection<Cart> Carts { get; set; }
}
