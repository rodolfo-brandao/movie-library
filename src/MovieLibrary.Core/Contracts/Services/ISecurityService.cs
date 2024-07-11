using MovieLibrary.Core.Models;

namespace MovieLibrary.Core.Contracts.Services;

/// <summary>
/// A service focused on generating passwords and access tokens (based on the JWT format).
/// </summary>
public interface ISecurityService
{
    (string PasswordHash, string PasswordSalt) CreatePasswordHash(string rawPassword);
    string CreateAccessToken(User user);
    bool ValidatePassword(string rawPassword, string passwordHash, string passwordSalt);
}
