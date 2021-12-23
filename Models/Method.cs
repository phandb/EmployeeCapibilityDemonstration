using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Method
    {
        [Key]
        public string MethodId { get; set; }

        [Required]
        public string Name { get; set; }

        //  public string Type { get; set; }
        //public DateTime DateTaken { get; set; }
        //public DateTime ExpiredOn { get; set; }

        // Navigation property one to many relationship with category
        // One method has many catgories
        public ICollection<Category> Categories { get; set; }

        // Naviagation property for Many-to-Many Relationship
        public ICollection<EmployeeMethod> EmployeeMethods { get; set; }

    }
        
    
}


