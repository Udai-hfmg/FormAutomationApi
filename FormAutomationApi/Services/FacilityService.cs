using FormAutomationApi.Context;
using Microsoft.EntityFrameworkCore;

namespace FormAutomationApi.Services
{

    public class FacilitySearchDTO
    {
        public int? id { get; set; }

        public string name { get; set; }

        public string city { get; set; }
    }
    public interface IFacilityService
    {
        public Task<List<FacilitySearchDTO>> SearchFacility(string query);
    }
    public class FacilityService:IFacilityService
    {
        private readonly ApplicationDbContext _context;

        public FacilityService(ApplicationDbContext context) {  _context = context; }

        public async  Task<List<FacilitySearchDTO>> SearchFacility(string query)
        {
            return await _context.Offices.Where(p => p.OfficeName.ToString().Contains(query)).Select(p => new FacilitySearchDTO
            {
                id = p.OfficeId,
                name = p.OfficeName,
                city = p.City
            }).Take(10).ToListAsync();
        }
        
    }
}
