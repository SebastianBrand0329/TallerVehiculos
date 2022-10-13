using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class ProcedimientoCreacionDTO
    {
        [Required]
        [MaxLength(255)]
        public string Descripcion { get; set; }
        [Required]
        public decimal Valor { get; set; }
        public ICollection<Detalle> Detalles { get; set; }
    }
}
