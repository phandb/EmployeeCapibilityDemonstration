using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Category
{
    public class CategoryViewModel
    {
        [Key]
        public string? CategoryId { get; set; }

        [Required]
        [Display(Name="Category")]
        public string? Name { get; set; }
        //public List<CategoryViewModel> EmployeesByCategory { get; set; }
    }
}
