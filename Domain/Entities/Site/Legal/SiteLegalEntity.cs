namespace Domain.Entities.App.Legal;

public sealed class SiteLegalEntity
{
    public string LegalName { get; private set; } = string.Empty;
    public string? PrivacyPolicyUrl { get; private set; }
    public string? TermsOfServiceUrl { get; private set; }
    public string? CookiePolicyUrl { get; private set; }

    private SiteLegalEntity() { }

    public SiteLegalEntity(string legalName)
    {
        LegalName = legalName.Trim();
    }
}