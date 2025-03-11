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
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.FullName).IsRequired().HasMaxLength(150);

            builder.HasOne(d => d.DoctorCategory)
                   .WithMany()
                   .HasForeignKey(d => d.DoctorCategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.ApplicationUser)
                   .WithMany()
                   .HasForeignKey(d => d.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
