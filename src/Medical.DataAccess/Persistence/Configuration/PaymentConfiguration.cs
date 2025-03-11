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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.TotalPrice)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(p => p.ConsultationPrice)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(p => p.AdminFee)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Appointment)
                   .WithMany()
                   .HasForeignKey(p => p.AppointmentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
