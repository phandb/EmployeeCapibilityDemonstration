namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //  CRUD
        Task<T> AddAsync(T entity);

        //Task<T> AddOrUpdateAsync(T entity);
        Task<List<T>> GetAllAsync();
        
        Task<T> GetByIdAsync(string? id);
        Task UpdateAsync(T entity);

        Task DeleteAsync(string id);
        Task<bool> Exists(string id);

    }
}
