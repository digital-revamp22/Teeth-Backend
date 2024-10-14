using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class Order : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    public long UserId { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal TotalAmount { get; set; }

    [Required]
    public OrderStatusEnum Status { get; set; }

    public long? CouponId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}