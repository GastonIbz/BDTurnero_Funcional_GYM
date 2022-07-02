using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnero.BD.Data.Entidades;

namespace Turnero.BD.Data
{ 
/// Representación BD

    public class BDContext : DbContext
    {
        public DbSet<Alumno> TablaAlumnos { get; set; }
        public DbSet<Profesor> TablaProfesores { get; set; }
        public DbSet<Turno> TablaTurnos { get; set; }
        public BDContext(DbContextOptions options) : base(options)
        {
        }
 
    }
}
