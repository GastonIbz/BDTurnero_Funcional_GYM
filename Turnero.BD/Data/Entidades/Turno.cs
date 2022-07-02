using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.BD.Data.Entidades
{

    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaTurno { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaCreacion { get; set; }

     
    }
}
