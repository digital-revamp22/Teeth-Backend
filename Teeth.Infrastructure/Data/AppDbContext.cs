using Microsoft.EntityFrameworkCore;
using Teeth.Domain.Models;
using Teeth.Domain.Models.Lookups;

namespace Teeth.Infratructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    // Users
    public DbSet<User> Users { get; set; }
    // Clinic 
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<ClinicContract> ClinicContracts { get; set; }
    public DbSet<ClinicCredentials> ClinicCredentials { get; set; }
    // RBAC
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Role> Roles { get; set; }
    // Appointment
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    // Finance
    public DbSet<Payment> Payments { get; set; }
    public DbSet<PaymentDues> PaymentDues { get; set; }
    // cosmetics
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    // Lookups
    public DbSet<Country> Countries { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    public DbSet<Feedback> Ratings { get; set; }

}
