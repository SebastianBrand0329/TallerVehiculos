using Microsoft.EntityFrameworkCore;

namespace TallerVehiculos.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions option): base(option)
        {

        }
    }
}
