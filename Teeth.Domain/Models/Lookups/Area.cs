using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;

namespace Teeth.Domain.Models.Lookups;

public class Area : IAuditableEntity
{
    [Key]
    public long Id { get; set; }
    public long CityId { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}
