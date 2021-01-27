using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    /// <summary>
    /// GenerationCompanyInfo表单用于存储发电公司的信息
    /// </summary>
    public class GenerationCompanyInfo
    {
        [Key]
        [Display(Name = "发电企业ID")]
        public string GenID { get; set; }

        [Required]
        [Display(Name = "发电厂简称")]
        public string BriefName { get; set; }

        [Required]
        [Display(Name = "所属城市")]
        public string City { get; set; }

        [Display(Name = "总装机容量")]
        public double Capacity { get; set; }

        [Display(Name = "机组数目")]
        public int GenNum { get; set; }
    }
}
