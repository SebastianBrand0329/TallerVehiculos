﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TallerVehiculos.DTOS
{
    public class CredencialesUsuario: IdentityUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
