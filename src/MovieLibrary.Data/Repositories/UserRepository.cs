using MovieLibrary.Core.Contracts.Repositories;
using MovieLibrary.Core.Models;
using MovieLibrary.Data.DbContexts;

namespace MovieLibrary.Data.Repositories;

public class UserRepository(MovieLibraryDbContext movieLibraryDbContext)
    : Repository<User>(movieLibraryDbContext), IUserRepository
{
}
