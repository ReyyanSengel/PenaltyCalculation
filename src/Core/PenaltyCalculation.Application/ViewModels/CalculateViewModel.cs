using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.ViewModels
{
    public class CalculateViewModel
    {
        public DateTime CheckedOut { get; set; }
        public DateTime Returned { get; set; }
        public bool QueryPenalty { get; set; }
        public decimal Price { get; set; }
        public int CountryId { get; set; }
    }
}
