using System.Reflection;
using YourProjectName.Application.Common.Interfaces;
using YourProjectName.Domain.Entities;
using YourProjectName.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YourProjectName.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Page> Pages => Set<Page>();
    public DbSet<Tab> Tabs => Set<Tab>();
    public DbSet<Block> Blocks => Set<Block>();
    public DbSet<Element> Elements => Set<Element>();

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
