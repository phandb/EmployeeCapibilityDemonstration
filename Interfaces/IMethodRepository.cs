using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IMethodRepository : IRepositoryBase<Method>
    {
        ICollection<Method> GetEmployeesByMethod(string methodId);
    }
}
