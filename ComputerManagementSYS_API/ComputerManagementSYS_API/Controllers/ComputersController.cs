using ComputerManagementSYS_API.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ComputersController : ControllerBase
{
    private static List<Computer> Computers = new List<Computer>
    {
        new Computer { Id = 1, Name = "PC-1", Processor = "Intel i5", RAM = 8, Storage = 256 },
        new Computer { Id = 2, Name = "PC-2", Processor = "AMD Ryzen 5", RAM = 16, Storage = 512 }
    };

    [HttpGet]
    public IActionResult GetAll() => Ok(Computers);

    [HttpPost]
    public IActionResult AddComputer([FromBody] Computer newComputer)
    {
        newComputer.Id = Computers.Count + 1;
        Computers.Add(newComputer);
        return CreatedAtAction(nameof(GetAll), new { id = newComputer.Id }, newComputer);
    }
}
