using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using MovieLibrary.Application.Commands.Users.CreateUser;

namespace MovieLibrary.Application.Extensions;

[ExcludeFromCodeCoverage]
public static class ServiceCollectionExtension
{
    public static IServiceCollection AddCustomMediatR(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(CreateUserHandler).Assembly);
        });
    }
}
