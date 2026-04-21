namespace Domain.Entities.Site.Review;

public sealed class SiteReviewEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string ReviewerName { get; private set; } = string.Empty;
    public string ReviewerTitle { get; private set; } = string.Empty;
    public string? ReviewerAvatarUrl { get; private set; }
    public string? ReviewerCompany { get; private set; }
    public string Content { get; private set; } = string.Empty;
    public int Rating { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteReviewEntity() { }

    public SiteReviewEntity(
        string reviewerName,
        string reviewerTitle,
        string content,
        int rating,
        int displayOrder,
        string? reviewerAvatarUrl = null,
        string? reviewerCompany = null)
    {
        ReviewerName = reviewerName.Trim();
        ReviewerTitle = reviewerTitle.Trim();
        Content = content.Trim();
        Rating = rating;
        DisplayOrder = displayOrder;
        ReviewerAvatarUrl = reviewerAvatarUrl;
        ReviewerCompany = reviewerCompany?.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}