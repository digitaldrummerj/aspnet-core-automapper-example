using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private readonly IMapper _mapper;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecastViewModel> Get()
    {
        var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToList();

        return _mapper.Map<List<WeatherForecastViewModel>>(weatherForecasts);
    }
}