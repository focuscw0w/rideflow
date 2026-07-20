using Microsoft.AspNetCore.Mvc;
using rideflow.DTOs.Auth;

namespace rideflow.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {

    }
}
