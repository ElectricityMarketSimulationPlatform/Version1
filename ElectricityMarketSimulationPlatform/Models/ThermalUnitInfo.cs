using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// ThermalUnitInfo表单主要存储的是火电机组的各项数据
    /// </summary>
    public class ThermalUnitInfo
    {
        [Key]
        [Display(Name = "机组ID")]
        public int UnitID { get; set; }
        
        [ForeignKey("GenID")]
        [Display(Name = "所属电厂ID")]
        public string GenID { get; set; }

        [Required]
        [Display(Name = "机组编号")]
        public string GenNo  { get; set; }

        
        [Display(Name = "所在节点")]
        public int NodeNo { get; set; }

        [Display(Name = "最大输出功率")]
        public double PMax { get; set; }

        [Display(Name = "最小输出功率")]
        public int PMin { get; set; }

        [Display(Name = "上爬坡速率")]
        public double RampUp { get; set; }

        [Display(Name = "下爬坡速率")]
        public double RampDown { get; set; }

        [Display(Name = "开机持续时间")]
        public int StartDurTime { get; set; }

        [Display(Name = "关机持续时间")]
        public double CloseDurTime { get; set; }

        [Display(Name = "启动成本")]
        public double H { get; set; }

        [Display(Name = "关停成本")]
        public double J { get; set; }

    }
}
