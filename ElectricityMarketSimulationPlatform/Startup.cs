//刘祺注释
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using ElectricityMarketSimulationPlatform.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

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

            services.AddDbContext<MarketUserDbContext>(options =>
            {
                options.UseMySql(connectionString);
            });
            services.AddDbContext<HeavyContext>(options =>
            {
                options.UseMySql(connectionString);
            });
            services.AddIdentity<MarketUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
            }).AddEntityFrameworkStores<MarketUserDbContext>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("操作角色权限", polciy => polciy.RequireAssertion(context =>
                {
                    if (context.User.IsInRole("系统管理员"))
                    { return true; }
                    else
                    { return false; }
                }));
            });
            services.AddScoped<IGenerationCompanyInfoService, GenerationCompanyInfoEfService>();
            services.AddScoped<IThermalUnitInfoService, ThermalUnitInfoEfService>();
            services.AddScoped<IRetailCompanyInfoService, RetailCompanyInfoEfService>();
            services.AddScoped<ILargeUserInfoService, LargeUserInfoEfService>();
            services.AddScoped<IScatteredUserInfoService, ScatteredUserInfoEfService>();
            services.AddScoped<IMarketService, MarketEfService>();
            services.AddScoped<IMarketJoinService, MarketJoinEfService>();
            services.AddScoped<IMarketResultService, MarketResultEfService>();
            services.AddScoped<IAgencyService, AgencyEfService>();
            services.AddScoped<IBuyOrderService, BuyOrderEfService>();
            services.AddScoped<ISellOrderService, SellOrderEfService>();
            services.AddScoped<IHistroyOrderService, HistroyOrderEfService>();


            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.LoginPath = "/Identity/Account/Login";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                   );
                //与asp.net core 2.x不同，使用razor pages时需要加入此程序
                endpoints.MapRazorPages();
            });
        }
    }
}
