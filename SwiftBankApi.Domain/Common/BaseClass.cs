namespace SwiftBankApi.Domain.Common;

public abstract class BaseClass
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}