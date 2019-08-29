using System.Collections.Generic;
using cryptocurrency.Models;

namespace Cryptocurrency.Repositories
{
    public interface ICurrencyRepository
    {
        List<Currency> GetAllCurrencies();
        List<CurrencyInfo> GetAllDataByCurrencyId(int id);
    }
}