using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Domain.Entities;
using PenaltyCalculation.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PenaltyCalculation.Persistence.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(AppDbContext context) : base(context)
        {
        }
    }




}
