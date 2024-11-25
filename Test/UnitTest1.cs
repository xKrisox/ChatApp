using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Chat_test.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Chat_test.Models;
using Microsoft.AspNetCore.Http;


namespace Chat_test.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController(Mock.Of<ILogger<HomeController>>());

            // Act
            var result = controller.Privacy();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result); // Sprawdzamy, czy wynik to ViewResult
            Assert.Null(viewResult.ViewName); // Sprawdzamy, czy widok ma domyślną nazwę (null oznacza użycie widoku o tej samej nazwie co akcja)
        }
        
    }
}