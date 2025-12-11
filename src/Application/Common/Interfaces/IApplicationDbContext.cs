using YourProjectName.Domain.Entities;

namespace YourProjectName.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    DbSet<Domain.Entities.Profile> Profiles { get; }
    DbSet<Page> Pages { get; }
    DbSet<Tab> Tabs { get; }
    DbSet<Block> Blocks { get; }
    DbSet<Element> Elements { get; }


    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
