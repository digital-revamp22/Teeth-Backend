using Microsoft.EntityFrameworkCore;
using Teeth.Application.Interfaces;
using Teeth.Domain.Models;
using Teeth.Domain.Models.Lookups;

namespace Teeth.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), IAppDbContext
{
    // Users
    public DbSet<User> Users => Set<User>();

    // Clinic 
    public DbSet<Clinic> Clinics => Set<Clinic>();
    public DbSet<ClinicContract> ClinicContracts => Set<ClinicContract>();
    public DbSet<ClinicCredentials> ClinicCredentials => Set<ClinicCredentials>();

    // RBAC
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<Role> Roles => Set<Role>();

    // Appointment
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<Schedule> Schedules => Set<Schedule>();

    // Finance
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<PaymentDues> PaymentDues => Set<PaymentDues>();

    // cosmetics
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Delivery> Deliveries => Set<Delivery>();

    // Lookups
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<Coupon> Coupons => Set<Coupon>();
    public DbSet<Feedback> Feedbacks => Set<Feedback>();

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return base.SaveChangesAsync();
    }

}