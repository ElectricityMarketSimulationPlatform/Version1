using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }

        [ProtectedPersonalData]
        [RegularExpression("[0-9]{10}")]
        [Display(Name = "学号")]
        public string IdNumber { get; set; }
    }
}
