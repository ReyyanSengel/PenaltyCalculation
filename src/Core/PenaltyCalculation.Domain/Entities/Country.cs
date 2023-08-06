using PenaltyCalculation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Domain.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Currency { get; set; }
        public ICollection<NationalHoliday> NationalHolidays { get; set; }
        

    }
}
