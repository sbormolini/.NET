using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConditionalCompiler.Controllers;

[ApiController]
[Route("api")]
public class ExampleController : ControllerBase
{
    private readonly ILogger<ExampleController> _logger;

    public ExampleController(ILogger<ExampleController> logger) => _logger = logger;
    
    [HttpGet("example")]
    public IActionResult Get([FromQuery(Name ="q")] string? query = "")
    {

        // 1 will not be compiled in release mode
#if DEBUG
        _logger.LogDebug("The query was {Query}", query);
#endif

        // 2 more elegant approach same result
        Debug.Assert(query is null, "query is null");

        // 3 seperat method, used heavily by microsoft in aspnetcore
        // source.dot.net
        TestAssert(query is null);

        return Ok(new 
        { 
            message = $"The query was {query}" 
        });
    }

    [Conditional("DEBUG")]
    private void TestAssert(bool condition)
    {

    }
}

