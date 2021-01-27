using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectricityMarketSimulationPlatform.Migrations.Heavy
{
    public partial class _data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencys",
                columns: table => new
                {
                    AgentID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RetailID = table.Column<string>(nullable: false),
                    UserID = table.Column<string>(nullable: false),
                    MarketID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencys", x => x.AgentID);
                });

            migrationBuilder.CreateTable(
                name: "BuyOrders",
                columns: table => new
                {
                    BuyOrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuyID = table.Column<string>(nullable: true),
                    MarketID = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    QuoteTime = table.Column<DateTime>(nullable: false),
                    State = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyOrders", x => x.BuyOrderID);
                });

            migrationBuilder.CreateTable(
                name: "GenerationCompanyInfos",
                columns: table => new
                {
                    GenID = table.Column<string>(nullable: false),
                    BriefName = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Capacity = table.Column<double>(nullable: false),
                    GenNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationCompanyInfos", x => x.GenID);
                });

            migrationBuilder.CreateTable(
                name: "HistroyOrders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderID = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: false),
                    MarketID = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    QuoteTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistroyOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LargeUserInfos",
                columns: table => new
                {
                    LargeUserID = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    NodeNo = table.Column<int>(nullable: false),
                    VoltageLevel = table.Column<int>(nullable: false),
                    IndustryCategory = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    SupplyCompany = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LargeUserInfos", x => x.LargeUserID);
                });

            migrationBuilder.CreateTable(
                name: "MarketJoins",
                columns: table => new
                {
                    JoinID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<string>(nullable: false),
                    MarketID = table.Column<string>(nullable: false),
                    JoinTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketJoins", x => x.JoinID);
                });

            migrationBuilder.CreateTable(
                name: "MarketResults",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuyOrderID = table.Column<int>(nullable: false),
                    SellOrderID = table.Column<int>(nullable: false),
                    MarketID = table.Column<string>(nullable: false),
                    DealTime = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Valid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketResults", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarketName = table.Column<string>(nullable: false),
                    MarketTypeFlag = table.Column<string>(nullable: false),
                    ObjFuncFlag = table.Column<string>(nullable: false),
                    ConsFlag = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    AdminID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketID);
                });

            migrationBuilder.CreateTable(
                name: "RetailCompanyInfos",
                columns: table => new
                {
                    RetailID = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    ContactInfo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailCompanyInfos", x => x.RetailID);
                });

            migrationBuilder.CreateTable(
                name: "ScatteredUserInfos",
                columns: table => new
                {
                    ScaID = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    GridCompany = table.Column<string>(nullable: false),
                    SupplyCompany = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScatteredUserInfos", x => x.ScaID);
                });

            migrationBuilder.CreateTable(
                name: "SellOrders",
                columns: table => new
                {
                    BuyOrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuyID = table.Column<string>(nullable: true),
                    MarketID = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    QuoteTime = table.Column<DateTime>(nullable: false),
                    State = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellOrders", x => x.BuyOrderID);
                });

            migrationBuilder.CreateTable(
                name: "ThermalUnitInfos",
                columns: table => new
                {
                    UnitID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GenID = table.Column<string>(nullable: true),
                    GenNo = table.Column<string>(nullable: false),
                    NodeNo = table.Column<int>(nullable: false),
                    PMax = table.Column<double>(nullable: false),
                    PMin = table.Column<int>(nullable: false),
                    RampUp = table.Column<double>(nullable: false),
                    RampDown = table.Column<double>(nullable: false),
                    StartDurTime = table.Column<int>(nullable: false),
                    CloseDurTime = table.Column<double>(nullable: false),
                    H = table.Column<double>(nullable: false),
                    J = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThermalUnitInfos", x => x.UnitID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agencys");

            migrationBuilder.DropTable(
                name: "BuyOrders");

            migrationBuilder.DropTable(
                name: "GenerationCompanyInfos");

            migrationBuilder.DropTable(
                name: "HistroyOrders");

            migrationBuilder.DropTable(
                name: "LargeUserInfos");

            migrationBuilder.DropTable(
                name: "MarketJoins");

            migrationBuilder.DropTable(
                name: "MarketResults");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "RetailCompanyInfos");

            migrationBuilder.DropTable(
                name: "ScatteredUserInfos");

            migrationBuilder.DropTable(
                name: "SellOrders");

            migrationBuilder.DropTable(
                name: "ThermalUnitInfos");
        }
    }
}
