using Xunit;
using swagstore.api.Controllers;
using swagstore.api.Models;
using swagstore.api.Contracts;
using swagstore.api.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;

namespace swagstore.tests;

public class SwagItemControllerTest
{
    SwagItemController _controller;
    ISwagItemService _service;

    ILogger<SwagItemController> _logger = Mock.Of<ILogger<SwagItemController>>();

    public SwagItemControllerTest()
    {
        _service = new SwagItemService();
        _controller = new SwagItemController(_logger,_service);
    }

    [Fact]
    public void GetAllTest()
    {
        // Arrange
        
        // Act
        var result = _controller.Get();
        
        // Assert
        
        // Check that we have an "OK" result
        Assert.IsType<OkObjectResult>(result.Result);
        var list = result.Result as OkObjectResult;

        // Check that the items are SwagItems
        Assert.IsType<List<SwagItem>>(list?.Value);

        // Check that we have 5 items
        var listSwagItems = list?.Value as List<SwagItem>;
        Assert.Equal(5, listSwagItems?.Count);

    }
}