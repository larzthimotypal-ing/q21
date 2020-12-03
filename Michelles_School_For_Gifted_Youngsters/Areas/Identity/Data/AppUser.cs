using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq;
using System.Threading.Tasks;
using Michelles_School_For_Gifted_Youngsters.Models;
using Microsoft.AspNetCore.Identity;

namespace Michelles_School_For_Gifted_Youngsters.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AppUser class
    public class AppUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string UserRole { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string HomeAddress { get; set; }

        public int? GradesID { get; set; }
        public StudentGrades StudentGrades { get; set; }
    }

}
