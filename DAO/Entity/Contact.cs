﻿using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Contact
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? CreatedBy { get; set; }

    public bool? Status { get; set; }

    public long? UpdatedBy { get; set; }

    public string? Content { get; set; }

    public int? Email { get; set; }

    public string? Title { get; set; }

    public bool? Trash { get; set; }
}
