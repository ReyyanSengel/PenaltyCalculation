using Microsoft.Extensions.DependencyInjection;
using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Application.Interfaces.IServices;
using PenaltyCalculation.Infrastructure.Services;

namespace PenaltyCalculation.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
        }
    }
}
            
