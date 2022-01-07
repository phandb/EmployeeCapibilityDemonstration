using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.ViewModels.Method;

namespace EmployeeCapibilityDemonstration.ViewModels.Employee
{
    public class EmployeeDetailsViewModel : EmployeeListViewModel
    {
        public string Id { get; set; } 
        public string EmployeeId{ get; set; }    
        public List<MethodViewModel> EmployeeHasMethods { get; set; }
        public List<CategoryViewModel> MethodCategories { get; set; }

    }
}
