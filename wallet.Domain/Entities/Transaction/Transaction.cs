namespace wallet.Domain.Entities.Transaction
{
    public class Transaction : EntityBase
    {

        public string TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public int OrderId { get; set; }
        public int FromAccount { get; set; } //FK From Account
        public int ToAccount { get; set; }//FK From Account
        public string Status { get; set; }

        public IEnumerable<string> ValidateTransaction()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(TransactionType))
            {
                errors.Add("TransactionType is required");
            }

            if (TransactionAmount < 0)
            {
                errors.Add("TransactionAmount cannot be negative");
            }

            if (OrderId <= 0)
            {
                errors.Add("OrderId must be greater than 0");
            }

            if (FromAccount <= 0)
            {
                errors.Add("FromAccount must be greater than 0");
            }

            if (ToAccount <= 0)
            {
                errors.Add("ToAccount must be greater than 0");
            }

            if (string.IsNullOrWhiteSpace(Status))
            {
                errors.Add("Status is required");
            }

            return errors;
        }
    }

}
