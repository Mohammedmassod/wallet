using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    //Wallet entity
public class Wallet
    {
        public int WalletId { get; set; }
        public int CustomerId { get; set; }
        public int CurrencyId { get; set; }
        public decimal Balance { get; set; }
        // Other relevant properties for wallet
    }
}
