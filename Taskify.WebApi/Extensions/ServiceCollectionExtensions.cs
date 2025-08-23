using Microsoft.OpenApi.Models;

namespace Taskify.WebApi.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Represents the extension methods for configuring OpenAPI in the Taskify Web API.
    /// </summary>
    /// <returns>
    /// The updated IServiceCollection instance.
    /// </returns>
    public static IServiceCollection AddTaskifyWebApiOpenApi(this IServiceCollection services)
    {
        services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer((document, context, concellationToken) =>
            {
                document.Info.Version = "v1";
                document.Info.Title = "Taskify API";
                document.Info.Description = "A Taskify API";
                document.Info.Contact = new OpenApiContact()
                {
                    Name = "Taskify API",
                    Email = "bouchaib@massioui.com",
                    Url = new Uri("https://github.com/Massioui")
                };

                document.Info.License = new OpenApiLicense()
                {
                    Name = "MIT License",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                };

                document.Info.TermsOfService = new Uri("https://opensource.org/licenses/MIT");

                return Task.CompletedTask;
            });
        });

        return services;
    }

    /// <summary>
    /// Represents the extension methods for configuring services in the Taskify Web API.
    /// </summary>
    /// <returns>
    /// The updated IServiceCollection instance.
    /// </returns>
    public static IServiceCollection AddTaskifyWebApiServices(this IServiceCollection services)
    {
        // Register other services here as needed

        return services;
    }   
}