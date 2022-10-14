using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TallerVehiculos.Entidades;
using TallerVehiculos.Modelos;

namespace TallerVehiculos.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions option): base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Vehiculo>().HasIndex(x => x.Placa).IsUnique();
        }


        public DbSet<Vehiculo> Vehiculos { get; set; }  
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }  
        public DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }
        public DbSet<ImagenVehiculo> ImagenVehiculos { get; set; }
        public DbSet<Procedimiento> Procedimientos { get; set; }    
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Historial> Historiales { get; set; }
        public DbSet<IdentityModels> User { get; set; }

    }
}
