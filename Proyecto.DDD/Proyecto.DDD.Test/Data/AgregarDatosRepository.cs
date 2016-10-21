using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto.DDD.Dominio.Entidades;
using Proyecto.DDD.Data.Contexto;
using Proyecto.DDD.Data.Repositorio;

namespace Proyecto.DDD.Test.Data
{

    [TestClass]
    public class AgregarDatosRepository
    {
        [TestMethod]
        public void CrearRepositoryBDSQL()
        {
            var Repository = new RepositoryAlumno();

            var NuevoAlumno = new Alumno()
            {
                Nombre = "Lucas",
                Apellido = "Cana",
                Fecha = new DateTime(2016, 06, 15),
                Activo = true
            };

            Repository.Add(NuevoAlumno);
        }
    }
}