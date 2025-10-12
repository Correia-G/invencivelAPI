using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Incidente> incidentes { get; set; }
        public DbSet<Trem> Trem { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
