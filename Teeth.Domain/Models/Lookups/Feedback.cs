using System.ComponentModel.DataAnnotations;

namespace Teeth.Domain.Models.Lookups;

public class Feedback
{
    public long id { get; set; }
    public long AppointmentId { get; set; }
    public long UserId { get; set; }
    public long DentistId { get; set; }

    [Required] public int Rating { get; set; }
    public string Comments { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}