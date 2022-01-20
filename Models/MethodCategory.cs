using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Models
{
    public class MethodCategory 
    {
        public string MethodId { get; set; }
        public string CategoryId { get; set; }
        public Method Method { get; set; }
        public Category Category { get; set; }
    }
}
