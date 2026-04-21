namespace Domain.Entities.App.Contact;

public sealed class AppContactEntity
{
    public string SupportEmail { get; private set; } = string.Empty;
    public string ContactEmail { get; private set; } = string.Empty;
    public string? PhoneNumber { get; private set; }
    public string? City { get; private set; }
    public string? Country { get; private set; }

    private AppContactEntity() { }

    public AppContactEntity(string supportEmail, string contactEmail)
    {
        SupportEmail = supportEmail.Trim().ToLowerInvariant();
        ContactEmail = contactEmail.Trim().ToLowerInvariant();
    }
}