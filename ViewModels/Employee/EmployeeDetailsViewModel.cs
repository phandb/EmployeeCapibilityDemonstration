using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.ViewModels.Method;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Employee
{
    public class EmployeeDetailsViewModel : EmployeeListViewModel
    {
        public string Id { get; set; } 
        public string EmployeeId{ get; set; }

        public string MethodId { get; set; }


        public List<MethodViewModel> Methods { get; set; }
        //public List<CategoryViewModel>? Categories { get; set; }
    }
}
