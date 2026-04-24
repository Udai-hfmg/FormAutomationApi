using FormAutomationApi.Context;
using FormAutomationApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormAutomationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentTypeVersionController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public DocumentTypeVersionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var documentVersions = _dbContext.DocumentVersions
    .Include(dv => dv.DocumentType)
    .ToList();
            return Ok(documentVersions);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FormInput body)
        {
            try
            {
                if (body == null)
                    return BadRequest("Body is null");

                Console.WriteLine(body);

                var document = new DocumentVersion
                {
                    DocumentTypeId = body.DocumentTypeId,
                    VersionLabel = body.VersionLabel,
                    RetiredDate = body.RetiredDate,
                    TemplatePath = body.TemplatePath
                };

                await _dbContext.DocumentVersions.AddAsync(document);
                await _dbContext.SaveChangesAsync();

                return Ok(document);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("archvied")]
        public async Task<IActionResult> GetArchived() {
            try
            {
                var archivedDocuments = await _dbContext.ArchiveForms.ToListAsync();
                return Ok(archivedDocuments);
            }catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
           
        }

        //post archived forms with multiple faciliies
        [HttpPost("archived")]
        public async Task<IActionResult> PostArchive([FromBody] ArchiveRequest archiveRequest)
        {
            try
            {
                var newForms = new ArchiveForm
                {
                    FormIds = archiveRequest.FormIds,
                    FacilityIds=archiveRequest.FacilityIds,
                    Label=archiveRequest.Label,
                    ArchivedBy=archiveRequest.ArchivedBy,

                };

                await _dbContext.ArchiveForms.AddAsync(newForms);
                await _dbContext.SaveChangesAsync();
                return Ok(newForms);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("archived/{facilityId}")]
        public async Task<IActionResult> GetByFacility(int facilityId)
        {
            try
            {
                var result = await _dbContext.ArchiveForms
                    .FromSqlRaw(@"
                SELECT *
                FROM ArchiveForms
                WHERE EXISTS (
                    SELECT 1
                    FROM OPENJSON(FacilityIds)
                    WHERE value = {0}
                )
            ", facilityId)
                    .ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
        public class FormInput
{
    public string VersionLabel { get; set; }

    public int DocumentTypeId { get; set; }

    public DateTime? EffectiveDate { get; set; }
    public DateTime? RetiredDate { get; set; }
    public string TemplatePath { get; set; }
}

public class ArchiveRequest
{
    public string Label { get; set; }

    public List<int> FacilityIds { get; set; }
    public List<int> FormIds { get; set; }

    public string ArchivedBy { get; set; }

    

}
