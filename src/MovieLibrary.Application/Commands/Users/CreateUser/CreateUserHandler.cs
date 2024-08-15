using MovieLibrary.Application.Responses.Users;
using MovieLibrary.Application.Utils;
using MovieLibrary.Application.Utils.Constants;
using MovieLibrary.Core.Contracts.Factories;
using MovieLibrary.Core.Contracts.Repositories;
using MovieLibrary.Core.Contracts.Services;
using MovieLibrary.Core.Contracts.Units;

namespace MovieLibrary.Application.Commands.Users.CreateUser;

public class CreateUserHandler(IUserRepository userRepository, ISecurityService securityService, IUnitOfWork unitOfWork, IModelFactory modelFactory)
    : IRequestHandler<CreateUserCommand, ApiResult<CreatedUserResponse>>
{
    public async Task<ApiResult<CreatedUserResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult<CreatedUserResponse>();
        var validation = await new CreateUserCommandValidator(userRepository)
        {
            ClassLevelCascadeMode = CascadeMode.Stop
        }.ValidateAsync(request, cancellationToken);

        if (!validation.IsValid)
        {
            apiResult.StatusCode = (int)HttpStatusCode.BadRequest;
            apiResult.ErrorMessage = validation.Errors.First().ErrorMessage;
        }
        else
        {
            var (password, passwordSalt) = securityService.CreatePasswordHash(request.Password);
            var user = modelFactory.CreateUser(
                username: request.Username.ToLower(),
                email: request.Email.ToLower(),
                password: password,
                passwordSalt: passwordSalt,
                role: request.IsAdmin ? AuthorizationRoles.Admin : AuthorizationRoles.User);

            var createdUser = await userRepository.InsertAsync(user);
            _ = await unitOfWork.SaveChangesAsync();
            apiResult.Response = new CreatedUserResponse
            {
                Id = createdUser.Id,
                Username = createdUser.Username,
                Role = createdUser.Role,
                CreatedOn = createdUser.CreatedOn.ToLongDateString()
            };
        }

        return apiResult;
    }
}
