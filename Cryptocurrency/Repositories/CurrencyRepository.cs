using cryptocurrency.Models;
using Cryptocurrency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptocurrency.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public List<Currency> GetAllCurrencies()
        {
            var allcurrencies = new List<Currency>();
            var context = new CryptocurrencyContext();
            allcurrencies = context.Currencies.ToList();
            return allcurrencies;
        }

        public List<CurrencyInfo> GetAllDataByCurrencyId(int id)
        {
            var currencyDataList = new List<CurrencyInfo>();
            var context = new CryptocurrencyContext();
            currencyDataList = context.CurrencyInfos.Where(x => x.CurrencyId == id).ToList(); //todo using

            return currencyDataList;
        }
    }
}
