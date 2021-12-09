using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Method
{
    public class MethodViewModel
    {
        [Key]
        public string ? MethodId { get; set; }

        [Required]
        [Display(Name = "Method Name")]
        public string? Name { get; set; }

        // public List<MethodViewModel> EmployeesByMethod { get; set; }
    }
}
