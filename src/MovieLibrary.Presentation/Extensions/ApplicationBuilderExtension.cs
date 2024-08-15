using System.Diagnostics.CodeAnalysis;

namespace MovieLibrary.Presentation.Extensions;

[ExcludeFromCodeCoverage]
internal static class ApplicationBuilderExtension
{
    public static IApplicationBuilder AddCustomSwaggerUse(this IApplicationBuilder applicationBuilder)
    {
        return applicationBuilder.UseSwagger().UseSwaggerUI(options =>
        {
            options.DefaultModelsExpandDepth(-1);
        });
    }
}
