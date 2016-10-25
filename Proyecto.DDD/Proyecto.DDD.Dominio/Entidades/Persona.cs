﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DDD.Dominio.Entidades
{
    public abstract class Persona
    {
        public int PersonaID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

    }
}
