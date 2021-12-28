using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        //ICollection<Employee> GetMethodsByEmployee(string id);
        ICollection<Employee> GetMethodsByEmployee(Employee employee);
        ICollection<Employee> GetMethodsByEmployee(string employeeId);
        ICollection<Employee> GetCategoriesByEmployee(string employeeId);
        ICollection<Employee> GetCategoriesByEmployee(Employee employee);
    }
}
