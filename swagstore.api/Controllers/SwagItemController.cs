using Microsoft.AspNetCore.Mvc;
using swagstore.api.Models;
using swagstore.api.Controllers;
using swagstore.api.Contracts;

namespace swagstore.api.Controllers;

[ApiController]
[Route("[controller]")]
public class SwagItemController : ControllerBase
{
    private readonly ILogger<SwagItemController> _logger;
    private readonly ISwagItemService _service;

    public SwagItemController(ILogger<SwagItemController> logger, ISwagItemService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<SwagItem>> Get()
    {
        var items = _service.GetAll();
        return Ok(items);
    }

}