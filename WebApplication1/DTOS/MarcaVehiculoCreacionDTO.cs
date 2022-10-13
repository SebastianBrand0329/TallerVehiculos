using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class MarcaVehiculoCreacionDTO
    {
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
