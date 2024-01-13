

namespace wallet.Domain.Entities
{
    // Account entity
    public class Account: EntityBase
    {
        public int Id{ get; set; }
        public int CustomerId { get; set; }
        public int ProviderId { get; set; }
        public int AccountType { get; set; }
        public decimal Balance { get; set; }


    }
}
