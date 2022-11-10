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
    public class AMContext : DbContext
    {

        public DbSet<Plane> Plane { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Ticket> Passenger { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Traveller> Traveller { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new PlaneConfiguration());
            modelbuilder.ApplyConfiguration(new FlightConfiguration());
            modelbuilder.ApplyConfiguration(new PassengerConfiguration());  
            modelbuilder.ApplyConfiguration(new TicketConfiguration());
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
