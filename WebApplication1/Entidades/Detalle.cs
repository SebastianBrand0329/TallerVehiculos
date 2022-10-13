using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class Detalle
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
