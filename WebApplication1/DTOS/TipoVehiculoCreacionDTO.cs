using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class TipoVehiculoCreacionDTO
    {
        [Required]
        [MaxLength(20)]
        public string Tipo { get; set; }
    }
}
