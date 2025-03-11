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
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Doctor)
                   .WithMany(d => d.Chats)
                   .HasForeignKey(c => c.DoctorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.ApplicationUser)
                   .WithMany()
                   .HasForeignKey(c => c.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
