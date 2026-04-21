namespace Domain.Entities.Site.Partner;

public sealed class SitePartnerEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Name { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public string? LogoUrl { get; private set; }
    public string? WebsiteUrl { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SitePartnerEntity() { }

    public SitePartnerEntity(
        string name,
        int displayOrder,
        string? description = null,
        string? logoUrl = null,
        string? websiteUrl = null)
    {
        Name = name.Trim();
        DisplayOrder = displayOrder;
        Description = description?.Trim();
        LogoUrl = logoUrl;
        WebsiteUrl = websiteUrl;
        CreatedAt = DateTimeOffset.UtcNow;
    }
}