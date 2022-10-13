using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class TipoDocumentoDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Descripcion { get; set; }
    }
}
