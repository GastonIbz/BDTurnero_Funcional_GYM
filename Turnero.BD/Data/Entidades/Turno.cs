﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.BD.Data.Entidades
{

    public class Turno : EntityBase
    {

       
        [Required]
        public int IdAlumno { get; set; }

       
     
    }
}
