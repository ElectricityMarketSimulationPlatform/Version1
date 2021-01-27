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
        [Key]
        [Display(Name = "售电公司ID")]
        public string RetailID { get; set; }

        [Required]
        [Display(Name = "所属城市")]
        public string City { get; set; }

        [Required]
        [Display(Name = "联系方式")]
        public string ContactInfo { get; set; }

        /// <summary>
        /// 售电公司与市场之间的多对多关系通过MarketJoin来实现
        /// </summary>
        public List<MarketJoin> MarketJoins { get; set; }

        public List<LargeUserInfo> LargeUsers { get; set; }

        public List<ScatteredUserInfo> ScatteredUsers { get; set; }
    }
}
