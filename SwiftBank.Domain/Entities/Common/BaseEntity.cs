namespace SwiftBank.Domain.Entities.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }

    public BaseEntity()
    {
        DateCreated = DateTime.Now;
        DateModified = DateTime.Now;
    }
}
