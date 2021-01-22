using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Data
{
    public class HeavyContext:
        IdentityDbContext<ApplicationUser>
    {
        public HeavyContext(DbContextOptions<HeavyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(b =>
            {

            });
            // modelBuilder.Entity<MarketUser>().HasKey(x => x.UserID);
            modelBuilder.Entity<MarketUser>().HasKey(x => x.UserID);

        }

    }
}
