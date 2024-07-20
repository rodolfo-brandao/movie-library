using MovieLibrary.Core.Contracts.Units;
using MovieLibrary.Data.DbContexts;

namespace MovieLibrary.Data.Units;

public sealed class UnitOfWork(MovieLibraryDbContext movieLibraryDbContext) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync() => await movieLibraryDbContext.SaveChangesAsync();
}
