using Domain.Entities.User.Base;

namespace Domain.Entities.User;

public sealed class AdminEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string UserId { get; private set; } = string.Empty;

    public string Department { get; private set; } = string.Empty;
    public string Title { get; private set; } = string.Empty;
    public string? Location { get; private set; }
    public DateTimeOffset AssignedAt { get; private set; } = DateTimeOffset.UtcNow;
    public UserEntity User { get; private set; } = null!;

    private AdminEntity() { }

    public AdminEntity(string userId, string department, string title)
    {
        UserId = userId;
        Department = department.Trim();
        this.Title = title.Trim();
    }
}