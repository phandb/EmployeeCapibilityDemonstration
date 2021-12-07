using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Models
{
    public class EmployeeMethod : IdentityUser    {
        public string MethodId { get; set; }
        public Employee Employee { get; set; }
        public Method Method { get; set; }

    }
}
