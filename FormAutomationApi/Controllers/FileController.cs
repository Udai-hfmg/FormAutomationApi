using Microsoft.AspNetCore.Mvc;

namespace FormAutomationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : Controller
    {

        private readonly AiService _aiSerivce;

        public FileController(AiService aiService)
        {
            _aiSerivce = aiService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create-template")]
        public async Task<IActionResult> Post(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded");


            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);

            var base64 = Convert.ToBase64String(ms.ToArray());

            var template = await _aiSerivce.ExtractTemplate(ms.ToArray());

            return Ok(new { template });
        }
    }
}
