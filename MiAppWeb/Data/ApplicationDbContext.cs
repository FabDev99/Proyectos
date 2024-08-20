using Microsoft.EntityFrameworkCore;
using MiAppWebBD.Models;
 
namespace MiAppWebBD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
 
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
            modelBuilder.Entity<Empleado>().ToTable("Empleado");
        }
    }
}