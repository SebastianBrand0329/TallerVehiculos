using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class MarcaVehiculo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
