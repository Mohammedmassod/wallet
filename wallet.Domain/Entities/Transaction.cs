namespace wallet.Domain.Entities
{
    public class Transaction : EntityBase
    {
      
            public string TransactionType { get; set; }
            public decimal TransactionAmount { get; set; }
            public int OrderId { get; set; }
            public int FromAccount { get; set; }
            public int ToAccount { get; set; }
            public string Status { get; set; }
           // public Account Accounts { get; set; }
          //  public Order Orders { get; set; }


    }
}
