using System.ComponentModel.DataAnnotations;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models;

public class User
{
    [Key] public long Id { get; set; }
    public required string Name { get; set; }
    [EmailAddress] public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Phone { get; set; }
    public required string Address { get; set; }
    public string? Image { get; set; }
    public GenderEnum Gender { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } // safe deletion
    public DateTimeOffset? BirthDate { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public int YearsOfExperience { get; set; }
    public string? Speciality { get; set; } // dentist speciality
    public double? AverageRating { get; set; }

    public int? NumberOfRatings { get; set; }

    // common relations with all users
    public long UserRoleId { get; set; }
    public long CountryId { get; set; }
    public long RatingId { get; set; }
    public long PaymentId { get; set; }
    //  relations related to client: payments, orders, appointments, rating, schedule

    //  relations related to clinic Owner: Clinic, ClinicContract, ClinicCredentials, Payments, Payment Dues, Orders =>
    // Continue Here
    //  relations related to dentist: Appointments, Schedules, Ratings, Payments, Payment Dues, Clinics => 
    // Continue Here
    // relations related to driver delivery
    // relations related to Admin and Employee
}