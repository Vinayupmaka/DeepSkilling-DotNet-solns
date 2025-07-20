using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserService.Model;

namespace UserService.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class AuthController : COntrollerBase
{
private readonly IConfiguration _config;
public AuthController(IConfiguration config)
{
_config = config;
}
private List<User> _users = new List<User>
{
new User { Username = "admin", Password = "admin123" },
new User { Username = "user", Password = "user123" }
};
[HttpPost("login")]
public IActionResult Login([FromBody] User user)
{
var validUser = _users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
if (validUser == null)
{
return Unauthorized("Invalid Credentials");
}
var secretKey = _config["JwtSettings:Key"];
if (string.IsNullOrEmpty(secretKey))
{
return StatusCode(500, "JWT Key is missing in configuration!");
}
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
var claims = new[]
{
new Claim(ClaimTypes.Name, user.Username)
};
var token = new JwtSecurityToken(
claims: claims,
expires: DateTime.Now.AddMinutes(30),
signingCredentials: creds
);
return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
}
}
}
