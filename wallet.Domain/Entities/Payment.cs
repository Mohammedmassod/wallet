using System;
using System.Collections.Generic;

namespace wallet.Domain.Entities
{
    public class Payment: EntityBase
    {
        public int Paymentint{ get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Customer Customer { get; set; }

    }
}
