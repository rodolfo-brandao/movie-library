using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MovieLibrary.Core.Models;

namespace MovieLibrary.Data.DbContexts;

[ExcludeFromCodeCoverage]
public sealed class MovieLibraryDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<User> Users { get; set; }

    public MovieLibraryDbContext(DbContextOptions<MovieLibraryDbContext> options) : base(options)
    {
        ChangeTracker.LazyLoadingEnabled = default;
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", isEnabled: true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
