﻿using System.ComponentModel.DataAnnotations;

using TallerVehiculos.Entidades;
namespace TallerVehiculos.DTOS
{
    public class HistorialCreacionDTO
    {
        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }
        [Required]
        public decimal KilometrajeIngreso { get; set; }
        public ICollection<Detalle> Detalles { get; set; }
    }
}
