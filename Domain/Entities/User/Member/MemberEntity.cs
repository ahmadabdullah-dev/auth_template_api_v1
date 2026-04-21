using Domain.Entities.User.Base;

namespace Domain.Entities.User;

public sealed class MemberEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string UserId { get; private set; } = string.Empty;

    public string? Bio { get; private set; }
    public string? ProfilePictureUrl { get; private set; }
    public string? PhoneNumber { get; private set; }
    public string? Country { get; private set; }
    public DateTimeOffset JoinedAt { get; private set; } = DateTimeOffset.UtcNow;

    public UserEntity User { get; private set; } = null!;

    private MemberEntity() { }

    public MemberEntity(string userId)
    {
        UserId = userId;
    }
}