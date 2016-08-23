using FizzBuzzMvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace FizzBuzzMvc.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_Should_Return_1_When_1()
        {
            var controller = new HomeController();

            var view = controller.Index(1) as ViewResult;

            Assert.AreEqual("1", view.ViewBag.Message);
        }

        [TestMethod]
        public void Index_Should_Return_Fizz_When_3()
        {
            var controller = new HomeController();

            var view = controller.Index(3) as ViewResult;

            Assert.AreEqual("1 2 Fizz", view.ViewBag.Message);
        }

        [TestMethod]
        public void Index_Should_Return_Buzz_When_5()
        {
            var controller = new HomeController();

            var view = controller.Index(5) as ViewResult;

            Assert.AreEqual("1 2 Fizz 4 Buzz", view.ViewBag.Message);
        }

        [TestMethod]
        public void Index_Should_Return_FizzBuzz_When_15()
        {
            var controller = new HomeController();

            var view = controller.Index(15) as ViewResult;

            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz", view.ViewBag.Message);
        }

        public void Index_Should_Return_Correct_Sequence_When_No_Param_Parsed()
        {
            var controller = new HomeController();

            var view = controller.Index() as ViewResult;

            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz", view.ViewBag.Message);
        }

        [TestMethod]
        public void Index_Should_Return_View()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(-1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About_Should_Return_View()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About_Should_Have_Description()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result.ViewBag.Message);
            Assert.IsFalse(string.IsNullOrEmpty(result.ViewBag.Message));
            Assert.IsFalse(string.IsNullOrWhiteSpace(result.ViewBag.Message));
        }

        [TestMethod]
        public void Contact_Should_Return_View()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact_Should_Have_Contact_Info()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsTrue(result.ViewBag.Message.Contains("luke@lukewarrendev.co.za"));
            Assert.IsTrue(result.ViewBag.Message.Contains("@lukejkwarren"));
        }
    }
}