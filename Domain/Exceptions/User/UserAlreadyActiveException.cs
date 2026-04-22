using Domain.Exceptions.Common;

namespace Domain.Exceptions.User;

public sealed class UserAlreadyActiveException : DomainException
{
    public Guid UserId { get; }

    public UserAlreadyActiveException(Guid userId): base($"User with ID '{userId}' is already active.")
    {
        UserId = userId;
    }
}
