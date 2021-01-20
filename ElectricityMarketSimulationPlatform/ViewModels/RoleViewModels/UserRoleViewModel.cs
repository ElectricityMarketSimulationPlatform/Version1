using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ElectricityMarketSimulationPlatform.ViewModels
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<IdentityUser>();
        }
        public string UserId { get; set; }
        public string RoleId { get; set; }

        //候选用户
        public List<IdentityUser> Users { get; set; }
    }
}