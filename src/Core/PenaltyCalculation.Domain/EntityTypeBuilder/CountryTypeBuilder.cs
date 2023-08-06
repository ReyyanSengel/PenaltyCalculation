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
    public class CountryTypeBuilder:IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x => x.Name)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(256);

            builder.Property(x => x.CountryCode)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(10);

            builder.Property(x => x.Currency)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);


        }
    }
}
