using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class HistorialCreacionDTO
    {
        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }
        [Required]
        public decimal KilometrajeIngreso { get; set; }
    }
}
