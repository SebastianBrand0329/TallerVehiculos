using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class TipoVehiculoDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Tipo { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
