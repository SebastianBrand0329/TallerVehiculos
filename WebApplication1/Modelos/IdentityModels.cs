using Microsoft.AspNetCore.Identity;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.Modelos
{
    public class IdentityModels: IdentityUser
    {
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Movil { get; set; }
        //public int IdTipoDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
