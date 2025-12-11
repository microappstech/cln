using System;
using System.Collections.Generic;
using System.Text;

namespace YourProjectName.Domain.Entities;

public class Block:BaseEntity
{
    public string? Content { get; set; }
    public int TabId { get; set; }
    public Tab Tab { get; set; } = null!;
    public ICollection<Element> Elements { get; set; } = new List<Element>();

}
