namespace Domain.Entities.Site.Tag;

public sealed class SiteTagEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Name { get; private set; } = string.Empty;
    public string Slug { get; private set; } = string.Empty;
    public string? Color { get; private set; }

    public DateTimeOffset CreatedAt { get; }

    private SiteTagEntity() { }

    public SiteTagEntity(string name, string slug, string? color = null)
    {
        Name = name.Trim();
        Slug = slug.Trim().ToLowerInvariant();
        Color = color?.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}