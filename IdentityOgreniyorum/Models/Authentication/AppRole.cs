using Microsoft.AspNetCore.Identity;

namespace IdentityOgreniyorum.Models.Authentication
{
    public class AppRole : IdentityRole
    {
        public DateTime? CreatedDate { get; set; }
    }
}
