using Microsoft.AspNetCore.Mvc;

namespace SemgrepTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("Hello from SemgrepTestProject!");
        }
    }
}
