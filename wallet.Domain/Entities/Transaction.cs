using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    public class Transaction : EntityBase
    {
      
            public int TransactionId{ get; set; }
            public string TransactionType { get; set; }
            public int OrderId { get; set; }
            public int OrderStatus { get; set; }
            public int ToAccount { get; set; }
            public DateTime TransactionDate { get; set; }
            public string Status { get; set; }
            public Account Accounts { get; set; }
            public Order Orders { get; set; }


    }
}
