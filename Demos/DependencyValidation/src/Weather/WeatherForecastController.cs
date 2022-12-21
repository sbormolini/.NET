using Microsoft.AspNetCore.Mvc;

namespace DependencyValidation.WeatherApi.Weather;

[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    [HttpGet("weather")]
    public async Task<IActionResult> GetWeatherForecasts()
    {
        var weather = await _weatherService.GetWeatherAsync();
        return Ok(weather);
    }
    
}