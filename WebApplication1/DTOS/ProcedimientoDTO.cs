using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class ProcedimientoDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Descripcion { get; set; }
        [Required]
        public double Valor { get; set; }

    }
}
