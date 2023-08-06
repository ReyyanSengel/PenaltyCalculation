using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Application.Interfaces.IUnitOfWork;
using PenaltyCalculation.Persistence.Context;
using PenaltyCalculation.Persistence.Repositories;

namespace PenaltyCalculation.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer("name=ConnectionStrings:SqlConnection"));

            services.AddScoped<IUnitOfWork, PenaltyCalculation.Persistence.UnitOfWork.UnitOfWork>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            services.AddScoped<INationalHolidayRepository, NationalHolidayRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
            
