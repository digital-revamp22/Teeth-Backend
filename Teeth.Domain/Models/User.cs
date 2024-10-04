using System.ComponentModel.DataAnnotations;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Domain.Models
{
    public class User
    {
        [Key] public long Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Phone { get; set; }
        [Required] public string Address { get; set; }
        public string Image { get; set; }
        public GenderEnum Gender { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }
        public int YearsOfExperience { get; set; }
        public string? Speciality { get; set; }
        public bool IsVerified { get; set; }
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
}