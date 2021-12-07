using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Category
    {

        [Key]
        public string CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        // Naviagation property for Many-to-Many Relationship
        public ICollection<EmployeeCategory> EmployeeCategories { get; set; }

        
    }
}
