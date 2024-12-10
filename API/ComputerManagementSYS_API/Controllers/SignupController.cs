using ComputerManagementSYS_API.Datahelper;
using ComputerManagementSYS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class SignupController : ControllerBase
{
    private readonly UserDbContext _context;
    private readonly string salt = "YourUniqueSaltValue"; // Consistent salt value for password derivation

    public SignupController(UserDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Registers a new user in the system.
    /// </summary>
    /// <param name="newUser">User object containing Username and Password</param>
    /// <returns>A response indicating success or failure of user registration.</returns>
    /// <remarks>
    /// Data is stored in the SQL database configured for this API.
    /// </remarks>
    /// <response code="201">User successfully registered.</response>
    /// <response code="400">Username already exists.</response>
    /// <response code="500">Internal server error.</response>

    [HttpPost]
    public async Task<IActionResult> Signup([FromBody] User newUser)
    {
        try
        {
            if (await _context.Users.AnyAsync(u => u.Username == newUser.Username))
            {
                return BadRequest("Username already exists.");
            }

            newUser.Password = BCrypt.Net.BCrypt.HashPassword(newUser.Password); // Hash the password
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok("User registered successfully.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

}
