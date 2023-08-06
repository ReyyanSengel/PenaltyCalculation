using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PenaltyCalculation.Domain.Common;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Domain.EntityTypeBuilder
{
    public class NationalHoidayTypeBuilder : IEntityTypeConfiguration<NationalHoliday>
    {
        public void Configure(EntityTypeBuilder<NationalHoliday> builder)
        {
            builder.Property(x => x.HolidayName)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(100);

            builder.Property(x => x.Date)
               .IsRequired()
               .HasColumnType("datetime");

        }
    }
}
