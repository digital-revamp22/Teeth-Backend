using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class Appointment : IAuditableEntity
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long DentistId { get; set; }
    public long ClinicId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public AppointmentStatusEnum AppointmentStatus { get; set; }
    public float DepositValue { get; set; }
    public float WithdrawValue { get; set; }
    public float TotalValue { get; set; }
    public bool IsDepositPaid { get; set; }
    public bool IsFeedbackGiven { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
}