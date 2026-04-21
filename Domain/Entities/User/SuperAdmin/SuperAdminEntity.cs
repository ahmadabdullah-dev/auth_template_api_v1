using Domain.Entities.User.Base;
namespace Domain.Entities.User.SuperAdmin;

public sealed class SuperAdminEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string UserId { get; private set; } = string.Empty;
    public string? EmergencyContactEmail { get; private set; }
    public DateTimeOffset AssignedAt { get; private set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? LastPrivilegedActionAt { get; private set; }

    public UserEntity User { get; private set; } = null!;

    private SuperAdminEntity() { }

    public SuperAdminEntity(string userId, string? emergencyContactEmail = null)
    {     
        UserId = userId;
        EmergencyContactEmail = emergencyContactEmail?.Trim().ToLowerInvariant();
    }
}