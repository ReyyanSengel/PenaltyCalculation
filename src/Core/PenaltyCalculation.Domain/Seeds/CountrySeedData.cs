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
    public class CountrySeedData : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Turkey",
                    CountryCode = "111",
                    Currency = "Turk Lirasi"
                },
                new Country
                {
                    Id = 2,
                    Name = "Cezayir",
                    CountryCode = "222",
                    Currency = "Cezayir Dinari"
                },
                new Country
                {
                    Id = 3,
                    Name = "Hollanda",
                    CountryCode = "333",
                    Currency = "Euro"
                });

        }
    }
}
