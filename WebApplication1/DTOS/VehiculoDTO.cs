using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class VehiculoDTO
    {
        [Key]
        public int Id { get; set; }
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
