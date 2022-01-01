using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        //  Its own method
        ICollection<Category> GetEmployeesByCategory(string categoryId);

        IEnumerable<SelectListItem> GetCategories();
    }
}
