using Domain.Enums.App;
using System.Net.NetworkInformation;

namespace Domain.Entities.App.Status;

public sealed class AppStatusEntity
{
    public AppStatus Status { get; private set; } = AppStatus.Active;
    public string? MaintenanceMessage { get; private set; }

    private AppStatusEntity() { }

    public AppStatusEntity(AppStatus status = AppStatus.Active)
    {
        Status = status;
    }
}