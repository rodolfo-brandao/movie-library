using MovieLibrary.Application.Responses.Users;
using MovieLibrary.Application.Utils;

namespace MovieLibrary.Application.Commands.Users.AuthorizeUser;

public class AuthorizeUserCommand : IRequest<ApiResult<AuthorizedUserResponse>>
{
    public string Username { get; init; }
    public string Password { get; init; }
}
