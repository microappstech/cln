using System;
using System.Collections.Generic;
using System.Text;
using YourProjectName.Application.Common.Models;

namespace YourProjectName.Application.Profiles.Queries;

public class GetProfilesWithPaginationQuery : IRequest<PaginatedList<ProfileDto>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string SearchString { get; set; } = string.Empty;
    public GetProfilesWithPaginationQuery(int pageNumber, int pageSize, string search)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        SearchString = search;
    }
}
