using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Link
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Image { get; set; }

    public string? Link1 { get; set; }

    public int? Position { get; set; }

    public bool? Trash { get; set; }
}
