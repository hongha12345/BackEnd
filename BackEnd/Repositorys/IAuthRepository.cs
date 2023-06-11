using BackEnd.Models;
using static BackEnd.Repositorys.AuthRepository;

namespace BackEnd.Repositorys
{
    public interface IAuthRepository
    {
        public Task<AuthResult> AuthenticateAsync(LoginModel model);
    }
}
