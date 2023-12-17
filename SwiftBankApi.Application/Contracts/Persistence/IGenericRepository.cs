namespace SwiftBankApi.Application.Contracts.Persistence;

public interface IGenericRepository<T>
{
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<T> GetAllAsync();
    Task<T> GetByIdAsync(string id);
}