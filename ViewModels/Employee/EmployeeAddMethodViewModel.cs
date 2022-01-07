using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Employee
{
    public class EmployeeAddMethodViewModel
    {
        [Display(Name = "Employee ID Number")]
        public string Id { get; set; } = String.Empty;
        
        [Required]
        [Display(Name = "Method")]
        public string SelectedMethod { get; set; }  //Key
        public IEnumerable<SelectListItem> Methods { get; set; } //Value

        [Required]
        [Display(Name = "Category")]
        public string SelectedCategory{ get; set; } //Key
        public IEnumerable<SelectListItem> Categories { get; set; }  //value

    }
}
