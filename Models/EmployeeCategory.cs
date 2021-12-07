using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Models
{
    public class EmployeeCategory : IdentityUser
    {
        public string CategoryId { get; set; }
        public Employee Employee { get; set; }
        public Category Category { get; set; }
    }
}
