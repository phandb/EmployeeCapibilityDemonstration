using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        ICollection<Category> GetEmployeesByCategory(string categoryId);
    }
}
