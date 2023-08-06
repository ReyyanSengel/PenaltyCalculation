using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Domain.EntityTypeBuilder
{
    public class RegistrationTypeBuilder : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.Property(x => x.CheckedOut)
              .IsRequired()
              .HasColumnType("datetime");

            builder.Property(x => x.Returned)
             .IsRequired()
             .HasColumnType("datetime");

            builder.Property(x => x.QueryPenalty)
             .IsRequired();
             
            builder.Property(x => x.Price)
             .IsRequired()
             .HasColumnType("decimal(18,2)");
        }
    }
}
