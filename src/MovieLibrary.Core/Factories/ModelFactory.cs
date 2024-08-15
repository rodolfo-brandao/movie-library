using MovieLibrary.Core.Contracts.Factories;
using MovieLibrary.Core.Enums;
using MovieLibrary.Core.Models;

namespace MovieLibrary.Core.Factories;

public sealed class ModelFactory : IModelFactory
{
    public Country CreateCountry(string name, string isoAlpha3Code)
    {
        return new Country
        {
            Id = Guid.NewGuid(),
            Name = name,
            IsoAlpha3Code = isoAlpha3Code,
            CreatedOn = DateTime.UtcNow,
            UpdatedOn = default,
            IsDisabled = default
        };
    }

    public Director CreateDirector(string name, DateOnly dateOfBirth)
    {
        return new Director
        {
            Id = Guid.NewGuid(),
            Name = name,
            DateOfBirth = dateOfBirth,
            CreatedOn = DateTime.UtcNow,
            UpdatedOn = default,
            IsDisabled = default
        };
    }

    public Movie CreateMovie(Guid directorId, Guid countryId, string englishName, string originalNane,
        string releaseYear, ushort runtimeInMinutes, Genres genres)
    {
        return new Movie
        {
            Id = Guid.NewGuid(),
            DirectorId = directorId,
            CountryId = countryId,
            EnglishName = englishName,
            OriginalName = originalNane,
            ReleaseYear = releaseYear,
            RuntimeInMinutes = runtimeInMinutes,
            Genres = genres,
            CreatedOn = DateTime.UtcNow,
            UpdatedOn = default,
            IsDisabled = default
        };
    }

    public User CreateUser(string username, string email, string password, string passwordSalt, string role)
    {
        return new User
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
}
