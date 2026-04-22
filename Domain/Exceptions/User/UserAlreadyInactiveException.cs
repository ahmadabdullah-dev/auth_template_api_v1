using Domain.Exceptions.Common;

namespace Domain.Exceptions.User;

public sealed class UserAlreadyInactiveException : DomainException
{
    public Guid UserId { get; }

    public UserAlreadyInactiveException(Guid userId) : base($"User with ID '{userId}' is already inactive.")
    {
        UserId = userId;
    }
}
