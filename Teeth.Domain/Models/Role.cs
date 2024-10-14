using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;

namespace Teeth.Domain.Models;

public class Role : IAuditableEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [StringLength(255)]
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}