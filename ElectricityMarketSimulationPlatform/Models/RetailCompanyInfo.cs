using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// RetailCompanyInfo表单主要用于存储售电公司信息
    /// </summary>
    public class RetailCompanyInfo
    {
        [Display(Name = "售电公司ID")]
        public string RetailID { get; set; }
        
        [Display(Name = "所属城市")]
        public string City { get; set; }

        [Display(Name = "联系方式")]
        public string ContactInfo { get; set; }
    }
}
