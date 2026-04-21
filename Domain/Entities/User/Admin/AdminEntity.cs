using Domain.Entities.User.Base;

namespace Domain.Entities.User;

public sealed class AdminEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string UserId { get; private set; } = string.Empty;

    public string Department { get; private set; } = string.Empty;
    public string JobTitle { get; private set; } = string.Empty;
    public string? OfficeLocation { get; private set; }
    public DateTimeOffset AssignedAt { get; private set; } = DateTimeOffset.UtcNow;
    public UserEntity User { get; private set; } = null!;

    private AdminEntity() { }

    public AdminEntity(string userId, string department, string jobTitle)
    {
        UserId = userId;
        Department = department.Trim();
        JobTitle = jobTitle.Trim();
    }
}