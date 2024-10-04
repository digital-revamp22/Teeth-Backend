namespace Teeth.Domain.Models;

public class Clinic
{
    public long Id { get; set; }
    public required string ClinicName { get; set; }
    public string Address { get; set; }
    public string ClinicPhone { get; set; }
    
}