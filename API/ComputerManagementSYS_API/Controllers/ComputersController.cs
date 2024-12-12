using ComputerManagementSYS_API.Datahelper;
using ComputerManagementSYS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ComputersController : ControllerBase
{
    private readonly UserDbContext _context;

    public ComputersController(UserDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetComputers()
    {
        var computers = await _context.Computers.ToListAsync();
        return Ok(computers);
    }

    [HttpPost]
    public async Task<IActionResult> AddComputer([FromBody] Computer newComputer)
    {
        newComputer.LastUpdated = DateTime.Now;
        _context.Computers.Add(newComputer);
        await _context.SaveChangesAsync();
        return Ok("Computer added successfully.");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateComputer(int id, [FromBody] Computer updatedComputer)
    {
        if (id != updatedComputer.Id)
        {
            return BadRequest("Mismatched computer ID.");
        }

        var computer = await _context.Computers.FindAsync(id);
        if (computer == null)
        {
            return NotFound("Computer not found.");
        }

        // Update the computer's details
        computer.ComputerName = updatedComputer.ComputerName;
        computer.Status = updatedComputer.Status;
        computer.Processor = updatedComputer.Processor;
        computer.RAM = updatedComputer.RAM;
        computer.Storage = updatedComputer.Storage;
        computer.GraphicsCard = updatedComputer.GraphicsCard;
        computer.OperatingSystem = updatedComputer.OperatingSystem;
        computer.LastUpdated = DateTime.Now;

        _context.Computers.Update(computer);
        await _context.SaveChangesAsync();

        return Ok("Computer updated successfully.");
    }


    // DELETE: api/Computers/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteComputer(int id)
    {
        var computer = await _context.Computers.FindAsync(id); // Find the computer by ID
        if (computer == null)
        {
            return NotFound("Computer not found."); // Return 404 if the computer doesn't exist
        }

        _context.Computers.Remove(computer); // Remove the computer from the database
        await _context.SaveChangesAsync(); // Save changes to the database

        return Ok("Computer deleted successfully."); // Return success message
    }

}