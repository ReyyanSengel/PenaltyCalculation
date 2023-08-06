using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.ViewModels
{
    public class PreRegistrationViewModel
    {
        public int Id { get; set; }
        public DateTime CheckedOut { get; set; }
        public DateTime Returned { get; set; }
        public int CountryId { get; set; }
        
    }
}
