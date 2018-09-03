using System.Threading.Tasks;
using Icepay.Assignment.Controllers.Models;
using Icepay.Assignment.Services.Models;

namespace Icepay.Assignment.Services
{
    public interface ILoginService
    {
        Task<User> Login(LoginRequest loginRequest);
    }
}