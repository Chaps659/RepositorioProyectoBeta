using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto.DDD.Data.Contexto;
using Proyecto.DDD.Dominio.Entidades;

namespace Proyecto.DDD.Test.Data
{
    [TestClass]
    public class CrearContextBD
    {
        [TestMethod]
        public void CrearBDSQL()
        {
            var context = new ProyectoContext();

            var NuevoAlumno = new Alumno()
            {
                Nombre = "Cesar",
                Apellido = "Sarchioni",
                Fecha = new DateTime(2016, 11, 10),
                Activo = true
            };

            context.Alumnos.Add(NuevoAlumno);
            context.SaveChanges();

        }




    }
}
