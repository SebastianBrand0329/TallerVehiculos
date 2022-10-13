using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class DetalleDTO
    {
        public int Id { get; set; }
        [Required]
        public decimal PrecioReparacion { get; set; }
        [Required]
        public decimal PrecioRespuestos { get; set; }
        [Required]
        [MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
