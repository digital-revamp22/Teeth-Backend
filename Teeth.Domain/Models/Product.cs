using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class Product : IAuditableEntity
{
    [Key]
    public long Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int StockQuantity { get; set; }

    [Required]
    public ProductTypeEnum ProductType { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}
