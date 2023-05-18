using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplicationDistribution;
using WebApplicationDistribution.Attributes;
using WebApplicationDistribution.Contracts;

[ApiController]
[Route("api/[controller]")]

public class AccountController : Controller
{
    private readonly IJwtUtils _jwtUtils;

    public AccountController(IJwtUtils jwtUtils)
    {
        _jwtUtils = jwtUtils;
    }

    [HttpPost]
    [AllowAnonymousAttribute]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
    {
        var token = _jwtUtils.GenerateToken(loginRequest.Login, loginRequest.Password);

        return Ok(token);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Verify()
    {
        return Ok();
    }
}

