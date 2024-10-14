using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;

namespace Teeth.Domain.Models;

public class OrderItem : IAuditableEntity
{
    public long Id { get; set; }

    [Required]
    public long OrderId { get; set; }

    [Required]
    public long ProductId { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}