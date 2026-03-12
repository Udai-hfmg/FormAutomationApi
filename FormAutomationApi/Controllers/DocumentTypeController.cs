using FormAutomationApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormAutomationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentTypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DocumentTypeController(ApplicationDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var docmentTypes = await _context.DocumentTypes.ToListAsync();
            return Ok(docmentTypes);
        }
        
    }
}
