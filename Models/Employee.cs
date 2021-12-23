using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime HiredDate { get; set; } = DateTime.Now;

        public DateTime TakenDate { get; set; } = DateTime.Now;
        public DateTime ExpiredDate { get; set; } = DateTime.Now;

        // Navigation Property for Many-to-Many Relationship
        public ICollection<EmployeeMethod> EmployeeMethods { get; set; }

       // public ICollection<EmployeeCategory> EmployeeCategories { get; set; }

       
    }
}
