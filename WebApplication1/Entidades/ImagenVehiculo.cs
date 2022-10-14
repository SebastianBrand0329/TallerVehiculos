using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TallerVehiculos.Entidades
{
    public class ImagenVehiculo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string placa { get; set; }
        [Required]
        public string Foto { get; set; }
        [JsonIgnore]
        public Vehiculo Vehiculo { get; set; }
    }
}
