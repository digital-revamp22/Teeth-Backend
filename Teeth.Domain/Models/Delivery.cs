using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class Delivery : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    public long OrderId { get; set; }

    [Required]
    public long DriverId { get; set; }

    [Required]
    public DateTime AssignedAt { get; set; }

    [Required]
    public DeliveryStatusEnum Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}