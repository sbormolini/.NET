using DependencyValidation.WeatherApi;
using DependencyValidation.WeatherApi.Weather;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System.Text;

namespace DependencyValidation.Tests;

public class DependencyTests
{
    private readonly List<(Type ServiceType, Type? ImplType, ServiceLifetime Lifetime)> _descriptors = new()
    {
        (typeof(IWeatherService), typeof(WeatherService), ServiceLifetime.Singleton)
    };

    [TestCase]
    public void RegistrationValidation()
    {
        var app = new WebApplicationFactory<IApiMarker>()
            .WithWebHostBuilder(builder =>
                builder.ConfigureTestServices(serviceCollection =>
                {
                    var services = serviceCollection.ToList();
                    var result = ValidateServices(services);
                    if (!result.Success)
                    {
                        Assert.Fail(result.Message);
                    }

                    Assert.Pass();
                }));

        app.CreateClient();
    }

    private DepedencyAssertionResult ValidateServices(List<ServiceDescriptor> services)
    {
        var searchFailed = false;
        var failedText = new StringBuilder();
        foreach (var descriptor in _descriptors) 
        {
            var match = services.SingleOrDefault(
                s => s.ServiceType == descriptor.ServiceType && 
                     s.Lifetime == descriptor.Lifetime && 
                     s.ImplementationType == descriptor.ImplType);

            if (match is not null)
            {
                continue;
            }

            if (!searchFailed)
            {
                failedText.AppendLine("Failed to find registered sercice for:");
                searchFailed = true;
            }

            failedText.AppendLine($"{descriptor.ServiceType.Name}|{descriptor.ImplType?.Name}|{descriptor.Lifetime}");
        }

        return new DepedencyAssertionResult
        {
            Success = !searchFailed,
            Message = failedText.ToString()
        };
    }

    private class DepedencyAssertionResult
    {
        public required bool Success { get; init; }
        public required string Message { get; init; }
    }
}

