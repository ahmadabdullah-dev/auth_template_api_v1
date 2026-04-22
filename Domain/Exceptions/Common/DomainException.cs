namespace Domain.Exceptions.Common;

public abstract class DomainException : Exception
{
    protected DomainException(string message) : base(message)
    {
    }
}
