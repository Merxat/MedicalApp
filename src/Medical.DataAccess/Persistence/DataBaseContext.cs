using Medical.Core.Entity;
using Medical.Shared.Services;
using Medical.Shared.Services.Impl;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Medical.DataAccess.Persistence
{
    public class DataBaseContext : IdentityDbContext<ApplicationUser>
    {
        private IClaimService? _claimService;
        public DataBaseContext(DbContextOptions<DataBaseContext> options, IClaimService claimService) : base(options)
        {
            _claimService = claimService;
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<Ambulance> Ambulances { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorCategory> DoctorCategories { get; set; }
        public DbSet<DoctorDetails> DoctorDetails { get; set; }
        public DbSet<Geolocation> Geolocations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PersonalCabinet> PersonalCabinets { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<PharmacyDetails> PharmacyDetails { get; set; }
        public DbSet<PharmacyPayment> PharmacyPayments { get; set; }
        public DbSet<VideoZvonok> VideoZvonoks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
