using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// MarketUser表单记录的是平台的用户数据，此表单的数据包括所有的用户
    /// </summary>
    public class MarketUser
    {
        // [Display(Name = "验证失败次数")]
        // public int AccessFailedCount { get; set; }
        
        [Display(Name = "公司名称")]
        public string CompanyName { get; set; }

        [Display(Name = "申请角色名")]
        public string ApplyRole { get; set; }
        
        [Display(Name = "市场角色")]
        public string MarketRole { get; set; }

        [Display(Name = "信用等级")]
        public Enum  CreditLevel { get; set; }


    }
}
