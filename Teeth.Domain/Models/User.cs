using System.ComponentModel.DataAnnotations;
using Teeth.Domain.Interfaces;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class User : IAuditableEntity
{
    [Key] public long Id { get; set; }
    public required string Name { get; set; }
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [Required]

    public string Password { get; set; }
    [Required]

    public string Phone { get; set; }
    [Required]

    public string Address { get; set; }
    public string? Image { get; set; }
    public GenderEnum Gender { get; set; }

    public DateTimeOffset? BirthDate { get; set; }

    public int YearsOfExperience { get; set; }
    public string? Speciality { get; set; } // dentist speciality
    public double? AverageRating { get; set; }

    public int? NumberOfRatings { get; set; }

    // common relations with all users
    public long UserRoleId { get; set; }
    public long CountryId { get; set; }
    public long RatingId { get; set; }
    public long PaymentId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime? UpdatedAt { get; set; } = null;
    public string UpdatedBy { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
    public bool IsActived { get; set; } = true;
    //  relations related to client: payments, orders, appointments, rating, schedule

    //  relations related to clinic Owner: Clinic, ClinicContract, ClinicCredentials, Payments, Payment Dues, Orders =>
    // Continue Here
    //  relations related to dentist: Appointments, Schedules, Ratings, Payments, Payment Dues, Clinics => 
    // Continue Here
    // relations related to driver delivery
    // relations related to Admin and Employee
}