
namespace wallet.Domain.Entities
{
    public class Service:EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProviderId { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public IEnumerable<string> Validate()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(Name))
            {
                errors.Add("Name is required");
            }

            if (Price < 0)
            {
                errors.Add("Price cannot be negative");
            }

            if (ProviderId <= 0)
            {
                errors.Add("ProviderId must be greater than 0");
            }

            // Optional: Check if IsActive and IsDeleted have valid boolean values
            if (!(IsActive || !IsActive) || !(IsDeleted || !IsDeleted))
            {
                errors.Add("Invalid values for IsActive or IsDeleted");
            }

            return errors;
        }


    }
}
