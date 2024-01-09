using System;
using System.Collections.Generic;

namespace wallet.Domain.Entities
{
    public class Order:EntityBase
    {
        public Guid Id { get; set; }
        public Guid PaymentId { get; set; }
        public Guid ServiceId { get; set; }
        public string OrderNumber { get; set; }

        #region Relations

        public Service Service { get; set; }

        public ICollection<Transaction> Transactions { get; set; }


        #endregion


    }
}
