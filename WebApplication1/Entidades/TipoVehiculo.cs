using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class TipoVehiculo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Tipo { get; set; }
    }
}
