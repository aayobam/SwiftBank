using SwiftBank.Domain.Entities;

namespace SwiftBank.Application.Contracts.Persitence;

public interface IGenericRepository<T> where T: class
{
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(string id, T entity);
    Task<T> DeleteAsync(T entity);
    Task<T> GetAllAsync();
    Task<T> GetByIdAsync(string id);
}


public interface IApplicationUserRepository: IGenericRepository(ApplicationUser)
{
    
}

public interface IGenericRepository<T> where T: class
{
    
}

public interface IGenericRepository<T> where T: class
{
    
}

public interface IGenericRepository<T> where T: class
{
    
}

public interface IGenericRepository<T> where T: class
{
    
}
