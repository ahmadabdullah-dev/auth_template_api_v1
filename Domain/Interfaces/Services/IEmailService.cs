using Domain.ValueObjects;

namespace Domain.Interfaces.Services;

public interface IEmailService
{
    Task SendEmailAsync(Email to, string subject, string body, CancellationToken cancellationToken = default);
}
