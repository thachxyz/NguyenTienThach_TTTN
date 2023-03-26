using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Orderdetail
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public bool? Trash { get; set; }

    public long? OrderId { get; set; }

    public virtual Oder? Order { get; set; }
}
