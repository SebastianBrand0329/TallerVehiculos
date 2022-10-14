using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class MarcaVehiculoDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }
    }
}
