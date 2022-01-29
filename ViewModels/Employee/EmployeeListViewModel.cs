using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Employee
{
    public class EmployeeListViewModel
    {
        public string Id { get; set; } = String.Empty;

        [Display(Name = "First Name")]
        public string firstName { get; set; } = String.Empty;

        [Display(Name = "Last Name")]
        public string lastName { get; set; } = String.Empty;

       
        

        [Display(Name = "Hired Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime dateHired { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; } = String.Empty;

    }
}
