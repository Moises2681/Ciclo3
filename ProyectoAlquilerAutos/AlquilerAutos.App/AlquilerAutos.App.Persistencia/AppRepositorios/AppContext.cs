using Microsoft.EntityFrameworkCore;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Vehiculo> Vehiculos {get; set;}
        public DbSet<Alquiler> Alquileres {get; set; }
        public DbSet<TipoCaja> TiposCaja {get; set; }
        public DbSet<Marca> Marcas {get; set; }
        public DbSet<TipoCombustible> TiposCombustible {get; set; }
        public DbSet<FormaPago> FormasPago {get; set; }
        public DbSet<HojaVida> HojasVida {get; set; }
        public DbSet<EstadoAlquiler> EstadosAlquiler {get; set; }
        public DbSet<EstadoEntrega> EstadosEntrega {get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Server=localhost; user id=sa; password=12345; Initial Catalog=AlquilerAutos");
            }
        }
    }
}