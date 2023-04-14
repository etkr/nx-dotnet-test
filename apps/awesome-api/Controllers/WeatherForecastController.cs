using Microsoft.AspNetCore.Mvc;
using NxDotnetTest.AwesomeLib;

namespace NxDotnetTest.AwesomeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{


    private readonly ILogger<WeatherForecastController> _logger;
    private  WeatherForecastService WeatherForecastService {get;set;}

    public WeatherForecastController(WeatherForecastService weatherForecastService, ILogger<WeatherForecastController> logger)
    {
        WeatherForecastService = weatherForecastService;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return WeatherForecastService.GenerateWeatherForecast();
    }
}
