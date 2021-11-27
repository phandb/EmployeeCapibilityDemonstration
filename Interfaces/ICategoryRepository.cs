using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        ICollection<Category> GetEmployeesByCategory(string categoryId);
    }
}
