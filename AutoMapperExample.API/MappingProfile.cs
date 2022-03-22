using AutoMapper;

namespace AutoMapperExample;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<WeatherForecast, WeatherForecastViewModel>().ReverseMap();
    }
}