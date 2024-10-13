using MediatR;
using Teeth.Application.Interfaces;
using Teeth.Domain.Helpers;
using Teeth.Domain.Models;
using static Teeth.Domain.Helpers.Enums;

namespace Teeth.Application.Services.Commands.UserCommandHandlers;

public class RegisterUserCommand : MediatR.IRequest<User>
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Phone { get; set; }
    public required string Address { get; set; }
    public GenderEnum Gender { get; set; }
    public string? Image { get; set; }
    public DateTimeOffset? BirthDate { get; set; }
}

public class RegisterUserCommandHandler : MediatR.IRequestHandler<RegisterUserCommand, User>
{
    private readonly IAppDbContext _context;

    public RegisterUserCommandHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Name = request.Name,
            Email = request.Email,
            Password = HashPassword(request.Password),
            Phone = request.Phone,
            Address = request.Address,
            Image = request.Image ?? "",

        };
        if (IsEmailExist(request.Email))
        {
            throw new Exception("Email already exists");
        }
        // Add user to context and save changes
        _context.Users.Add(user);
        await _context.SaveChangesAsync(cancellationToken);

        return user;
    }

    private bool IsEmailExist(string email)
    {
        return _context.Users.Any(u => u.Email == email);
    }

    private string HashPassword(string password)
    {
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        return hashedPassword;
    }

    private bool verifyPassword(string password, string hashedPass)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPass);
    }
}
