using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Icepay.Assignment.Services.Models;

namespace Icepay.Assignment.Services
{
    public static class UserRepository
    {
        private static readonly IList<User> _users = new List<User>
        {
            new User("admin@icepay.com","miss admin","admin","admin_token"),
            new User("user@icepay.com","mr user","user","user_token")
        };

        public static async Task<IList<User>> GetAll()
        {
            return _users;
        }

        public static User Get(string email, string password)
        {
            return _users.FirstOrDefault(user => user.Email == email && user.Password == password);
        }
    }
}
