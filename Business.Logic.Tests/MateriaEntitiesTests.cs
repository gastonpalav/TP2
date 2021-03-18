using Business.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Logic.Tests
{
    [TestClass]
    public class MateriaEntitiesTests
    {
        [TestMethod]
        public void La_Propiedad_Plan_Descripcion_Devuelve_La_Descripcion_Del_Plan_Que_La_Materia_Tiene()
        {
            //Arrange

            Materia materia = new Materia
            {
                ID = 1,
                Plan = new Plan { ID = 1, Descripcion = "Materia Descripcion" }
            };

            var expectedDescription = "Materia Descripcion";

            //Act
            var result = materia.PlanDescripcion;

            //Assert

            Assert.AreEqual(expectedDescription, result);
        }
    }
}