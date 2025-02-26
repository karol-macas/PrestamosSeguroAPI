﻿using Microsoft.AspNetCore.Identity;

namespace PrestamosSegurosAPI.Models
{
    public class Usuario : IdentityUser
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
