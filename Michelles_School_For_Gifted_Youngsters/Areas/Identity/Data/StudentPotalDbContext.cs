using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Michelles_School_For_Gifted_Youngsters.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Michelles_School_For_Gifted_Youngsters.Data
{
    public class StudentPotalDbContext : IdentityDbContext<AppUser>
    {
        public StudentPotalDbContext(DbContextOptions<StudentPotalDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
