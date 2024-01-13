using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    public class Currency : EntityBase
    {
        public int CurrencyId { get; set; }
        public string CurrencyName  { get; set; }
        public string Symbol { get; set; }

    }
}
