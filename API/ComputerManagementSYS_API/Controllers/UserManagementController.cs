using ComputerManagementSYS_API.Datahelper;
using ComputerManagementSYS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UserManagementController : ControllerBase
{
    private readonly UserDbContext _context;

    public UserManagementController(UserDbContext context)
    {
        _context = context;
    }

    // GET: api/UserManagement
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _context.Users.Select(u => new
        {
            u.Id,
            u.Username,
            u.CreatedAt
        }).ToListAsync();

        return Ok(users);
    }

    // POST: api/UserManagement
    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody] User newUser)
    {
        if (await _context.Users.AnyAsync(u => u.Username == newUser.Username))
        {
            return BadRequest("Username already exists.");
        }

        newUser.Password = BCrypt.Net.BCrypt.HashPassword(newUser.Password);
        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();

        return Ok("User added successfully.");
    }

    // PUT: api/UserManagement/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] User updatedUser)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return NotFound("User not found.");
        }

        user.Username = updatedUser.Username ?? user.Username;
        if (!string.IsNullOrWhiteSpace(updatedUser.Password))
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(updatedUser.Password);
        }

        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return Ok("User updated successfully.");
    }

    // DELETE: api/UserManagement/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return NotFound("User not found.");
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return Ok("User deleted successfully.");
    }
}
