namespace Domain.Exceptions.Common;

public sealed class InvalidDomainOperationException : DomainException
{
    public string Operation { get; }
    public string Reason { get; }

    public InvalidDomainOperationException(string operation, string reason) : base($"Operation '{operation}' is invalid: {reason}")
    {
        Operation = operation;
        Reason = reason;
    }
}
