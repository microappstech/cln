using Microsoft.AspNetCore.Identity;

namespace YourProjectName.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public int ProfileId { get; set; }
    YourProjectName.Domain.Entities.Profile? Profile { get; set; }
}
