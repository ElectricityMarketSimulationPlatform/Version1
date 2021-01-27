using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// MarketUser表单记录的是平台的用户数据，此表单的数据包括所有的用户
    /// </summary>
    public class MarketUser: IdentityUser

    {
        [Required] 
        [Display(Name = "公司名称")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "申请角色名")]
        public string ApplyRole { get; set; }

        [Required]
        [Display(Name = "市场角色")]
        public string MarketRole { get; set; }

        [Display(Name = "信用等级")] 
        public Credit CreditLevel { get; set; }

        public enum Credit
        {
             AAA, AA, A, BBB, BB, B, CCC, CC, C, D
        }
    }
}
