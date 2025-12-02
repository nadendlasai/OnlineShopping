using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Shopping.ApplicationService;
using OnlineShopping.Shopping.ViewModels;

namespace OnlineShopping.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthApplicationService _authApplicationService;

        public AuthController(IAuthApplicationService authApplicationService)
        {
            _authApplicationService = authApplicationService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);            

            return Ok(await _authApplicationService.Register(dto));
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            return Ok(await _authApplicationService.Login(dto));
        }
    }
}
