using TeamTrack.Business.Services;
using TeamTrack.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Courseproject.Business.Services;

namespace TeamTrack.Business;

public class DIConfiguration
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DtoEntityMapperProfile));
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IJobService, JobService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<ITeamService, TeamService>();
    }
}