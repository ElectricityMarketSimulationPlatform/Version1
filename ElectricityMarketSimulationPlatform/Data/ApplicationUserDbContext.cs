using ElectricityMarketSimulationPlatform.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Data
{
    public class ApplicationUserDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserDbContext(DbContextOptions<ApplicationUserDbContext> options)
            : base(options)
        {
        }
    }
}
