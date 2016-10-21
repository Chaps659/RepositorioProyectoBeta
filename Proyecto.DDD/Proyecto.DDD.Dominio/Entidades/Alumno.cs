using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DDD.Dominio.Entidades
{
    public class Alumno
    {
        public int AlumnoID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime Fecha { get; set; }

        public bool Activo { get; set; }

    }
}
