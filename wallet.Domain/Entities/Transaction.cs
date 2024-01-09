using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    public class Transaction
    {
        // Transaction entity
      
            public int TransactionId { get; set; }
            public int CustomerId { get; set; }
            public string TransactionType { get; set; }
            public decimal Amount { get; set; }
            public DateTime TransactionDate { get; set; }
        
    }
}
