using System;
using System.Collections.Generic;
using System.Text;

namespace YourProjectName.Application.Profiles.Queries;

public record ProfileDto(
    int Id,
    string Name,
    string Description,
    DateTime CreatedAt,
    int NbUsers
);
