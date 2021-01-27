﻿// <auto-generated />
using System;
using ElectricityMarketSimulationPlatform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElectricityMarketSimulationPlatform.Migrations.Heavy
{
    [DbContext(typeof(HeavyContext))]
    partial class HeavyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.Agency", b =>
                {
                    b.Property<int>("AgentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MarketID")
                        .HasColumnType("int");

                    b.Property<string>("RetailID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AgentID");

                    b.ToTable("Agencys");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.BuyOrder", b =>
                {
                    b.Property<int>("BuyOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuyID")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("MarketID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<DateTime>("QuoteTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("BuyOrderID");

                    b.ToTable("BuyOrders");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.GenerationCompanyInfo", b =>
                {
                    b.Property<string>("GenID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("BriefName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Capacity")
                        .HasColumnType("double");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("GenNum")
                        .HasColumnType("int");

                    b.HasKey("GenID");

                    b.ToTable("GenerationCompanyInfos");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.HistroyOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MarketID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<DateTime>("QuoteTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("HistroyOrders");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.LargeUserInfo", b =>
                {
                    b.Property<string>("LargeUserID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("IndustryCategory")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NodeNo")
                        .HasColumnType("int");

                    b.Property<string>("SupplyCompany")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("VoltageLevel")
                        .HasColumnType("int");

                    b.HasKey("LargeUserID");

                    b.ToTable("LargeUserInfos");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.Market", b =>
                {
                    b.Property<int>("MarketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConsFlag")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MarketName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MarketTypeFlag")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ObjFuncFlag")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MarketID");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.MarketJoin", b =>
                {
                    b.Property<int>("JoinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("JoinTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MarketID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("JoinID");

                    b.ToTable("MarketJoins");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.MarketResult", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BuyOrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DealTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MarketID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<int>("SellOrderID")
                        .HasColumnType("int");

                    b.Property<bool>("Valid")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("MarketResults");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.RetailCompanyInfo", b =>
                {
                    b.Property<string>("RetailID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("RetailID");

                    b.ToTable("RetailCompanyInfos");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.ScatteredUserInfo", b =>
                {
                    b.Property<string>("ScaID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("GridCompany")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SupplyCompany")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ScaID");

                    b.ToTable("ScatteredUserInfos");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.SellOrder", b =>
                {
                    b.Property<int>("BuyOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuyID")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("MarketID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<DateTime>("QuoteTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("BuyOrderID");

                    b.ToTable("SellOrders");
                });

            modelBuilder.Entity("ElectricityMarketSimulationPlatform.Models.ThermalUnitInfo", b =>
                {
                    b.Property<int>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CloseDurTime")
                        .HasColumnType("double");

                    b.Property<string>("GenID")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("GenNo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("H")
                        .HasColumnType("double");

                    b.Property<double>("J")
                        .HasColumnType("double");

                    b.Property<int>("NodeNo")
                        .HasColumnType("int");

                    b.Property<double>("PMax")
                        .HasColumnType("double");

                    b.Property<int>("PMin")
                        .HasColumnType("int");

                    b.Property<double>("RampDown")
                        .HasColumnType("double");

                    b.Property<double>("RampUp")
                        .HasColumnType("double");

                    b.Property<int>("StartDurTime")
                        .HasColumnType("int");

                    b.HasKey("UnitID");

                    b.ToTable("ThermalUnitInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
