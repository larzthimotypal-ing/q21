using System;
using Michelles_School_For_Gifted_Youngsters.Areas.Identity.Data;
using Michelles_School_For_Gifted_Youngsters.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Michelles_School_For_Gifted_Youngsters.Areas.Identity.IdentityHostingStartup))]
namespace Michelles_School_For_Gifted_Youngsters.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StudentPotalDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("StudentPotalDbContextConnection")));

                services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<StudentPotalDbContext>();
            });
        }
    }
}