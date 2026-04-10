namespace FormAutomationApi.Model
{
    public class DocumentVersion
    {
        public int DocumentVersionId { get; set; }

        public int? DocumentTypeId { get; set; }
        public DocumentType? DocumentType { get; set; }

        public string? VersionLabel { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? RetiredDate { get; set; }
        public string? TemplatePath { get; set; }
    }
}
