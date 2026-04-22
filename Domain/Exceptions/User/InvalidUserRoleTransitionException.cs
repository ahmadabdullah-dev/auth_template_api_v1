using Domain.Enums.User;
using Domain.Enums.User.Base;
using Domain.Exceptions.Common;

namespace Domain.Exceptions.User;

public sealed class InvalidUserRoleTransitionException : DomainException
{
    public UserRole CurrentRole { get; }
    public UserRole AttemptedRole { get; }
    public string Reason { get; }

    public InvalidUserRoleTransitionException(UserRole currentRole, UserRole attemptedRole, string reason) : base($"Cannot transition user role from '{currentRole}' to '{attemptedRole}'. {reason}")
    {
        CurrentRole = currentRole;
        AttemptedRole = attemptedRole;
        Reason = reason;
    }
}
