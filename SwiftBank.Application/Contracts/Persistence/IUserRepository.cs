using SwiftBank.Domain.Entities;

namespace SwiftBank.Application.Contracts.Persistence;

public interface IUserRepository: IGenericRepository<User>
{
   Task<bool> IsUserEmailUnique(string emailAddress);
}
