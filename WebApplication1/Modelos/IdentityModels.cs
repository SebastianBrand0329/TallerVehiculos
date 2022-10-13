using Microsoft.AspNetCore.Identity;

namespace TallerVehiculos.Modelos
{
    public class IdentityModels: IdentityUser
    {
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Movil { get; set; }
    }
}
