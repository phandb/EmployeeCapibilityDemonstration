using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Method
{
    public class MethodCreateViewModel
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Method")]
        public string Name { get; set; }


        /*
        [Required, Display(Name = "Category")]
        public string SelectedCategory { get; set; }
        public ICollection<SelectListItem> Categories { get; set; }
        */
    }
}
