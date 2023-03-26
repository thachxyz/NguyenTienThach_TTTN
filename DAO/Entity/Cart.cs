using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Cart
{
    public long Id { get; set; }

    public long Productid { get; set; }
    public long UserId { get; set; }

    public int Quantity { get; set; }

    public double SubPrice { get; set; }

    public virtual User? User { get; set; }

    public virtual Product Product { get; set; } = null!;
}
