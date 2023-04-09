using IdentityOgreniyorum.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityOgreniyorum.Models.Extensions
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder builder)
        {

            // Seed Roles

            List<AppRole> roles = new List<AppRole>()
             {
                 new AppRole { Name = "Admin", NormalizedName = "ADMIN" },
                 new AppRole { Name = "Manager", NormalizedName = "MANAGER" },
                 new AppRole { Name = "User", NormalizedName = "USER" }
             };

            builder.Entity<AppRole>().HasData(roles);

            // -----------------------------------------------------------------------------

            // Seed Users

            var passwordHasher = new PasswordHasher<AppUser>();

            List<AppUser> users = new List<AppUser>()
            {
                new AppUser {
                   FirstName= "Admin",
                   LastName="Admin",
                   Gender = Enums.Gender.erkek,
                   DateOfBirth= DateTime.Now,
                   HiredDate= DateTime.Now,
                   FiredDate = DateTime.Now,
                   UserName = "Admin",
                   NormalizedUserName = "ADMIN",
                   Email = "admin@admin.com",
                   NormalizedEmail = "ADMIN@ADMIN.COM",
                   EmailConfirmed= false,
                   PhoneNumberConfirmed= false,
                   TwoFactorEnabled= false,
                   LockoutEnabled= false
               },
                 new AppUser {
                   FirstName= "Manager",
                   LastName="Manager",
                   Gender = Enums.Gender.kadin,
                   DateOfBirth= DateTime.Now,
                   HiredDate= DateTime.Now,
                   FiredDate = DateTime.Now,
                   UserName = "Manager",
                   NormalizedUserName = "MANAGER",
                   Email = "manager@manager.com",
                   NormalizedEmail = "MANAGER@MANAGER.COM",
                   EmailConfirmed= false,
                   PhoneNumberConfirmed= false,
                   TwoFactorEnabled= false,
                   LockoutEnabled= false
               },
                  new AppUser {
                   FirstName= "User",
                   LastName="User",
                   Gender = Enums.Gender.erkek,
                   DateOfBirth= DateTime.Now,
                   HiredDate= DateTime.Now,
                   FiredDate = DateTime.Now,
                   UserName = "User",
                   NormalizedUserName = "USER",
                   Email = "user@user.com",
                   NormalizedEmail = "USER@USER.COM",
                   EmailConfirmed= false,
                   PhoneNumberConfirmed= false,
                   TwoFactorEnabled= false,
                   LockoutEnabled= false
               }
            };


            builder.Entity<AppUser>().HasData(users);

            ///----------------------------------------------------

            // Seed UserRoles


            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            // Add Password For All Users

            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Admin123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Manager123.");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "User123.");
            
            
            userRoles.Add(
            new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            }
            );
            userRoles.Add(
            new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.First(q => q.Name == "Manager").Id
            }
            );
            userRoles.Add(
            new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = roles.First(q => q.Name == "User").Id
            }
            );



            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

        }
    }
}
