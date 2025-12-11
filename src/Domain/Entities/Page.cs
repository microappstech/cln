using System;
using System.Collections.Generic;
using System.Text;

namespace YourProjectName.Domain.Entities;

public class Page:BaseEntity
{
    public string? Title { get; set; }
    public ICollection<Tab> Tabs { get; set; } = new List<Tab>();
}
