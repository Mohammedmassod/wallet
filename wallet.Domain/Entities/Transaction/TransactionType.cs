﻿namespace wallet.Domain.Entities.Transaction
{
    public class TransactionType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> ValidateTransactionType()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(Name))
            {
                errors.Add("Name is required");
            }

            if (string.IsNullOrWhiteSpace(Description))
            {
                errors.Add("Description is required");
            }

            return errors;
        }
    }
}
