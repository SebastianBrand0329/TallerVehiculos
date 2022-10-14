using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TallerVehiculos.Modelos;

namespace TallerVehiculos.Entidades
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10), Required]
        public string Placa { get; set; }
        [MaxLength(50), Required]
        public string Color { get; set; }
        [Required]
        public int Modelo { get; set; }
        [Required]
        public int Cilindraje { get; set; }
        [JsonIgnore]
        public MarcaVehiculo MarcaVehiculo { get; set; }
        [JsonIgnore]
        public TipoVehiculo TipoVehiculo { get; set; }
        [JsonIgnore]
        public IdentityModels IdentityModels { get; set; }
        [JsonIgnore]
        public ICollection<ImagenVehiculo> ImagenVehiculos { get; set; }
        [JsonIgnore]
        public ICollection<Historial> Historials { get; set; }
    }
}
