using System.Linq.Expressions;
using MovieLibrary.Core.Contracts.Repositories;
using MovieLibrary.Core.Models;
using MovieLibrary.Tests.Setup.MockBuilders.Abstract;

namespace MovieLibrary.Tests.Setup.MockBuilders.Repositories;

internal sealed class UserRepositoryMockBuilder : BaseMockBuilder<UserRepositoryMockBuilder, IUserRepository>
{
    /// <summary>
    /// Mocks the 'ExistsAsync()' method.
    /// </summary>
    /// <param name="exists">Defines whether a user exists or not.
    /// Use this parameter to configure the behavior of the mocked
    /// method according to the test scenario.</param>
    public UserRepositoryMockBuilder SetupExistsAsync(bool exists = default)
    {
        Mock.Setup(userRepository => userRepository.ExistsAsync(It.IsAny<Expression<Func<User, bool>>>())).ReturnsAsync(exists);
        return this;
    }
}
