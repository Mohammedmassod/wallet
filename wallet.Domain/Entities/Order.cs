using System;

namespace wallet.Domain.Entities
{
    public class Order:EntityBase
    {
        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }
      //  public bool PaymentStatus { get; set; }
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public string OrderNumber { get; set; }
        public int InvoiceId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalOrderAmount { get; set; }
        /*     form Invoice Entity 
         *     public int PaymentId { get; set; } 
                public int ServiceId { get; set; } //FK From Entity Service*/
        public int AccountId { get; set; }

        #region Relations

        public Service Service { get; set; }

        public ICollection<Transaction> Transactions { get; set; }


        #endregion


    }
}
