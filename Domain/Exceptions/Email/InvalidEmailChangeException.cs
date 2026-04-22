using Domain.Exceptions.Common;

namespace Domain.Exceptions.Email;

public sealed class InvalidEmailChangeException : DomainException
{
    public string CurrentEmail { get; }
    public string AttemptedEmail { get; }

    public InvalidEmailChangeException(string currentEmail, string attemptedEmail) : base($"Cannot change email from '{currentEmail}' to '{attemptedEmail}'. Emails must be different.")
    {
        CurrentEmail = currentEmail;
        AttemptedEmail = attemptedEmail;
    }
}
