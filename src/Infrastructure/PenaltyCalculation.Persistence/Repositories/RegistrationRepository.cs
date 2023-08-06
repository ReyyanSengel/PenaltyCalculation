using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Application.ViewModels;
using PenaltyCalculation.Domain.Entities;
using PenaltyCalculation.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Persistence.Repositories
{
    public class RegistrationRepository : GenericRepository<Registration>, IRegistrationRepository
    {

        public RegistrationRepository(AppDbContext context) : base(context)
        {
        }
        //public Task<RegistrationViewModel> CalculateAsync(B model)
        //{
            
        //}
    }

        

}
