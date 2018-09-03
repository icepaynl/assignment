using System.Threading.Tasks;
using Icepay.Assignment.Controllers.Models;
using Icepay.Assignment.Services.Models;

namespace Icepay.Assignment.Services
{
    public class LoginService : ILoginService
    {
        public async Task<User> Login(LoginRequest loginRequest)
        {
            return UserRepository.Get(loginRequest.Email, loginRequest.Password);
        }
    }
}