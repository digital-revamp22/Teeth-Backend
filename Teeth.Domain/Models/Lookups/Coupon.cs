using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;

namespace Teeth.Domain.Models.Lookups;

public class Coupon : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Code { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal DiscountAmount { get; set; }

    [Required]
    public DateTime ExpirationDate { get; set; }

    [StringLength(100)]
    public string ApplicableRole { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}