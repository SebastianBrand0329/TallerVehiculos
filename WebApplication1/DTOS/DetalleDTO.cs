using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.DTOS
{
    public class DetalleDTO
    {
        public int Id { get; set; }
        [Required]
        public int PrecioReparacion { get; set; }
        [Required]
        public int PrecioRespuestos { get; set; }
        [Required]
        [MaxLength(100)]
        public string Descripcion { get; set; }

    }
}
