using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.ViewModels.Method;

namespace EmployeeCapibilityDemonstration.ViewModels.Employee
{
    public class EmployeeDetailsViewModel : EmployeeListViewModel
    {
        public string EmployeeId  { get; set; } = string.Empty;
        public List<MethodViewModel> EmployeeHasMethods { get; set; }
        //public <List<CategoryViewModel>> MethodCategories { get; set; }

    }
}
