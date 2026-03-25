using FormAutomationApi.Context;
using Microsoft.AspNetCore.Http.HttpResults;
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

            var patient = await _dbContext.Patients.FirstOrDefaultAsync(p => p.PatientId == id);
            var patientid = patient?.PatientId;
            //Console.Write($"this is the patinet{patient?.PatientId}");
            var emergency = await _dbContext.EmergencyContacts.FirstOrDefaultAsync(p => p.PatientId == id);
            //Console.Write($"this is the patinet{emergency}");
            var insurance = await _dbContext.InsurancePlans.FirstOrDefaultAsync(p => p.InsurancePlanId == id);
            //Console.Write($"this is the patinet{emergency}");
            var hippa = await _dbContext.HipaaFamilyMembers
     .Where(p => p.HipaaFamilyMemberId == id)
     .ToListAsync();

            //pharmacy
            var pharmacy = await _dbContext.PatientPharmacies.FirstOrDefaultAsync(p => p.PatientPharmacyId == id);

            //demographics
            var demographics = await _dbContext.PatientDemographics.FirstOrDefaultAsync(p => p.PatientId == id);

            //employer
            var employer = await _dbContext.PatientEmployments.FirstOrDefaultAsync(p => p.PatientEmploymentId == id);


            //patientinsurance
            var patientInsurance = await _dbContext.PatientInsurances.FirstOrDefaultAsync(p => p.PatientInsuranceId == id);


            if (patient == null)
                return NotFound();
            var obj = new
            {
                patient,
                emergency,
                insurance,
                hippa,
                pharmacy,
                demographics,
                employer,
                patientInsurance


            };
            return Ok(obj);




        }

        //
        [HttpPost("/")]
        public async Task<IActionResult> PostEmail(Patient patient)
        {
            if (patient == null)
                return BadRequest("Email is required");

            
     
             await _dbContext.Patients.AddAsync(patient);
            await _dbContext.SaveChangesAsync();
            return Ok(patient);
        }
    }
}