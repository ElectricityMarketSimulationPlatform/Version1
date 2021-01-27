using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Data
{
    public class MarketUserDbContext : IdentityDbContext<MarketUser>
    {
        public MarketUserDbContext(DbContextOptions<MarketUserDbContext> options) : base(options)
        {
        }
    }
    
}
