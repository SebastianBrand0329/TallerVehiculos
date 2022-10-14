using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TallerVehiculos.Modelos;

namespace TallerVehiculos.Entidades
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Descripcion { get; set; }
        [JsonIgnore]
        public ICollection<IdentityModels> IdentityModels { get; set; }
    }
}
