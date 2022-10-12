using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class MarcaVehiculoCreacionDTO
    {
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }
    }
}
