using cryptocurrency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptocurrency.Models
{
    public class CryptocurrencyContext : DbContext
    {
        public CryptocurrencyContext()
        {

        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyInfo> CurrencyInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local)\\sqlexpress;Database= Cryptocurrency;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency
                {
                    CurrencyId = 1,
                    Name = "Bitcoin",

                    Symbol = "B"
                },
                new Currency
                {
                    CurrencyId = 2,
                    Name = "Ethereum",
                    Symbol = "Eth"
                }

            );
            modelBuilder.Entity<CurrencyInfo>().HasData(
                new CurrencyInfo { CurrencyId = 1, CurInfoId = 1, CurrentPrice = 3908, MarkertCap = 50004, MarketCapRank = 1, TotalVolume = 14566324, High24h = 4532, Low24h = 2990, PriceChange24h = 3445, PriceChangePercentage24h = 3, MarketCapChange24h = 345, MarketCapChangePercentage24 = 12, CirculatingSupply = 343546, TotalSupply = 446455642, Ath = 34534655, AthChangePercentage = 3.4f, AthDate = new DateTime(03 / 04 / 2019), Roi = 3, LastUpdated = new DateTime(13 / 8 / 2019) },
                new CurrencyInfo { CurrencyId = 2, CurInfoId = 2, CurrentPrice = 3908, MarkertCap = 50004, MarketCapRank = 1, TotalVolume = 14566324, High24h = 4532, Low24h = 2990, PriceChange24h = 3445, PriceChangePercentage24h = 3, MarketCapChange24h = 345, MarketCapChangePercentage24 = 12, CirculatingSupply = 343546, TotalSupply = 446455642, Ath = 34534655, AthChangePercentage = 3.4f, AthDate = new DateTime(03 / 04 / 2019), Roi = 3, LastUpdated = new DateTime(13 / 8 / 2019) }


            );
        }
    }
}
