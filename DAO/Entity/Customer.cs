using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Customer
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Diachi { get; set; }

    public int? Email { get; set; }

    public string? Phone { get; set; }

    public string? FullName { get; set; }

    public bool? Trash { get; set; }

    public long? OrderId { get; set; }

    public long UserId { get; set; }

    public virtual Oder? Order { get; set; }

    public virtual User User { get; set; } = null!;
}
