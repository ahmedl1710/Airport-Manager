using AM.Application.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(fk => new { fk.PassengerFk, fk.FlightFk, fk.NumTicket });
            //builder.HasOne(f => f.passenger).WithMany(t)
            
            builder.HasOne(f=>f.flight).WithMany(p => p.tickets).HasForeignKey(f => f.FlightFk);
            //builder.HasOne(f => f.passenger).WithMany(p =>p.tickets)HasForeignKey(f => f.PassengerFk); barra lawej alech
            builder.HasOne(t => t.passenger).WithMany(f => f.tickets).HasForeignKey(f => f.PassengerFk);

        }
    }
}
