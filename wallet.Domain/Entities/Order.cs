
namespace wallet.Domain.Entities
{
    public class Order:EntityBase
    {
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public Service Service { get; set; }
        public int InvoiceId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalOrderAmount { get; set; }

        /*     form Invoice Entity 
         *     public int PaymentId { get; set; } 
                public int ServiceId { get; set; } //FK From Entity Service*/

        #region Relations


       // public ICollection<Transaction> Transactions { get; set; }


        #endregion


    }
}
