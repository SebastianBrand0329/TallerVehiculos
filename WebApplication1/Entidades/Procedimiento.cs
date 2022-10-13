using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class Procedimiento
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Descripcion { get; set; }
        [Required]
        public decimal Valor { get; set; }

        public ICollection<Detalle> Detalles { get; set; }

    }
}
