using MovieLibrary.Application.Responses.Users;
using MovieLibrary.Application.Utils;

namespace MovieLibrary.Application.Commands.Users.CreateUser;

public class CreateUserCommand : IRequest<ApiResult<CreatedUserResponse>>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}
