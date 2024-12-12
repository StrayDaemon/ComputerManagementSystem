using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerManagementSYS_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Note: Use hashed passwords in production!

        [Column("created_at")] // Explicitly map to the database column
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

}
