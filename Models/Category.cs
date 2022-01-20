using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Category
    {

        [Key]
        public string CategoryId { get; set; }

        [StringLength(50)]
        [Display(Name = "Category")]
        public string Name { get; set; }



        // Naviagation property for Many-to-Many Relationship
        public ICollection<MethodCategory> MethodCategories { get; set; }
       

    }
}
