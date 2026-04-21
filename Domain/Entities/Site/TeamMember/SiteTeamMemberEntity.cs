namespace Domain.Entities.Site.TeamMember;

public sealed class SiteTeamMemberEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string FullName { get; private set; } = string.Empty;
    public string Role { get; private set; } = string.Empty;
    public string? Bio { get; private set; }
    public string? AvatarUrl { get; private set; }
    public string? Email { get; private set; }
    public string? LinkedInUrl { get; private set; }
    public string? GitHubUrl { get; private set; }
    public string? TwitterUrl { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteTeamMemberEntity() { }

    public SiteTeamMemberEntity(
        string fullName,
        string role,
        int displayOrder,
        string? bio = null,
        string? avatarUrl = null,
        string? email = null)
    {
        FullName = fullName.Trim();
        Role = role.Trim();
        DisplayOrder = displayOrder;
        Bio = bio?.Trim();
        AvatarUrl = avatarUrl;
        Email = email?.Trim().ToLowerInvariant();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}