using AutoMapper;
using Xunit;

namespace AutoMapperExample.UnitTests;

public class MappingProfileTests
{
    [Fact]
    public void ShouldMapperIsValidWhenInitalized()
    {
        MapperConfiguration mapperConfig = new MapperConfiguration(
           cfg =>
           {
               cfg.AddProfile(new MappingProfile());
           });

        IMapper mapper = new Mapper(mapperConfig);

        mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}