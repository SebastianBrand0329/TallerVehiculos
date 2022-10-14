using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class HistorialDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }
        [Required]
        public double KilometrajeIngreso { get; set; }
    }
}
