using Microsoft.AspNetCore.Identity;

namespace BARBEER_SHOP.DATA
{
    public class CustomUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
