using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Employee
{
    public class EmployeeAddMethodViewModel
    {
        public string Id { get; set; } 

        [Display(Name = "Employee ID ")]
        public string EmployeeId { get; set; } = String.Empty;

        [Display(Name = "Method ID ")]
        public string MethodId { get; set; }  //Key
        public IEnumerable<SelectListItem> Methods { get; set; } //Value


        [Display(Name = "Taken On")]
        public DateTime DateTaken { get; set; }


        [Display(Name = "Expired On")]
        public DateTime DateExpired
        {
            get
            {
                return DateTaken.AddDays(3);

            }
        }
        
        [Required]
        [Display(Name = "Category")]
        public string CategoryId{ get; set; } //Key
        public IEnumerable<SelectListItem> Categories { get; set; }  //value
        
    }
}
