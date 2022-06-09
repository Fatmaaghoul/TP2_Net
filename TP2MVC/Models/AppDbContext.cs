using Microsoft.EntityFrameworkCore;
namespace TP2MVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employe> Employees { get; set; }
    }
}
