using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Models;


namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
