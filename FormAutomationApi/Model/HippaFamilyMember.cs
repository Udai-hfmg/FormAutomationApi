namespace FormAutomationApi.Model
{
    public class HipaaFamilyMember
    {
        public int HipaaFamilyMemberId {  get; set; }
        public int? SignedDocumentId {  get; set; }
        public string? FamilyMemberName {  get; set; }
        public string? Relationship {  get; set; }

        public bool IsRepresentative { get; set; }
    }
}
