using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TallerVehiculos.Entidades
{
    public class Procedimiento
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Descripcion { get; set; }
        [Required]
        public double Valor { get; set; }
        [JsonIgnore]
        public ICollection<Detalle> Detalles { get; set; }

    }
}
