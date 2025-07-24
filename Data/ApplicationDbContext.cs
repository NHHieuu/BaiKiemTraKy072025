using Microsoft.EntityFrameworkCore;
using KiemTraMvc.Models;
namespace KiemTraMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Hieu> Users { get; set; }
        public DbSet<KiemTraMvc.Models.Lop> Lop { get; set; } = default!;
    }
}