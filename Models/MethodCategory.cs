using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    // This is pure join table (no payload) in many to many relationship
    public class MethodCategory 
    {
        [Key]
        public string MethodCategoryId { get; set; }
        public string MethodId { get; set; }
        public string CategoryId { get; set; }
        public Method Method { get; set; }
        public Category Category { get; set; }
    }
}
