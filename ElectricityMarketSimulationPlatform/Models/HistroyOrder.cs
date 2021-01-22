using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// HistroyOrder表单主要用于记录历史报价信息
    /// </summary>
    public class HistroyOrder
    {
        [Display(Name = "历史订单ID")]
        public int ID { get; set; }

        [Display(Name = "订单ID")]
        public int OrderID { get; set; }

        [Display(Name = "用户ID")]
        public string UserID { get; set; }

        [Display(Name = "市场ID")]
        public int MarketID { get; set; }

        [Display(Name = "订单价格")]
        public double Price { get; set; }

        [Display(Name = "订单量")]
        public double Quantity { get; set; }

        [Display(Name = "报价时间")]
        public DateTime QuoteTime { get; set; }

        // [Display(Name = "订单参数")]
        // public int OtherParaX { get; set; }


    }
}
