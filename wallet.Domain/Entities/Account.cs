

namespace wallet.Domain.Entities
{
    // Account entity
    public class Account: EntityBase
    {
        public int CustomerId { get; set; }
        public int ProviderId { get; set; }
        public int AccountType { get; set; }
        public decimal Balance { get; set; }    

        public IEnumerable<string> Validate()
        {
            var errors = new List<string>();

            if (CustomerId <= 0)
            {
                errors.Add("CustomerId must be greater than 0");
            }

            if (ProviderId <= 0)
            {
                errors.Add("ProviderId must be greater than 0");
            }

            if (AccountType <= 0)
            {
                errors.Add("AccountType must be greater than 0");
            }

            if (Balance < 0)
            {
                errors.Add("Balance cannot be negative");
            }

            return errors;
        }


    }
}
