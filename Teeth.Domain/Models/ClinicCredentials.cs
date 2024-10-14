using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;

namespace Teeth.Domain.Models;

public class ClinicCredentials : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    public long ClinicId { get; set; }

    public string CredentialDetails { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}