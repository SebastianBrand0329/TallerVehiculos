using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class TipoVehiculoDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Tipo { get; set; }
    }
}
