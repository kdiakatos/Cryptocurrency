using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cryptocurrency.Migrations
{
    public partial class kostas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentPtice",
                table: "CurrencyInfos",
                newName: "CurrentPrice");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "Name", "Symbol" },
                values: new object[] { 1, "Bitcoin", "B" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "Name", "Symbol" },
                values: new object[] { 2, "Ethereum", "Eth" });

            migrationBuilder.InsertData(
                table: "CurrencyInfos",
                columns: new[] { "CurInfoId", "Ath", "AthChangePercentage", "AthDate", "CirculatingSupply", "CurrencyId", "CurrentPrice", "High24h", "LastUpdated", "Low24h", "MarkertCap", "MarketCapChange24h", "MarketCapChangePercentage24", "MarketCapRank", "PriceChange24h", "PriceChangePercentage24h", "Roi", "TotalSupply", "TotalVolume" },
                values: new object[] { 1, 34534655L, 3.4f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 343546L, 1, 3908f, 4532L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2990L, 50004L, 345L, 12f, 1, 3445f, 3f, 3, 446455642L, 14566324L });

            migrationBuilder.InsertData(
                table: "CurrencyInfos",
                columns: new[] { "CurInfoId", "Ath", "AthChangePercentage", "AthDate", "CirculatingSupply", "CurrencyId", "CurrentPrice", "High24h", "LastUpdated", "Low24h", "MarkertCap", "MarketCapChange24h", "MarketCapChangePercentage24", "MarketCapRank", "PriceChange24h", "PriceChangePercentage24h", "Roi", "TotalSupply", "TotalVolume" },
                values: new object[] { 2, 34534655L, 3.4f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 343546L, 2, 3908f, 4532L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2990L, 50004L, 345L, 12f, 1, 3445f, 3f, 3, 446455642L, 14566324L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrencyInfos",
                keyColumn: "CurInfoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CurrencyInfos",
                keyColumn: "CurInfoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "CurrentPrice",
                table: "CurrencyInfos",
                newName: "CurrentPtice");
        }
    }
}
