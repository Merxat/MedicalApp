using Medical.Core.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.DataAccess.Persistence
{
    public static class DatabaseSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Admin rolini yaratamiz
            string adminRole = "Admin";
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }

            // Admin foydalanuvchi ma'lumotlari
            var adminUser = new ApplicationUser
            {
                UserName = "admin@medicalup.com",
                Email = "admin@medicalup.com",
                FullName = "Admin User",
                EmailConfirmed = true
            };

            // Agar admin allaqachon mavjud bo'lsa, yangisini yaratmaymiz
            var existingAdmin = await userManager.FindByEmailAsync(adminUser.Email);
            if (existingAdmin == null)
            {
                string adminPassword = "Admin@123"; // Parolni xavfsiz saqlash tavsiya etiladi
                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }
        }
    }
}
