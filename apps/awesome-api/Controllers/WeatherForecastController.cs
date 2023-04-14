using Microsoft.AspNetCore.Mvc;
using NxDotnetTest.AwesomeLib;

namespace NxDotnetTest.AwesomeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private WeatherForecastService WeatherForecastService { get; }

    public WeatherForecastController(WeatherForecastService weatherForecastService) =>
        WeatherForecastService = weatherForecastService;

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> GetWeatherForecast() => WeatherForecastService.GenerateWeatherForecast();
}
