using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cryptocurrency.Models
{
    public class Currency
    {
       [Key]
        public int CurrencyId { get; set; }
        //public virtual ICollection<CurrencyInfo>CurrencyInfos { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }




    }
}
