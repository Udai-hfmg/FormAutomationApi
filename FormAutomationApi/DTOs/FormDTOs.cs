namespace FormAutomationApi.DTOs
{
   public class SendFormRequest
    {
        public string Group { get; set; } = string.Empty;
        public string PatientId { get; set; } = string.Empty;
        public string FacilityId { get; set; } = string.Empty;
    }
}
