using PenaltyCalculation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Domain.Entities
{
    public class Registration : BaseEntity
    {
        public DateTime CheckedOut { get; set; }
        public DateTime Returned { get; set; }
        public bool QueryPenalty { get; set; }
        public decimal Price { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        
    }
}
