using Microsoft.Extensions.Configuration;

namespace NxDotnetTest.AwesomeLib;

public class WeatherForecastService
{
    private static int ToFahrenheit(int temperatureC) => 32 + (int)(temperatureC / 0.5556);

    private IConfiguration Configuration { get; }

    public WeatherForecastService(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    private static readonly string[] Summaries =
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> GenerateWeatherForecast()
    {
        return Enumerable.Range(1, 5).Select(index =>
            {
                var temperature = Configuration["TemperatureFormat"] switch
                {
                    "C" => Random.Shared.Next(-20, 55),
                    "F" => ToFahrenheit(Random.Shared.Next(-20, 55)),
                    _ => throw new ArgumentOutOfRangeException()
                };
                return new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Temperature = temperature,
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                };
            })
            .ToArray();
    }
}
