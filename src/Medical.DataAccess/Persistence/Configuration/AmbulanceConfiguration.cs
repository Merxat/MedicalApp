using Medical.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.DataAccess.Persistence.Configuration
{
    public class AmbulanceConfiguration : IEntityTypeConfiguration<Ambulance>
    {
        public void Configure(EntityTypeBuilder<Ambulance> builder)
        {
            builder.HasOne(a => a.ClientLocation)
                   .WithMany()
                   .HasForeignKey(a => a.ClientLocationId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.AmbulanceLocation)
                   .WithMany()
                   .HasForeignKey(a => a.AmbulanceLocationId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
