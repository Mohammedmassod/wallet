namespace wallet.Domain.Entities
{
    public class Transaction : EntityBase
    {
      
            public string TransactionType { get; set; }
            public decimal TransactionAmount { get; set; }
            public int OrderId { get; set; }
            public int FromAccount { get; set; } //FK From Account
            public int ToAccount { get; set; }//FK From Account
            public string Status { get; set; }

       

    }
}
