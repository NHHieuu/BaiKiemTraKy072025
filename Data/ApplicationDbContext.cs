using Microsoft.EntityFrameworkCore;
using KiemTraMvc.Models;
namespace KiemTraMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Hieu> Users { get; set; }
    }
}