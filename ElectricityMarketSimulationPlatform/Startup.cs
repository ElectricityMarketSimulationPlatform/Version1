using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
//刘祺注释
namespace ElectricityMarketSimulationPlatform
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc();

            var connectionString = _configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<ApplicationUserDbContext>(options =>
            {
                options.UseMySql(connectionString);
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
            })
                .AddEntityFrameworkStores<ApplicationUserDbContext>();
        }
 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //与asp.net core 2.x不同，使用razor pages时需要加入此程序
                endpoints.MapRazorPages();
            });
        }
    }
}
