using FormAutomationApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormAutomationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public PatientController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            var patients = await _dbContext.Patients.ToListAsync();
           //var documentTypes = await _dbContext.Patients.ToListAsync();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await _dbContext.Patients.FindAsync(id);

            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        //
        [HttpPost("/")]
        public async Task<IActionResult> PostEmail(Patient patient)
        {
            if (patient == null)
                return BadRequest("Email is required");
            
     
            var newPatient = await _dbContext.Patients.AddAsync(patient);
            await _dbContext.SaveChangesAsync();
            return Ok(newPatient);
        }
    }
}