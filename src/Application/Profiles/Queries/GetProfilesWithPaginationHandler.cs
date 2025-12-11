using System;
using System.Collections.Generic;
using System.Text;
using YourProjectName.Application.Common.Interfaces;
using YourProjectName.Application.Common.Models;

namespace YourProjectName.Application.Profiles.Queries;

public class GetProfilesWithPaginationHandler: IRequestHandler<GetProfilesWithPaginationQuery, PaginatedList<ProfileDto>>
{
    private readonly IApplicationDbContext _context;
    public GetProfilesWithPaginationHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<PaginatedList<ProfileDto>> Handle(GetProfilesWithPaginationQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Profiles.AsQueryable();
        // Apply filtering
        if (!string.IsNullOrEmpty(request.SearchString))
        {
            query = query.Where(p => p.Name.Contains(request.SearchString));
        }
        // Project to ProfileDto
        var projectedQuery = query.Select(p => new ProfileDto(
            p.Id,
            p.Name,
            p.Description,
            p.CreatedAt,
            _context
        ));
        // Return paginated list
        return await PaginatedList<ProfileDto>.CreateAsync(
            projectedQuery,
            request.PageNumber,
            request.PageSize,
            cancellationToken
        );
    }
}
