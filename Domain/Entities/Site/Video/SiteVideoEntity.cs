using Domain.Enums.Site;

namespace Domain.Entities.Site.Video;


public sealed class SiteVideoEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public string Url { get; private set; } = string.Empty;
    public string? ThumbnailUrl { get; private set; }
    public VideoProvider Provider { get; private set; }
    public string? Category { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteVideoEntity() { }

    public SiteVideoEntity(
        string title,
        string url,
        VideoProvider provider,
        int displayOrder,
        string? description = null,
        string? thumbnailUrl = null,
        string? category = null)
    {
        Title = title.Trim();
        Url = url.Trim();
        Provider = provider;
        DisplayOrder = displayOrder;
        Description = description?.Trim();
        ThumbnailUrl = thumbnailUrl;
        Category = category?.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}