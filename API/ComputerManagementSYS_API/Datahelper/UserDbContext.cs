using ComputerManagementSYS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ComputerManagementSYS_API.Datahelper
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computers { get; set; }

    }
}

