namespace FormAutomationApi.Model
{
    public class PatientSignature
    {
        public int PatientSignatureId { get; set;}
        public int PatientId { get; set; }

        public byte[] SignatureData { get; set; }

        public string? FileType { get; set; }

        public DateTime? SignedAt { get; set; } = default(DateTime?);

        public DateTime? CreatedAt { get; set; }= DateTime.UtcNow;

        // Optional navigation
        public Patient? Patient { get; set; }
    }
}
