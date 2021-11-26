using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }

        // Navigation Property for Many-to-Many Relationship
        public virtual ICollection<Method> Methods { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        // Constructor
        public Employee()
        {
            this.Methods = new List<Method>();
            this.Categories = new List<Category>();
        }
    }
}
