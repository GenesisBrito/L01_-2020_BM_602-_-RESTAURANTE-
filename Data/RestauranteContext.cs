using Microsoft.EntityFrameworkCore;
using L01__2020_BM_602___RESTAURANTE_.Models;

namespace L01__2020_BM_602___RESTAURANTE_.Data
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> options)
            : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }

        // 👇 AQUÍ DENTRO DE LA CLASE
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>()
                .Property(e => e.Costo)
                .HasPrecision(10, 2); // 💰 dinero correcto
        }
    }
}