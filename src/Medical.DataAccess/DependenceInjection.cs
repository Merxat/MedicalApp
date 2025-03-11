using Medical.Core.Entity;
using Medical.DataAccess.Persistence;
using Medical.Shared.Services;
using Medical.Shared.Services.Impl;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Medical.DataAccess
{
    public static class DependenceInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");

            // Database qo‘shish
            services.AddDbContext<DataBaseContext>(options =>
                options.UseNpgsql(connectionString));

            // Identity qo‘shish
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<DataBaseContext>()
                .AddDefaultTokenProviders();

            // Custom servislar qo‘shish
            services.AddScoped<IClaimService, ClaimService>();

            // Authentication va Authorization
            services.AddAuthentication();
            services.AddAuthorization();

            return services;
        }

        public static async Task MigrateDatabaseAsync(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<DataBaseContext>();
            await context.Database.MigrateAsync();

            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            await DatabaseSeed.SeedAsync(userManager, roleManager);
        }
    }
}
