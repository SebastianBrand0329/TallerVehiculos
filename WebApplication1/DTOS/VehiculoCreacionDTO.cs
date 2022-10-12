using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class VehiculoCreacionDTO
    {
        [MaxLength(10), Required]
        public string Placa { get; set; }
        [MaxLength(50), Required]
        public string Color { get; set; }
        [Required]
        public int Modelo { get; set; }
        [Required]
        public int Cilindraje { get; set; }
    }
}
