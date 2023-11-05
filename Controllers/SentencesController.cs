using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentencesController : ControllerBase
    {
        public SentencesController()
        {
        }

        public async Task<ActionResult> GetAllSentences()
        {
            // var results = new List<String, Stri> { name = "Fani" };

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetSentence(int id)
        {

            return null;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult> PostSentence(String name)
        {
            return null;
        }

    }
}