using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialRodolfoHeredia.Controllers;

namespace UnitTestParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arrange
            CountriesController controller = new CountriesController();

            //Act
            var ResultadoG = controller.GetCountries();

            //Assert
            Assert.IsNotNull(ResultadoG);

        }
    }
}
