using BackEnd.Models;
using BARBEER_SHOP.DATA;
using Microsoft.AspNetCore.Identity;

namespace BackEnd.Repositorys
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> signInManager;
        private readonly IConfiguration configuration;

        public AccountRepository(UserManager<CustomUser> userManager, SignInManager<CustomUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }

        public async Task<IdentityResult> SignUpAsync(RegisterUserModel model)
        {
            var user = new CustomUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName
            };

            if (user.Email!.ToLower().StartsWith("admin"))
            {
                await _userManager.CreateAsync(user, model.Password);
                return await _userManager.AddToRoleAsync(user, "ADMIN");
            }
            else
            {
                await _userManager.CreateAsync(user, model.Password);
                return await _userManager.AddToRoleAsync(user, "User");
            }
        }
    }
}
