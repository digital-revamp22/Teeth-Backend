using Microsoft.EntityFrameworkCore;
using Teeth.Domain.Models;
using Teeth.Domain.Models.Lookups;

namespace Teeth.Application.Interfaces;

public interface IAppDbContext
{
    public DbSet<User> Users { get; }

    // Clinic 
    public DbSet<Clinic> Clinics { get; }
    public DbSet<ClinicContract> ClinicContracts { get; }
    public DbSet<ClinicCredentials> ClinicCredentials { get; }

    // RBAC
    public DbSet<UserRole> UserRoles { get; }
    public DbSet<Role> Roles { get; }

    // Appointment
    public DbSet<Appointment> Appointments { get; }
    public DbSet<Schedule> Schedules { get; }

    // Finance
    public DbSet<Payment> Payments { get; }
    public DbSet<PaymentDues> PaymentDues { get; }

    // cosmetics
    public DbSet<Product> Products { get; }
    public DbSet<Order> Orders { get; }
    public DbSet<OrderItem> OrderItems { get; }
    public DbSet<Delivery> Deliveries { get; }

    // Lookups
    public DbSet<Country> Countries { get; }
    public DbSet<Coupon> Coupons { get; }

    public DbSet<Feedback> Feedbacks { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}