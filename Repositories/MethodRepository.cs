using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class MethodRepository :GenericRepository<Method>, IMethodRepository
    {
       

        // Initialize the DbContext via constructor
        public MethodRepository(ApplicationDbContext context) : base(context)
        {
           
        }

        public ICollection<Method> GetEmployeesByMethod(string methodId)
        {
            throw new NotImplementedException();
        }

    }
}
