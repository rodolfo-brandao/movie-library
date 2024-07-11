using MovieLibrary.Core.Contracts.Factories;
using MovieLibrary.Core.Models;

namespace MovieLibrary.Core.Factories;

public sealed class ModelFactory : IModelFactory
{
    public Director CreateDirector(string name, DateOnly dateOfBirth) => new()
    {
        Id = Guid.NewGuid(),
        Name = name,
        DateOfBirth = dateOfBirth,
        CreatedOn = DateTime.UtcNow,
        UpdatedOn = default,
        IsDisabled = default
    };

    public Movie CreateMovie(Guid directorId, string name, string releaseYear, string countryName,
        ushort runtimeInMinutes) => new()
    {
        Id = Guid.NewGuid(),
        DirectorId = directorId,
        Name = name,
        ReleaseYear = releaseYear,
        CountryName = countryName,
        RuntimeInMinutes = runtimeInMinutes,
        CreatedOn = DateTime.UtcNow,
        UpdatedOn = default,
        IsDisabled = default
    };

    public User CreateUser(string username, string email, string password, string passwordSalt, string role) => new()
    {
        Id = Guid.NewGuid(),
        Username = username,
        Email = email,
        Password = password,
        PasswordSalt = passwordSalt,
        Role = role,
        CreatedOn = DateTime.UtcNow,
        UpdatedOn = default,
        IsDisabled = default
    };
}
