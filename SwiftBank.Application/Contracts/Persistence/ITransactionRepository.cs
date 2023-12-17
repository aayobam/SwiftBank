using SwiftBank.Domain.Entities;

namespace SwiftBank.Application.Contracts.Persistence;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    
}