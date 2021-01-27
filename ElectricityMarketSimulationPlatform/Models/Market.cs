using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// Market表单主要用于存储所建立市场的信息
    /// </summary>
    public class Market
    {
        [Display(Name = "市场ID")]
        public int MarketID { get; set; }

        [Required]
        [Display(Name = "市场名称")]
        public string MarketName { get; set; }

        [Required]
        [Display(Name = "市场类型标志位")]
        public string MarketTypeFlag { get; set; }

        [Required]
        [RegularExpression(@"^[01]$")]
        [Display(Name = "目标函数标志位")]
        public string ObjFuncFlag { get; set; }

        [Required]
        [RegularExpression(@"^[01]$")]
        [Display(Name = "约束标志位")]
        public string ConsFlag { get; set; }

        [Required]
        [Display(Name = "市场开始时间")]
        public DateTime StartTime { get; set; }

        [Display(Name = "市场结束时间")]
        public DateTime EndTime { get; set; }

        [Required]
        [Display(Name = "管理员UserID")]
        public string AdminID { get; set; }

        // [Display(Name = "目标函数与约束相关参")]
        // public string MatketParaX { get; set; }

        public List<MarketJoin> MarketJoins { get; set; }

        public List<BuyOrder> BuyOrders { get; set; }
        public List<SellOrder> SellOrders { get; set; }
    }
}
