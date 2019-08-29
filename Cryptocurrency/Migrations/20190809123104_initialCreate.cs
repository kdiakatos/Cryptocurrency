using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cryptocurrency.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Symbol = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyInfos",
                columns: table => new
                {
                    CurInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyId = table.Column<int>(nullable: true),
                    CurrentPtice = table.Column<float>(nullable: false),
                    MarkertCap = table.Column<long>(nullable: false),
                    MarketCapRank = table.Column<int>(nullable: false),
                    TotalVolume = table.Column<long>(nullable: false),
                    High24h = table.Column<long>(nullable: false),
                    Low24h = table.Column<long>(nullable: false),
                    PriceChange24h = table.Column<float>(nullable: false),
                    PriceChangePercentage24h = table.Column<float>(nullable: false),
                    MarketCapChange24h = table.Column<long>(nullable: false),
                    MarketCapChangePercentage24 = table.Column<float>(nullable: false),
                    CirculatingSupply = table.Column<long>(nullable: false),
                    TotalSupply = table.Column<long>(nullable: false),
                    Ath = table.Column<long>(nullable: false),
                    AthChangePercentage = table.Column<float>(nullable: false),
                    AthDate = table.Column<DateTime>(nullable: false),
                    Roi = table.Column<int>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyInfos", x => x.CurInfoId);
                    table.ForeignKey(
                        name: "FK_CurrencyInfos_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyInfos_CurrencyId",
                table: "CurrencyInfos",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyInfos");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
