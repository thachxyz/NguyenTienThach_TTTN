using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Image
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Image1 { get; set; }

    public string? ImageName { get; set; }

    public string? Link { get; set; }

    public int? Position { get; set; }

    public string? Title { get; set; }

    public bool? Trash { get; set; }

    public long? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
