using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Data
{
    public class HeavyContext :
        IdentityDbContext<ApplicationUser>
    {
        public HeavyContext(DbContextOptions<HeavyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Seed();

            // 获取当前系统所有领域模型上的外键列表
            var foreignKeys = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());

            foreach (var foreigenKey in foreignKeys)
            {
                // 将他们的删除行为配置为Restrict，即无操作
                foreigenKey.DeleteBehavior = DeleteBehavior.Restrict;

            }


            // modelBuilder.Entity<RetailCompanyInfo>()
            //     .HasMany<MarketJoin>(b => b.MarketJoins);
            //
            // modelBuilder.Entity<MarketJoin>().HasMany<MarketUser>(a=>a.MarketUsers);

        }


        public DbSet<MarketUser> MarketUsers { get; set; }
        public DbSet<GenerationCompanyInfo> GenerationCompanyInfos { get; set; }
        public DbSet<ThermalUnitInfo> ThermalUnitInfos { get; set; }
        public DbSet<RetailCompanyInfo> RetailCompanyInfos { get; set; }
        public DbSet<LargeUserInfo> LargeUserInfos { get; set; }
        public DbSet<ScatteredUserInfo> ScatteredUserInfos { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<MarketJoin> MarketJoins { get; set; }
        public DbSet<MarketResult> MarketResults { get; set; }
        public DbSet<Agency> Agencys { get; set; }
        public DbSet<BuyOrder> BuyOrders { get; set; }
        public DbSet<SellOrder> SellOrders { get; set; }
        public DbSet<HistroyOrder> HistroyOrders { get; set; }
    }

}
