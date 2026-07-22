using Microsoft.AspNetCore.Mvc;

namespace Api.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController(ILogger<TesteController> logger) : ControllerBase
    {
        private readonly ILogger<TesteController> _logger = logger;

        [HttpGet]
        public async Task<IActionResult> ActionResult()
        {
            _logger.LogInformation("Teste endpoint called");
            return Ok("Hello, World!");
        }

    }
}
