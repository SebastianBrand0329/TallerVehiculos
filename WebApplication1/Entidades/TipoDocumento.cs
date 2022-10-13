using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Descripcion { get; set; }

        public ICollection<AspNetUserManager> User { get; set; }
    }
}
