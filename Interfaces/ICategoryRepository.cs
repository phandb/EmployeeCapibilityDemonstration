using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        //  Its own method
        ICollection<Category> GetEmployeesByCategory(string categoryId);
    }
}
