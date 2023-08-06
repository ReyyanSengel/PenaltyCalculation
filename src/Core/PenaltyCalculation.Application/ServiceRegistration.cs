using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PenaltyCalculation.Application.Mapping;
using PenaltyCalculation.Application.Validations;
using PenaltyCalculation.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapProfile));
            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<CalculateViewModel>, RegistrationValidator>();
        }
    }
}
