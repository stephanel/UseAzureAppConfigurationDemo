using Microsoft.AspNetCore.Mvc;

namespace UseAzureConfigurationTests.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigController : ControllerBase
    {
        private readonly Settings _settings;

        public ConfigController(Settings settings)
        {
            _settings = settings;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_settings);
        }
    }
}
