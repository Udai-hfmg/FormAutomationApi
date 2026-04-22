using System.ComponentModel.DataAnnotations;

public class ArchiveForm
{

    public int Id { get; set; }
    [Required]
    public string Label { get; set; }

    [Required, MinLength(1, ErrorMessage = "At least one form must be selected.")]
    public List<int> FormIds { get; set; } = new();

    [Required, MinLength(1, ErrorMessage = "At least one facility must be selected.")]
    public List<int> FacilityIds { get; set; } = new();

    [Required]
    public string ArchivedBy { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}