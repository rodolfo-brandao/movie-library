using MovieLibrary.Application.Commands.Users.CreateUser;
using MovieLibrary.Tests.Setup.Fakers.Commands.Users.CreateUser;
using MovieLibrary.Tests.Setup.MockBuilders.Repositories;

namespace MovieLibrary.Tests.Application.Commands.Users.CreateUser;

[Trait(name: "Validator", value: "CreateUserCommand")]
public class CreateUserCommandValidatorTest()
{
    #region Success Cases

    [Fact(DisplayName = "ValidateAsync() - Success case: all command object properties are valid")]
    public async Task ValidateAsync_PassUserCommandWithValidData_ValidationShouldSucceed()
    {
        // Arrange:
        var command = CreateUserCommandFake.Valid();

        var userRepository = UserRepositoryMockBuilder
            .Create()
            .SetupExistsAsync()
            .Build();

        var createUserCommandValidator = new CreateUserCommandValidator(userRepository);

        // Act:
        var sut = await createUserCommandValidator.ValidateAsync(command);

        // Assert:
        sut.Should().NotBeNull().And.BeOfType<ValidationResult>();
        sut.IsValid.Should().BeTrue();
        sut.Errors.Should().BeEmpty();
    }

    #endregion

    #region Failure Cases

    [Fact(DisplayName = "ValidateAsync() - Failure case: User already exists")]
    public async Task ValidateAsync_UserAlreadyExists_ValidationShouldFail()
    {
        // Arrange:
        var command = CreateUserCommandFake.Valid();

        var userRepository = UserRepositoryMockBuilder
            .Create()
            .SetupExistsAsync(exists: true)
            .Build();

        var createUserCommandValidator = new CreateUserCommandValidator(userRepository);

        // Act:
        var sut = await createUserCommandValidator.ValidateAsync(command);

        // Assert:
        sut.Should().NotBeNull().And.BeOfType<ValidationResult>();
        sut.IsValid.Should().BeFalse();
        sut.Errors.Should().NotBeEmpty();
    }

    [Theory(DisplayName = "ValidateAsync() - Failure cases: Command object properties have invalid values")]
    [ClassData(typeof(CreateUserCommandFake))]
    public async Task ValidateAsync_PassCommandObjectWithInvalidData_ValidationShouldFail(CreateUserCommand command)
    {
        // Arrange:
        var userRepository = UserRepositoryMockBuilder
            .Create()
            .SetupExistsAsync()
            .Build();

        var createUserCommandValidator = new CreateUserCommandValidator(userRepository);

        // Act:
        var sut = await createUserCommandValidator.ValidateAsync(command);

        // Assert:
        sut.Should().NotBeNull().And.BeOfType<ValidationResult>();
        sut.IsValid.Should().BeFalse();
        sut.Errors.Should().NotBeEmpty();
    }

    #endregion
}
