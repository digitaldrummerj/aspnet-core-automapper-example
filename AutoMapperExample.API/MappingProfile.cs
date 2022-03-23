using AutoMapper;

namespace AutoMapperExample;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<WeatherForecast, WeatherForecastViewModel>()
            .ForMember(dest => dest.SummaryText, input => input.MapFrom(i => i.Summary))
            .ReverseMap();
    }
}