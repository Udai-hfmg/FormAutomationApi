using FormAutomationApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormAutomationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeController : Controller
    {

        private readonly IFacilityService _facilityService;

        public OfficeController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> Index(string query)
        {
            try
            {
                var searchFacilities = await _facilityService.SearchFacility(query);
                return Ok(searchFacilities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "An error occurred while searching facilities.",
                    error = ex.Message
                });
            }
        }
    }
}
