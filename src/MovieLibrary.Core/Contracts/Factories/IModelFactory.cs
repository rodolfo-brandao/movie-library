using MovieLibrary.Core.Models;

namespace MovieLibrary.Core.Contracts.Factories;

/// <summary>
/// A factory abstraction for a component that can create model instances.
/// </summary>
public interface IModelFactory
{
    Director CreateDirector(string name, DateOnly dateOfBirth);
    Movie CreateMovie(Guid directorId, string name, string releaseYear, string countryName, ushort runtimeInMinutes);
    User CreateUser(string username, string email, string password, string passwordSalt, string role);
}
