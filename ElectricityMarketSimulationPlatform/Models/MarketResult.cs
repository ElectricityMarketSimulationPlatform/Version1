using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// MarketResult表单主要用于存储市场出清结果的信息
    /// </summary>
    public class MarketResult
    {
        [Display(Name = "市场结果ID")]
        public int ID { get; set; }

        [Display(Name = "买方订单ID")]
        public int BuyOrderID { get; set; }

        [Display(Name = "卖方订单ID")]
        public int SellOrderID { get; set; }

        [Required]
        [Display(Name = "市场ID")]
        public string MarketID { get; set; }

        [Display(Name = "成交时间")]
        public DateTime DealTime { get; set; }

        [Display(Name = "交易价格")]
        public double Price { get; set; }

        [Display(Name = "交易电量")]
        public double Quantity { get; set; }

        [Display(Name = "交易结果有效性")]
        public bool Valid { get; set; }

        // MarketResult与 Market是一对一关系
        public Market Markets { get; set; }
    }
}
