using System;
using System.Collections.Generic;
using System.Text;

namespace YourProjectName.Domain.Entities;

public class Element:BaseEntity
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int BlockId { get; set; }
    public Block Block { get; set; } = null!;
}
