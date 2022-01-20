using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Method
    {
        [Key]
        public string MethodId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Method")]
        public string Name { get; set; }



        // Naviagation property for Many-to-Many Relationship
        public ICollection<MethodCategory> MethodCategories { get; set; }

        
        public ICollection<EmployeeMethod> EmployeeMethods { get; set; }

    }
        
    
}


