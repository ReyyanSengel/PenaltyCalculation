using PenaltyCalculation.Application.ViewModels;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.Interfaces.IRepositories
{
    public interface IRegistrationRepository : IGenericRepository<Registration>
    {
        //Task<RegistrationViewModel> CalculateAsync(PreRegistrationViewModel model );
    }
}
