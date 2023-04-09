using IdentityOgreniyorum.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace IdentityOgreniyorum.Models.Authentication
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName => $"{FirstName} {LastName}";
        public string? IdentificationNumber { get; set; }
        public string? Adress { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime HiredDate { get; set; }
        public DateTime FiredDate { get; set; }

       

    }
}
