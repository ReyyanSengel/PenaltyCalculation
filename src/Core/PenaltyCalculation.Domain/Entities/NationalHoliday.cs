 using PenaltyCalculation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Domain.Entities
{
    public class NationalHoliday:BaseEntity
    {
        public string HolidayName { get; set; }
        public DateTime Date { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
