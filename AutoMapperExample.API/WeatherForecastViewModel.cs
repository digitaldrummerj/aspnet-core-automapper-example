namespace AutoMapperExample;

public class WeatherForecastViewModel
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }

    // left out so that you can see it used the ViewModel
    public string? SummaryText { get; set; }
}
