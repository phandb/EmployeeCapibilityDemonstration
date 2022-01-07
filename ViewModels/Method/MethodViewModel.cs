using EmployeeCapibilityDemonstration.ViewModels.Category;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Method
{
    public class MethodViewModel
    {
        [Key]
        public string? MethodId { get; set; }

        [Required]
        [Display(Name = "Method Name")]
        public string? Name { get; set; }

        public CategoryViewModel CategoryVM { get; set; }


        // Two fields provided for dropdown list. 
        // one for the selected item
        // One for the list which is made up of a collection of SelectListItem
        /*
        [Required, Display(Name = "Category")]
        public string SelectedCategory { get; set; }
        public ICollection<SelectListItem> Categories{ get; set; }

        */

    }
}
