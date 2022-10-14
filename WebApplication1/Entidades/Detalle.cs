using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TallerVehiculos.Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        [Required]
        public int PrecioReparacion { get; set; }
        [Required]
        public int PrecioRespuestos { get; set; }
        [Required]
        [MaxLength(100)]   
        public string Descripcion { get; set; }
        [JsonIgnore]
        public Historial Historial { get; set; }
        [JsonIgnore]
        public Procedimiento Procedimiento { get; set; }
    }
}
