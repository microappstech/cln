using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YourProjectName.Domain.Entities;

public class Profile:BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    private readonly List<UserId> _userIds = new();
    public IReadOnlyCollection<UserId> UserIds => _userIds.AsReadOnly();

    public void AddUser(UserId userId) => _userIds.Add(userId);


}
