using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTests
{
    public class HddControllerUnitTest
    {
        private readonly HddMetricsController _controller;

        public HddControllerUnitTest()
        {
            _controller = new HddMetricsController();
        }
        
        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange

            //Act
            var result = _controller.GetHddLeftSpace();

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}