using System.Collections.Generic;
using System.Threading.Tasks;
using Icepay.Assignment.Services.Models;

namespace Icepay.Assignment.Services
{
    public interface IUserService
    {
        Task<IList<User>> GetAll();
    }
}