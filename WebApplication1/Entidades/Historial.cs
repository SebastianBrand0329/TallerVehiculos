using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class Historial
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }
        [Required]
        public decimal KilometrajeIngreso { get; set; }

        public ICollection<Detalle> Detalles { get; set; }  
    }
}
