using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IMethodRepository : IGenericRepository<Method>
    {
        ICollection<Method> GetEmployeesByMethod(string methodId);

        ICollection<Category> GetCategoriesByMethod(string methodId);

        Task<List<Category>> GetCategories();

    }
}
