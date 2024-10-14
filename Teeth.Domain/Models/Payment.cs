using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class Payment : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    public long PayerId { get; set; }

    [Required]
    public long PayeeId { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Amount { get; set; }

    [Required]
    public DateTime PaymentDate { get; set; }

    [Required]
    [StringLength(100)]
    public string PaymentMethod { get; set; }

    [Required]
    public PaymentTypeEnum PaymentType { get; set; }

    [Required]
    [StringLength(100)]
    public string TransactionId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}