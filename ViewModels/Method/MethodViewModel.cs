using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Method
{
    public class MethodViewModel
    {
        [Key]
        public string Id { get; set; }
        public string? MethodId { get; set; }

        [Required]
        [Display(Name = "Method")]
        public string Name { get ; set; }


        [Display(Name = "Taken On")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Expired On")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateExpired
        {
            get
            {
                return DateTaken.AddDays(3);
            }
        }

    }
}
