namespace Domain.Entities.App.Seo;

public sealed class SiteSeoEntity
{
    public string? MetaTitle { get; private set; }
    public string? MetaDescription { get; private set; }
    public string? MetaKeywords { get; private set; }
    public string? OpenGraphImageUrl { get; private set; }
    public string? GoogleAnalyticsId { get; private set; }
    public string? GoogleTagManagerId { get; private set; }
    public bool IndexingEnabled { get; private set; } = true;


    public SiteSeoEntity() { }
}