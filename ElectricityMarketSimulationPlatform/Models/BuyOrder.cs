using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// BuyOrder表单主要用于记录购电方报价的信息
    /// </summary>
    public class BuyOrder
    {
        [Key]
        [Display(Name = "买方订单ID")]
        public int BuyOrderID { get; set; }

        [Display(Name = "买方ID")]
        public string BuyID { get; set; }

        [Display(Name = "市场ID")]
        public int MarketID { get; set; }

        [Display(Name = "订单价格")]
        public double Price { get; set; }

        [Display(Name = "订单量")]
        public double Quantity { get; set; }

        [Display(Name = "报价时间")]
        public DateTime QuoteTime { get; set; }
        
        [Required]
        [Display(Name = "状态")]
        public bool State { get; set; }

        // [Display(Name = "订单参数")]
        // public int OtherParaX { get; set; }

    }
}
