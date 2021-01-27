using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// ScatteredUserInfo表单主要用于存储零散用户信息
    /// </summary>
    public class ScatteredUserInfo
    {
        [Key]
        [Required]
        [Display(Name = "售电公司ID")]
        public string ScaID { get; set; }

        [Required]
        [Display(Name = "所属城市")]
        public string City { get; set; }
        
        [Required]
        [Display(Name = "所属电网企业")]
        public string GridCompany { get; set; }

        [Required]
        [Display(Name = "所属供电公司")]
        public string SupplyCompany { get; set; }

        // 零散用户必须由售电公司代理参与市场，零散用户在一个市场中只能请一个售电公司
        public RetailCompanyInfo RetailCompanies { get; set; }
    }
}
