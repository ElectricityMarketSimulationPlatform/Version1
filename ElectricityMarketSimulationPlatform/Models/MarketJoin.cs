using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// MarketJoin表单主要用于存储市场成员参与市场的信息
    /// </summary>
    public class MarketJoin
    {
        [Display(Name = "参与关系ID")]
        public int JoinID { get; set; }

        [Display(Name = "用户ID")]
        public string UserID { get; set; }

        [Display(Name = "市场ID")]
        public string MarketID { get; set; }

        [Display(Name = "参与时间")]
        public DateTime JoinTime { get; set; }
    }
}
