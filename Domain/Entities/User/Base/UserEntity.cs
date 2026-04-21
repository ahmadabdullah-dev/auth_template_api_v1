using Domain.Entities.User.SuperAdmin;
using Domain.Enums.User.Base;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.User.Base;

public sealed class UserEntity : IdentityUser
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";
    public DateOnly DateOfBirth { get; private set; }
    public UserRole Role { get; private set; } = UserRole.Member;

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTimeOffset? DeletedAt { get; private set; }

    public string? RefreshTokenHash { get; private set; }
    public DateTimeOffset? RefreshTokenExpiry { get; private set; }

    public string? VerificationCodeHash { get; private set; }
    public DateTimeOffset? VerificationCodeExpiry { get; private set; }
    public int VerificationAttempts { get; private set; }
    public bool IsVerified { get; private set; }

    public MemberEntity? MemberEntity { get; private set; }
    public AdminEntity? AdminEntity { get; private set; }
    public SuperAdminEntity? SuperAdminEntity { get; private set; }

    private UserEntity() { }

    public UserEntity(string email, string firstName, string lastName, DateOnly dateOfBirth, UserRole role = UserRole.Member)
    {
        Email = email.Trim().ToLowerInvariant();
        UserName = Email;
        FirstName = firstName.Trim();
        LastName = lastName.Trim();
        DateOfBirth = dateOfBirth;
        Role = role;
        CreatedAt = DateTimeOffset.UtcNow;
    }
}