using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Method;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IMethodRepository : IGenericRepository<Method>
    {
        ICollection<Method> GetEmployeesByMethod(string methodId);

        ICollection<Category> GetCategoriesByMethod(string methodId);

        IEnumerable<SelectListItem> GetMethods();
        IEnumerable<SelectListItem> GetCategories();
        //MethodViewModel CreateMethod();

    }
}
