using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class ProcedimientoCreacionDTO
    {
        [Required]
        [MaxLength(255)]
        public string Descripcion { get; set; }
        [Required]
        public decimal Valor { get; set; }
    }
}
