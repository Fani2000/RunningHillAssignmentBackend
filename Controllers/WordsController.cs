using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        public WordsController()
        {
        }

        [HttpGet("{type}")]
        public async Task<ActionResult> GetWords(string type)
        {
            return Ok();
        }

    }
}