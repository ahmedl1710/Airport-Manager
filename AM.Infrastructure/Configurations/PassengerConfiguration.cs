using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AM.Application.Core.Domain;

namespace AM.Infrastructure.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasDiscriminator<String>("IsTraveller").HasValue<Traveller>("1")
                                                            .HasValue<Staff>("2")
                                                            .HasValue("0");

            builder.OwnsOne(p => p.funame, myname =>
            {
                myname.Property(f => f.FirstName).HasColumnName("passFirstName").HasMaxLength(30);
                myname.Property(f => f.LastName).HasColumnName("passLastName").IsRequired();
            });
           // builder.HasMany(p=>p.tickets).WithOne(t=>t.passenger).HasForeignKey(f => f.PassengerFk); hatta lahna chay


        }
    }
}
