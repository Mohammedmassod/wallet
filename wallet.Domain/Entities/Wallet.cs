using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    public class Wallet : EntityBase
    {
        public int WalletId { get; set; }
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }


    }
}
