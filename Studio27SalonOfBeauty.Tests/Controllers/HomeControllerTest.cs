using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studio27SalonOfBeauty.Controllers;
namespace Studio27SalonOfBeauty.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _controller;

        [TestInitialize]
        public void Init()
        {
            this._controller = new HomeController();
        }

        [TestMethod]
        public void Index_Should_Return_Default_Value()
        {
        }

        [TestMethod]
        public void About_Should_Return_Default_Value()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

