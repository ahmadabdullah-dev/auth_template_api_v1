namespace Domain.Entities.Site.Testimonial;

public sealed class SiteTestimonialEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string AuthorName { get; private set; } = string.Empty;
    public string AuthorTitle { get; private set; } = string.Empty;
    public string? AuthorAvatarUrl { get; private set; }
    public string? AuthorCompany { get; private set; }
    public string Quote { get; private set; } = string.Empty;
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteTestimonialEntity() { }

    public SiteTestimonialEntity(
        string authorName,
        string authorTitle,
        string quote,
        int displayOrder,
        string? authorAvatarUrl = null,
        string? authorCompany = null)
    {
        AuthorName = authorName.Trim();
        AuthorTitle = authorTitle.Trim();
        Quote = quote.Trim();
        DisplayOrder = displayOrder;
        AuthorAvatarUrl = authorAvatarUrl;
        AuthorCompany = authorCompany?.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}