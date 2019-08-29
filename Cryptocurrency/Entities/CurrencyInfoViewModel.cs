using cryptocurrency.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptocurrency.Entities
{
    public class CurrencyInfoViewModel
    {
        [Key]
        public int? CurInfoId { get; set; }


        [ForeignKey("CurrencyId")]
        public int? CurrencyId { get; set; }
        public virtual Currency currency { get; set; }

        public float CurrentPrice { get; set; }
        public long MarkertCap { get; set; }
        public int MarketCapRank { get; set; }
        public long TotalVolume { get; set; }
        public long High24h { get; set; }
        public long Low24h { get; set; }
        public float PriceChange24h { get; set; }
        public float PriceChangePercentage24h { get; set; }
        public long MarketCapChange24h { get; set; }
        public float MarketCapChangePercentage24 { get; set; }
        public long CirculatingSupply { get; set; }
        public long TotalSupply { get; set; }
        public long Ath { get; set; }
        public float AthChangePercentage { get; set; }
        public DateTime AthDate { get; set; }
        public int Roi { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
