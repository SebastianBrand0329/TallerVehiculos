using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class ImagenVehiculoCreacionDTO
    {
        [Required]
        [MaxLength(10)]
        public string placa { get; set; }
        [Required]
        public IFormFile Foto { get; set; }

    }
}
