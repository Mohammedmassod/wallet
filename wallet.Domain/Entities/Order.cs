
namespace wallet.Domain.Entities
{
    public class Order:EntityBase
    {
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public int ServiceId { get; set; }
        public int InvoiceId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalOrderAmount { get; set; }

        public IEnumerable<string> Validate()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(OrderStatus))
            {
                errors.Add("OrderStatus is required");
            }

            if (AccountId <= 0)
            {
                errors.Add("AccountId must be greater than 0");
            }

            if (ProductId <= 0)
            {
                errors.Add("ProductId must be greater than 0");
            }

            if (ServiceId <= 0)
            {
                errors.Add("ServiceId must be greater than 0");
            }

            if (InvoiceId <= 0)
            {
                errors.Add("InvoiceId must be greater than 0");
            }

            if (Quantity <= 0)
            {
                errors.Add("Quantity must be greater than 0");
            }

            if (UnitPrice <= 0)
            {
                errors.Add("UnitPrice must be greater than 0");
            }

            if (TotalOrderAmount < 0)
            {
                errors.Add("TotalOrderAmount cannot be negative");
            }

            return errors;
        }
    }

}

