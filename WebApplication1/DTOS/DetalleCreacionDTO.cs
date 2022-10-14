using System.ComponentModel.DataAnnotations;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class DetalleCreacionDTO
    {
        [Required]
        public int PrecioReparacion { get; set; }
        [Required]
        public int PrecioRespuestos { get; set; }
        [Required]
        [MaxLength(100)]
        public string Descripcion { get; set; }


    }
}
