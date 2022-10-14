using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TallerVehiculos.Entidades
{
    public class Historial
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }
        [Required]
        public double KilometrajeIngreso { get; set; }
        [JsonIgnore]
        public ICollection<Detalle> Detalles { get; set; }  
    }
}
