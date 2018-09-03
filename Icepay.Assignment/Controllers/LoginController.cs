using System.Threading.Tasks;
using Icepay.Assignment.Controllers.Models;
using Icepay.Assignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Icepay.Assignment.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest == null || string.IsNullOrWhiteSpace(loginRequest.Email) || string.IsNullOrWhiteSpace(loginRequest.Password)) return BadRequest();

            var user = await _loginService.Login(loginRequest);

            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(user.Token);
        }
    }
}
