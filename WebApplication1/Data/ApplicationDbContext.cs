using Microsoft.EntityFrameworkCore;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions option): base(option)
        {

        }

        public DbSet<Vehiculo> Vehiculos { get; set; }  
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }  
        public DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }
        public DbSet<ImagenVehiculo> ImagenVehiculos { get; set; }
        public DbSet<Procedimiento> Procedimientos { get; set; }    
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

        public DbSet<Historial> Historiales { get; set; }

    }
}
