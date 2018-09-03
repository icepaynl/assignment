using System.Collections.Generic;
using System.Threading.Tasks;
using Icepay.Assignment.Services.Models;

namespace Icepay.Assignment.Services
{
    public class UserService : IUserService
    {
        public async Task<IList<User>> GetAll()
        {
            return await UserRepository.GetAll();
        }
    }
}