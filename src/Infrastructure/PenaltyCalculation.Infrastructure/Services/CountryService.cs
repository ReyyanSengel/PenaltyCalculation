using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Application.Interfaces.IServices;
using PenaltyCalculation.Application.Interfaces.IUnitOfWork;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Infrastructure.Services
{
    public class CountryService : GenericService<Country>, ICountryService
    {
        public CountryService(IGenericRepository<Country> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

    }
}
