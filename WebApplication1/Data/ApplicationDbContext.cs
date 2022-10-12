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
    }
}
