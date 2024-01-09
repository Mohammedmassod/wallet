using System;
using System.Collections.Generic;

namespace wallet.Domain.Entities
{
    public class Payment 
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }


        /* #region Relations

         public Wallet Wallet { get; set; }
         public ICollection<Order> Orders { get; set; }
 
#endregion*/
    }
}
