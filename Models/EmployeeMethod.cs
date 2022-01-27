using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.Models
{
    //  This join table has payloads: TakenDate, ExpiredDate.  
    //  They are characteristic of each method taken by employee
    public class EmployeeMethod : IdentityUser 
    {
        [Key]
        public string EmployeeMethodId { get; set; }

        // EmployeeId will be Identityuser.Id
        public string MethodId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TakenDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiredDate { get; set; }

        public Employee Employee { get; set; }
        public Method Method { get; set; }

    }
}
