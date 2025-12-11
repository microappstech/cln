using System;
using System.Collections.Generic;
using System.Text;

namespace YourProjectName.Domain.Entities;

public class Tab:BaseEntity
{
    public string? Title { get; set; }
    public Page? Page { get; set; }
    public int PageId { get; set; }
}
