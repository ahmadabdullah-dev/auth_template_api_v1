namespace Domain.Entities.App.Identity;

public sealed class AppIdentityEntity
{
    public string Name { get; private set; } = string.Empty;
    public string Slug { get; private set; } = string.Empty;
    public string Tagline { get; private set; } = string.Empty;
    public string ShortDescription { get; private set; } = string.Empty;
    public string FullDescription { get; private set; } = string.Empty;
    public string Version { get; private set; } = string.Empty;

    private AppIdentityEntity() { }

    public AppIdentityEntity(
        string name,
        string slug,
        string tagline,
        string shortDescription,
        string fullDescription,
        string version = "1.0.0")
    {
        Name = name.Trim();
        Slug = slug.Trim().ToLowerInvariant();
        Tagline = tagline.Trim();
        ShortDescription = shortDescription.Trim();
        FullDescription = fullDescription.Trim();
        Version = version.Trim();
    }
}