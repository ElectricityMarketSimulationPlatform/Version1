using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// Agency表单用于代理大用户的数据存储
    /// </summary>
    public class Agency
    {
        [Key]
        [Display(Name = "代理关系ID")]
        public int AgentID { get; set; }

        [Required]
        [Display(Name = "售电公司ID")]
        public string RetailID { get; set; }

        [Required]
        [Display(Name = "用户ID")] 
        public string UserID { get; set; }

        [Display(Name = "市场ID")]
        public int MarketID { get; set; }
    }
}
