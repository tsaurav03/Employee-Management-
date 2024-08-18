using System;
using System.Collections.Generic;

namespace Employee_Management.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }
}
