using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Domain.Seeds
{
    public class NationalHolidaySeedData : IEntityTypeConfiguration<NationalHoliday>
    {
        public void Configure(EntityTypeBuilder<NationalHoliday> builder)
        {
            builder.HasData(
                new NationalHoliday
                {
                    Id = 1,
                    HolidayName = "İşçi Bayramı",
                    Date = new DateTime(2020, 05, 01),
                    CountryId = 1,
                },
                 new NationalHoliday
                 {
                     Id = 2,
                     HolidayName = "Milli Bayram",
                     Date = new DateTime(2020, 06, 19),
                     CountryId = 2,
                 },
                  new NationalHoliday
                  {
                      Id = 3,
                      HolidayName = "Paskalya",
                      Date = new DateTime(2020, 04, 09),
                      CountryId = 3,
                  }
                );

        }
    }


}
