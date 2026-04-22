namespace Domain.Exceptions.Common;

public sealed class NotFoundException : DomainException
{
    public NotFoundException(string resourceName, object identifier)  : base($"{resourceName} with identifier '{identifier}' was not found.")
    {
    }
    
    public NotFoundException(string message) : base(message)
    {
    }
}
