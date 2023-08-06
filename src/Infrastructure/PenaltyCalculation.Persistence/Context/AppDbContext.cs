using Microsoft.EntityFrameworkCore;
using PenaltyCalculation.Domain.Common;
using PenaltyCalculation.Domain.Entities;
using PenaltyCalculation.Domain.EntityTypeBuilder;
using PenaltyCalculation.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<NationalHoliday> NationalHolidays { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new CountryTypeBuilder())
                .ApplyConfiguration(new NationalHoidayTypeBuilder())
                .ApplyConfiguration(new RegistrationTypeBuilder());
                
                
            modelBuilder
                .ApplyConfiguration(new CountrySeedData())
                .ApplyConfiguration(new NationalHolidaySeedData());
            base.OnModelCreating(modelBuilder);
                

        }
        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    foreach (var item in ChangeTracker.Entries())
        //    {
        //        if (item.Entity is Registration entityReferans)
        //        {
        //            switch (item.State)
        //            {
        //                case EntityState.Added:
        //                    {
        //                        entityReferans.CheckedOut = DateTime.Now;
        //                        entityReferans.Returned = DateTime.Now;
        //                        break;
        //                    }
        //                case EntityState.Modified:
        //                    {
        //                        Entry(entityReferans).Property(x => x.CheckedOut).IsModified = false;
        //                        entityReferans.Returned = DateTime.Now;
        //                        break;
        //                    }
        //            }
        //        }
        //    }
        //        return base.SaveChangesAsync(cancellationToken);
        //    }

            //public override int SaveChanges()
            //{
            //    foreach (var item in ChangeTracker.Entries())
            //    {
            //        if (item.Entity is Registration entityReferans)
            //        {
            //            switch (item.State)
            //            {
            //                case EntityState.Added:
            //                    {
            //                        entityReferans.CheckedOut = DateTime.Now;
            //                        break;
            //                    }
            //                case EntityState.Modified:
            //                    {
            //                        Entry(entityReferans).Property(x => x.CheckedOut).IsModified = false;
            //                        entityReferans.Returned = DateTime.Now;
            //                        break;
            //                    }
            //            }
            //        }
            //    }
            //    return base.SaveChanges();
            //}

        }
}



