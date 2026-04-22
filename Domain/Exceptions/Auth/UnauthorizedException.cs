using Domain.Exceptions.Common;

namespace Domain.Exceptions.Auth;

public sealed class UnauthorizedException : DomainException
{
    public UnauthorizedException(string message) : base(message)
    {
    }
}
