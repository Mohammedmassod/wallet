using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    // Account entity
    public class Account: EntityBase
    {
        public int AccountId{ get; set; }
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }

        public Wallet Wallets { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }
}
