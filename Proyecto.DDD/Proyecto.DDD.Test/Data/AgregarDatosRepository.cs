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
        public void AgregarAlumnoRepositorio()
        {
           var RepositoryAlu = new RepositoryAlumno();

            var NuevoAlumno = new Alumno()
            {
                Nombre = "Carlos",
                Apellido = "Tevez",
                Descripcion = "Vamos boca carajo"
              
            };

            RepositoryAlu.Add(NuevoAlumno);
      
        }

        [TestMethod]
        public void AgregarProfesorRepositorio()
        {
            var RepositoryPro = new RepositoryProfesor();

            var NuevoProfesor = new Profesor()
            {
                Nombre = "Carlos",
                Apellido = "Tevez",
                Catedra = "Futbol",
                Mail = "Carlos@teves"

            };

        RepositoryPro.Add(NuevoProfesor);

        }
    }
}