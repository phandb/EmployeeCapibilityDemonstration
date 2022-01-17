using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HiredDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TakenDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiredDate { get; set; } = DateTime.Now;

        // Navigation Property for Many-to-Many Relationship
        public ICollection<EmployeeMethod>? EmployeeMethods { get; set; }

        // Navigation property 
         public ICollection<EmployeeCategory>? EmployeeCategories { get; set; }

       
    }
}
