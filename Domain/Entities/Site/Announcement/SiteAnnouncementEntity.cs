namespace Domain.Entities.Site.Announcement;

public sealed class SiteAnnouncementEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Title { get; private set; } = string.Empty;
    public string Content { get; private set; } = string.Empty;
    public string? ImageUrl { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public DateTimeOffset PublishedAt { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteAnnouncementEntity() { }

    public SiteAnnouncementEntity(
        string title,
        string content,
        string? imageUrl = null)
    {
        Title = title.Trim();
        Content = content.Trim();
        ImageUrl = imageUrl;
        PublishedAt = DateTimeOffset.UtcNow;
        CreatedAt = DateTimeOffset.UtcNow;
    }
}