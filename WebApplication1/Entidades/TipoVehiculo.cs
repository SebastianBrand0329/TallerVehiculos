using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TallerVehiculos.Entidades
{
    public class TipoVehiculo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Tipo { get; set; }
        [JsonIgnore]
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
