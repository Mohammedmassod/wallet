namespace wallet.Domain.Entities
{
    // Customer entity
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IEnumerable<string> Validate()
        {
            var errors = new List<string>();

            // Validate Name
            if (string.IsNullOrWhiteSpace(Name))
            {
                errors.Add("Name is required");
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(Email))
            {
                errors.Add("Email is required");
            }
            else if (!IsValidEmail(Email))
            {
                errors.Add("Invalid email address");
            }

            // Validate PhoneNumber (you can add more specific validation logic)
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                errors.Add("Phone number is required");
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(Address))
            {
                errors.Add("Address is required");
            }

            return errors;
        }

        protected internal bool IsValidEmail(string email)
        {
            // Add your email validation logic here
            // For simplicity, this example checks for a basic email format
            return new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email);
        }



    }

}
