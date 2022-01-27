using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Employee;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<EmployeeDetailsViewModel> GetEmployeeMethods(string employeeId);
        Task<EmployeeDetailsViewModel> GetEmployeeDetail();
        Task AddAsync(EmployeeMethod methodAdded);
        Task<EmployeeAddMethodViewModel> PopulateMethodsDropDownList();
    }
}
