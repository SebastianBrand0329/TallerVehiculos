using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class TipoDocumentoCreacionDTO
    {
        [Required]
        [MaxLength(30)]
        public string Descripcion { get; set; }
    }
}
