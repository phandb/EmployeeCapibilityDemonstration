using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Models
{
    // This is pure join table (no payload) in many to many relationship
    public class MethodCategory 
    {
        
        public string MethodId { get; set; }
        public string CategoryId { get; set; }
        public Method Method { get; set; }
        public Category Category { get; set; }
    }
}
