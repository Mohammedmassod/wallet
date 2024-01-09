using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    public class Transaction : EntityBase
    {
      
            public int Transactionint{ get; set; }
            public string TransactionType { get; set; }
            public decimal Amount { get; set; }
            public int ToAcount { get; set; }
            public DateTime TransactionDate { get; set; }
            public Account Accounts { get; set; }
            public Order Orders { get; set; }


    }
}
