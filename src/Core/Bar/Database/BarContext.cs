using Microsoft.EntityFrameworkCore;

namespace Bar.Database;

internal sealed class BarContext : DbContext
{
    public DbSet<Thing> Ingredients => Set<Thing>();
    public DbSet<Thing> Cocktails => Set<Thing>();

    private readonly string _path;

    public BarContext(string path)
    {
        _path = path;

        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={_path}");
    }
}
