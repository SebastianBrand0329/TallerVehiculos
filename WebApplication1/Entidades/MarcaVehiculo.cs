using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TallerVehiculos.Entidades
{
    public class MarcaVehiculo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }
        [JsonIgnore]
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
