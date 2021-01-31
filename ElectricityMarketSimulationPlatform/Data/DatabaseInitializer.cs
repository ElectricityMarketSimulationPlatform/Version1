using ElectricityMarketSimulationPlatform.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Data
{
    public class DatabaseInitializer
    {
        public static async Task Seed(MarketUserDbContext context, 
            UserManager<MarketUser> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            //如果系统中没有任何角色则先创建一些角色
            if (!context.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole("系统管理员"));
                await roleManager.CreateAsync(new IdentityRole("市场管理员"));
                await roleManager.CreateAsync(new IdentityRole("发电公司"));
                await roleManager.CreateAsync(new IdentityRole("售电公司"));
                await roleManager.CreateAsync(new IdentityRole("电力大用户"));
                await roleManager.CreateAsync(new IdentityRole("零散用户"));
            }
            //创建一个默认系统管理员用户
            if (!context.Users.Any())
            {
                var user = new MarketUser { UserName = "SystemAdmin"};
                string AdminPassword = "xjtu2021";
                await userManager.CreateAsync(user, AdminPassword);
                var createduser =await userManager.FindByNameAsync(user.UserName);
                await userManager.AddToRoleAsync(createduser, "系统管理员");
            }
        }
    }
}
