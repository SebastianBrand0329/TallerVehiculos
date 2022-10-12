using System.ComponentModel.DataAnnotations;

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
