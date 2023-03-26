using System;
using System.Collections.Generic;

namespace DAO.Entity;

public partial class Employee
{
    public long Id { get; set; }

    public int? Age { get; set; }

    public string? Name { get; set; }
}
