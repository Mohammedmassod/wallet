
using System.Text.RegularExpressions;

namespace wallet.Domain.Entities
{
    public class Provider :EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public IEnumerable<string> Validate()
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

            if (string.IsNullOrWhiteSpace(Type))
            {
                errors.Add("Type is required");
            }

            if (string.IsNullOrWhiteSpace(Address))
            {
                errors.Add("Address is required");
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                errors.Add("PhoneNumber is required");
            }
            else if (!IsValidPhoneNumber(PhoneNumber))
            {
                errors.Add("Invalid phone number format");
            }

            return errors;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Simple phone number validation for demonstration purposes
            // You can customize this according to your specific requirements
            const string pattern = @"^\d{10}$"; // Assuming a 10-digit phone number
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}

