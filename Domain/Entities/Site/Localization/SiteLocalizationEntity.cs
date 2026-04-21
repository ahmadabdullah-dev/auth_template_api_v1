namespace Domain.Entities.Site.Localization;

public sealed class SiteLocalizationEntity
{
    public string DefaultLanguage { get; private set; } = "en";
    public string DefaultTimezone { get; private set; } = "UTC";
    public string DefaultCurrency { get; private set; } = "USD";
    public bool IsRtl { get; private set; }

    private SiteLocalizationEntity() { }

    public SiteLocalizationEntity(
        string defaultLanguage = "en",
        string defaultTimezone = "UTC",
        string defaultCurrency = "USD",
        bool isRtl = false)
    {
        DefaultLanguage = defaultLanguage.Trim();
        DefaultTimezone = defaultTimezone.Trim();
        DefaultCurrency = defaultCurrency.Trim();
        IsRtl = isRtl;
    }
}