using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    public class Employee : IdentityUser
    {
        // EmployeeId will be Identityuser.Id


        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName 
        {
            get { return FirstName + " " + LastName; }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HiredDate { get; set; } 

        

        // Navigation Property for Many-to-Many Relationship
        public ICollection<EmployeeMethod> EmployeeMethods { get; set; }

        

       
    }
}
