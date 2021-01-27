using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// LargeUserInfo表单主要用于存储大用户公司信息
    /// </summary>
    public class LargeUserInfo
    {
        [Key]
        [Required]
        [Display(Name = "大用户ID")]
        public string LargeUserID { get; set; }

        [Required]
        [Display(Name = "所属城市")]
        public string City { get; set; }

        [Display(Name = "所在节点")]
        public int NodeNo { get; set; }

        [Display(Name = "接入电压等级")]
        public int VoltageLevel { get; set; }

        [Required]
        [Display(Name = "行业分类")]
        public string IndustryCategory { get; set; }

        [Required]
        [Display(Name = "用电地址")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "所属供电公司")]     
        public string SupplyCompany { get; set; }
    }
}
