using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Category
    {

        [Key]
        public string CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Method> Method { get; set; }

        // Navigation property of One Method Many Category relationship

        // public string? MethodId { get; set; }
        // public Method Method  { get; set; }

        // Naviagation property for Many-to-Many Relationship
        // public ICollection<EmployeeCategory> EmployeeCategories { get; set; }


    }
}
