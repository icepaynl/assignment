using System.Linq;
using System.Threading.Tasks;
using Icepay.Assignment.Controllers.Models;
using Icepay.Assignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Icepay.Assignment.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AuthFilter]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users.Select(u => new UserRepresentation(u.Email, u.Name)).ToList());
        }

        [Route("myprofile")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var token = Request.Headers["x-auth-token"];

            var users = await _userService.GetAll();
            var user = users.FirstOrDefault(u => u.Token == token);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(new UserRepresentation(user.Email, user.Name));
        }
    }
}
