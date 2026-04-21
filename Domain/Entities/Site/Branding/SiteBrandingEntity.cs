namespace Domain.Entities.App.Branding;

public sealed class SiteBrandingEntity
{
    public string? LogoUrl { get; private set; }
    public string? FaviconUrl { get; private set; }
    public string? PrimaryColor { get; private set; }
    public string? SecondaryColor { get; private set; }
    public string? AccentColor { get; private set; }

    private SiteBrandingEntity() { }

    public SiteBrandingEntity(
        string? logoUrl = null,
        string? logoDarkUrl = null,
        string? faviconUrl = null,
        string? bannerUrl = null,
        string? primaryColor = null,
        string? secondaryColor = null,
        string? accentColor = null)
    {
        LogoUrl = logoUrl;
        FaviconUrl = faviconUrl;
        PrimaryColor = primaryColor;
        SecondaryColor = secondaryColor;
        AccentColor = accentColor;
    }
}