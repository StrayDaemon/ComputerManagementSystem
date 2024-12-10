using ComputerManagementSYS_API.Datahelper;
using ComputerManagementSYS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly UserDbContext _context;
    private readonly string salt = "YourUniqueSaltValue"; // Consistent salt value for password derivation

    public LoginController(UserDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginModel)
    {
        try
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == loginModel.Username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginModel.Password, user.Password))
            {
                return Unauthorized("Invalid username or password.");
            }

            return Ok("Login successful.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
