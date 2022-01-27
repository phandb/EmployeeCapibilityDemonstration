using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Employee;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IEmployeeMethodRepository : IGenericRepository<EmployeeMethod>
    {
        Task AddMethodToEmployee(EmployeeAddMethodViewModel model);   
    }
}
