using Microsoft.Extensions.DependencyInjection;

namespace NxDotnetTest.AwesomeLib;

public static class DependencyInjection
{
    public static void AddLibServices(this IServiceCollection services)
    {
        services.AddTransient<WeatherForecastService>();
    }
}
