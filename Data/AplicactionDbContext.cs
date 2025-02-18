using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrestamosSegurosAPI.Models;

namespace PrestamosSegurosAPI.Data
{
    public class AplicactionDbContext : IdentityDbContext
    {
       
        public AplicactionDbContext(DbContextOptions<AplicactionDbContext> options):base(options) { }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
