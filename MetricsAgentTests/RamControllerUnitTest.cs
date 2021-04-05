using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTests
{
    public class RamControllerUnitTests
    {
        private readonly RamMetricsController _controller;

        public RamControllerUnitTests()
        {
            _controller = new RamMetricsController();
        }
        
        [Fact]
        public void GetRamAvailable_ReturnsOk()
        {
            //Arrange

            //Act
            var result = _controller.GetRamAvailable();

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}