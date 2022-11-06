using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Application.Core.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AM.Infrastructure
{
    internal class AMContext : DbContext
    {

        DbSet<Plane> Plane { get; set; }
        DbSet<Flight> Flight { get; set; }
        DbSet<Passenger> Passenger { get; set; }
        DbSet<Staff> Staff { get; set; }
        DbSet<Traveller> Traveller { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new PlaneConfiguration());
            modelbuilder.ApplyConfiguration(new FlightConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
               Initial Catalog=AirPortManagementDb;
                Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void  ConfigureConventions(ModelConfigurationBuilder mcb)
        {
            mcb.Properties<DateTime>().HaveColumnType("datetime2");
        }
    }
}
