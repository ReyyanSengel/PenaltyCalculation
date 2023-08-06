using PenaltyCalculation.Application.ViewModels;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.Interfaces.IServices
{
    public interface IRegistrationService : IGenericService<Registration>
    {
        Task<CalculateViewModel> Calculation(CalculateViewModel model);
    }
}
