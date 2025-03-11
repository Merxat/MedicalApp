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
    public class PharmacyConfiguration : IEntityTypeConfiguration<Pharmacy>
    {
        public void Configure(EntityTypeBuilder<Pharmacy> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DrugName).IsRequired().HasMaxLength(150);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Volume).IsRequired().HasMaxLength(50);

            builder.HasMany(p => p.PharmacyDetails)
                   .WithOne()
                   .HasForeignKey(pd => pd.PharmacyId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
