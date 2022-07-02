using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.BD.Data.Entidades
{
   
    public class Profesor 
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string ImagenPerfil { get; set; }

        public string Password { get; set; }
        public string DNI { get; set; }
    }
}
