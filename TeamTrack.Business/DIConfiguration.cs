using TeamTrack.Business.Services;
using TeamTrack.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace TeamTrack.Business;

public class DIConfiguration
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DtoEntityMapperProfile));
        services.AddScoped<IAddressService, AddressService>();
    }
}