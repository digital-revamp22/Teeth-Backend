using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class PaymentDues : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    public long UserId { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal AmountDue { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public PaymentDueStatusEnum Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}