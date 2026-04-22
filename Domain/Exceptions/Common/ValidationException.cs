namespace Domain.Exceptions.Common;

public sealed class ValidationException : DomainException
{
    public ValidationException(string message) : base(message)
    {
    }
}
