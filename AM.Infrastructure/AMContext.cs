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

        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs{ get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
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
