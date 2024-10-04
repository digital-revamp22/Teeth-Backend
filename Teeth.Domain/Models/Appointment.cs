using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class Appointment
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
}