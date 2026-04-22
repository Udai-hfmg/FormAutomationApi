using FormAutomationApi.Context;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FormAutomationApi.Services
{

    public class PatientDTO{
        public int id { get; set; }
        public string name { get; set;  }

        public string city { get; set; }

        public string phone { get; set; }
    }

    public interface IPatientService
    {
        Task<List<PatientDTO>> SearchPatients(string query);
    }
    public class PatientService : IPatientService
    {

        private readonly ApplicationDbContext _context;
        public PatientService(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<List<PatientDTO>> SearchPatients(string query)
        {
            return await _context.Patients
                .Where(p => p.PatientId.ToString().Contains(query))
                .Select(p => new PatientDTO
                {
                    id = p.PatientId,
                    name = p.FirstName + " " + p.LastName,
                    city = p.City ,
                    phone = p.PhonePrimary ?? p.PhoneAlternate ?? "N/A"
                })
                .Take(10)
                .ToListAsync();
        }

    }
}
