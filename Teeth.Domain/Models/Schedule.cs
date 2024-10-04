namespace Teeth.Domain.Models;

public class Schedule
{
    public long Id { get; set; }
    public long UserId { get; set; } // dentist-id
    public DateTime AvailableDateTime { get; set; }
    public string AvailableTimeSlots { get; set; }
    public bool IsConfirmed { get; set; }
    
}