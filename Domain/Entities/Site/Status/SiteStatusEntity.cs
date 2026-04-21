using Domain.Enums.Site;

namespace Domain.Entities.App.Status;

public sealed class SiteStatusEntity
{
    public SiteStatus Status { get; private set; } = SiteStatus.Active;
    public string? MaintenanceMessage { get; private set; }

    private SiteStatusEntity() { }

    public SiteStatusEntity(SiteStatus status = SiteStatus.Active)
    {
        Status = status;
    }
}