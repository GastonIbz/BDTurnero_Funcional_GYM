using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.BD.Data.Entidades
{
    [Index(nameof(DNI), Name = "ProfesorDNI_UQ", IsUnique = true)]
    public class Profesor : EntityBase

    {

        
        [MaxLength(30, ErrorMessage = "El Nombre no debe superar los {1} caracteres")]
        public string Nombre{ get; set; }
        
        public string ImagenPerfil { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "La contraseña no es valida, el numero no debe superar los {1} caracteres")]
        public string Password { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "El DNI no debe superar los {1} caracteres")]
        public string DNI { get; set; }
    }
}
