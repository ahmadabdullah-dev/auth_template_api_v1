namespace Domain.Entities.App.Contact;

public sealed class SiteContactEntity
{
    public string SupportEmail { get; private set; } = string.Empty;
    public string ContactEmail { get; private set; } = string.Empty;
    public string? PhoneNumber { get; private set; }
    public string? City { get; private set; }
    public string? Country { get; private set; }

    private SiteContactEntity() { }

    public SiteContactEntity(string supportEmail, string contactEmail)
    {
        SupportEmail = supportEmail.Trim().ToLowerInvariant();
        ContactEmail = contactEmail.Trim().ToLowerInvariant();
    }
}