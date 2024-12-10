namespace ComputerManagementSYS_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Note: Use hashed passwords in production!
    }

}
