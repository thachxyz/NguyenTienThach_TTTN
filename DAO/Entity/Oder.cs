using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Oder
{
    public long Id { get; set; }
    public string? ReceiverName {get;set;}

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }   


    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Note { get; set; }

    public int? Total { get; set; }

    public bool? Trash { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; } = new List<Orderdetail>();
}
