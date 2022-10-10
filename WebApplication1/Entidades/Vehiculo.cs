using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.Entidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Placa { get; set; }
        public string Color { get; set; }
        public int Modelo { get; set; }
    }
}
