using Business.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Business.Logic.Tests
{
    [TestClass]
    public class CursoEntitiesTest
    {
        [TestClass]
        public class LaPropiedad_CursoDescripcion
        {
            [TestMethod]
            public void Concatena_La_Materia_Con_La_Comisión()
            {
                //Arrange
                Curso curso = new Curso
                {
                    ID = 1,
                    Materia = new Materia { ID = 1, Descripcion = ".NET" },
                    Comision = new Comision { ID = 1, Descripcion = "3K3" }
                };
                //Act
                var result = curso.CursoDescripcion;

                //Assert

                Assert.AreEqual(result, String.Concat(curso.Materia.Descripcion, " ", curso.Comision.Descripcion));
            }
        }
    }
}